using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMeterSimulator
{
    public partial class MainForm : Form
    {
        //milliseconds to delay device transmit
        private int delay = 1000;

        //Queued Background Worker
        private BackgroundQueue queue;
        private bool stopQueue;

        //Delegate to set device data back from DoWork()
        delegate void UpdateDisplayCallback(Sensor sensor);

        //Class to custom sort ListView
        private ListViewColumnSorter lvwColumnSorter;

        public MainForm()
        {
            InitializeComponent();

            //Instantiate Queue Worker
            queue = new BackgroundQueue();
            stopQueue = false;

            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            lvSensorData.ListViewItemSorter = lvwColumnSorter;
            lvwColumnSorter.SortColumn = 2; //TimeStamp column
            lvwColumnSorter.Order = SortOrder.Descending;
            lvSensorData.Sort();

            //Ensure IoT Edge Gateway device root certificate is trusted
            //DeviceManager.InstallCACert();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //There are 10 devices (Sensors) in this sample, Device0 - Device9
            //Provision installed devices with a Device Key
            //Use buttons as a container for each device
            try
            {
                //Loop through the building windows (Buttons)
                foreach (Button button in pDevices.Controls)
                {
                    if (button.Tag == null)
                        continue;

                    var sensor = (Sensor)button.Tag;
                    if(sensor.State == DeviceState.Installed)
                    {
                        string deviceId = button.Name;

                        Task<SmartMeterDevice> taskResult = Task.Run(() => DeviceManager.RegisterDeviceAsync(txtGroupEnrollmentKey.Text, txtIdScope.Text, deviceId));
                        var device = taskResult.Result;

                        //Create a new device (Sensor) object, embed its unique device key
                        sensor.SetRegistrationInformation(device.IoTHubHostName, device.AuthenticationKey);

                        //Change each button color from Yellow to Cyan
                        button.BackColor = Color.Cyan;                
                    }
                    else
                    {
                        //disable uninstalled devices
                        button.Enabled = false;
                    }                   
                }
                btnRegister.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void InstallDevice(object sender, EventArgs e)
        {
            //Clicking on a button window represents installing the device locally
            //by marrying the device to its matching Transmit Status Window

            //Get the button control which is the container for this device
            Button button = (Button)sender;            

            //Set matching Transmit Status Window name, this window shows
            //when a device is transmitting temperature data to IoT Hubs
            string statusId = "Status" + button.Name.Last();
            var sensor = new Sensor(button.Name);
            button.Tag = sensor;

            //Install the device
            sensor.InstallDevice(statusId);

            //Change the color to Yellow to indicate the device has been installed
            button.BackColor = Color.Yellow;
            button.Click -= InstallDevice;
        }
       
        private void btnConnect_Click(object sender, EventArgs e)
        {        
            //Connect all of the activated devices and initiate an event loop 
            // for each connected device to transmit data on regular interval
            stopQueue = false;

            foreach (Button button in pDevices.Controls)
            {
                if (button.Tag == null)
                    continue;

                //Get the sensor object from the button container
                Sensor sensor = (Sensor)button.Tag;
                    
                //Select devices which have been installed and activated
                if (sensor.State == DeviceState.Registered || button.BackColor == Color.Cyan)
                { 
                    //Connect the device, puts into Ready State
                    sensor.ConnectDevice();

                    //add hover event for tool tip for device info
                    button.MouseHover += Device_Hover;                        

                    //Add Sensor to loop
                    if (!stopQueue)
                        queue.QueueTask(() => DoWork(sensor));
                }              
            }            
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            //Stop Loop
            stopQueue = true;
            
            foreach(Button button in pDevices.Controls)
            {
                //Only select devices which have been installed
                if (button.Tag == null)
                    continue;

                button.MouseHover -= Device_Hover;

                //Retrieve the sensor
                Sensor sensor = (Sensor)button.Tag;

                //Select devices that are connected and communicating
                if(sensor.State == DeviceState.Connected || sensor.State == DeviceState.Transmit)
                { 
                    //Disconnect the device, revert to Registered State
                    sensor.DisconnectDevice();

                    //Set color back to Cyan
                    button.BackColor = Color.Cyan;

                    //Set the status window off
                    if (!string.IsNullOrEmpty(sensor.StatusWindow))
                        pStatus.Controls[sensor.StatusWindow].Visible = false;
                }               
            }                      
        }

        private void DoWork(Sensor sensor)
        {            
            switch (sensor.State)
            {
                case DeviceState.Connected:
                    //add some delay
                    Thread.Sleep(delay / 2);

                    //Set device to transmit
                    sensor.State = DeviceState.Transmit;

                    //Send sensor data to Iot Hubs
                    sensor.SendMessageAsync();
                    break;
                case DeviceState.Transmit:
                    //add some delay
                    Thread.Sleep(delay / 2);

                    //set device to ready
                    sensor.State = DeviceState.Connected;
                    break;
            }

            //Check for any cloud-to-device messages sent through IoT Hub:
            if (sensor.State == DeviceState.Connected || sensor.State == DeviceState.Transmit)
            {
                sensor.ReceiveMessageAsync();
            }

            //Update the Device              
            WorkComplete(sensor);           
        }

        private void WorkComplete(Sensor sensor)
        {
            try
            {
                Button button = (Button)pDevices.Controls[sensor.DeviceId];

                if (button.InvokeRequired)
                {   
                    //Use the delegate to get this back onto the main thread
                    UpdateDisplayCallback d = new UpdateDisplayCallback(WorkComplete);
                    Invoke(d, new object[] { sensor });
                }
                else
                {                  
                    //On same thread, pass device data back
                    switch (sensor.State)
                    {
                        case DeviceState.Transmit:
                            //Yellow ball on
                            pStatus.Controls[sensor.StatusWindow].Visible = true;

                            //Set the Sensor's Temperature color on the buildings
                            switch (sensor.TemperatureIndicator)
                            {
                                case SensorState.Cold:
                                    button.BackColor = Color.Blue;
                                    break;
                                case SensorState.Normal:
                                    button.BackColor = Color.Green;
                                    break;
                                case SensorState.Hot:
                                    button.BackColor = Color.Red;
                                    break;
                            }

                            //Update List View of Device Readings
                            string deviceId = sensor.DeviceId.ToString();
                            string currTemp = String.Format("{0:0.0}", sensor.CurrentTemperature);
                            string timeStamp = DateTime.UtcNow.ToString("s"); //sortable DateTimne Format
                            string Voltage= String.Format("{0:0.0}", sensor.CurrentVoltage);

                            //Add sensor data to the list
                            var item1 = new ListViewItem(new[] { deviceId, currTemp, timeStamp, Voltage });
                            lvSensorData.Items.Add(item1);
                            break;

                        case DeviceState.Connected:
                            //Yellow Ball visible
                            pStatus.Controls[sensor.StatusWindow].Visible = false;
                            break;
                    }
                    //Pass sensor data to container
                    button.Tag = sensor;

                    //Display any received messages:
                    if (!string.IsNullOrWhiteSpace(sensor.ReceivedMessage))
                    {
                        var item1 = new ListViewItem(new[] { sensor.DeviceId, $"Message: {sensor.ReceivedMessage}", DateTime.UtcNow.ToString("s") });
                        item1.BackColor = Color.Yellow;
                        lvSensorData.Items.Add(item1);
                        sensor.ReceivedMessage = null;
                    }

                    //Loop
                    if(!stopQueue)
                        queue.QueueTask(() => DoWork(sensor));
                }                    
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Device_Hover(object sender, EventArgs e)
        {
            //Get the Sensor data from the control's tag property
            Button button = (Button)sender;

            if(button.Tag != null)
            { 
                Sensor sensor = (Sensor)button.Tag;

                string tempIndicator = "";

                switch(sensor.TemperatureIndicator)
                {
                    case SensorState.Cold:
                        tempIndicator = "Cold";
                        break;
                    case SensorState.Normal:
                        tempIndicator = "Normal";
                        break;
                    case SensorState.Hot:
                        tempIndicator = "Hot";
                        break;
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Device Id: " + sensor.DeviceId);
                sb.AppendLine("Device Key: " + sensor.DeviceKey);
                sb.AppendLine("");
                sb.AppendLine("Temperature: " + string.Format("{0:0.0}", sensor.CurrentTemperature));
                sb.AppendLine("Indicator: " + tempIndicator);
                ttDeviceStatus.Show(sb.ToString(), button);
            }
        }

        private void txtGroupEnrollmentKey_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
