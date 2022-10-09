using System;
using System.Text;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;


namespace SmartMeterSimulator
{
    /// <summary>
    /// A sensor represents a Smart Meter in the simulator.
    /// </summary>
    class Sensor
    {
        private DeviceClient DeviceClient;
        private string IotHubUri { get; set; }
        public string DeviceId { get; set; }
        public string DeviceKey { get; set; }
        public DeviceState State { get; set; }
        public string StatusWindow { get; set; }
        public string ReceivedMessage { get; set; }
        public double? ReceivedTemperatureSetting { get; set; }
        public double CurrentTemperature
        {
            get
            {
                double avgTemperature = 100;
                Random rand = new Random();
                double currentTemperature = avgTemperature + rand.Next(-6, 6);

                if (ReceivedTemperatureSetting.HasValue)
                {
                    // If we received a cloud-to-device message that sets the temperature, override with the received value.
                    currentTemperature = ReceivedTemperatureSetting.Value;
                }

                if (currentTemperature <= 68)
                    TemperatureIndicator = SensorState.Cold;
                else if (currentTemperature > 68 && currentTemperature < 72)
                    TemperatureIndicator = SensorState.Normal;
                else if (currentTemperature >= 72)
                    TemperatureIndicator = SensorState.Hot;

                return currentTemperature;
            }
        }

        public SensorState TemperatureIndicator { get; set; }
        public double CurrentVoltage
        { 
            get
            {
                double avgVoltage = 0.002;
                Random rand = new Random();
                double currentVoltage = avgVoltage + rand.NextDouble();
                return currentVoltage;
            }
        }
        public Sensor(string deviceId)
        {
            DeviceId = deviceId;

        }

        public void SetRegistrationInformation(string iotHubUri, string deviceKey)
        {
            IotHubUri = iotHubUri;
            DeviceKey = deviceKey;
            State = DeviceState.Registered;
        }
        public void InstallDevice(string statusWindow)
        {
            StatusWindow = statusWindow;
            State = DeviceState.Installed;
        }

        /// <summary>
        /// Connect a device to the IoT Hub by instantiating a DeviceClient for that Device by Id and Key.
        /// </summary>
        public void ConnectDevice()
        {
            //TODO: 6. Connect the Device to Iot Hub by creating an instance of DeviceClient
            DeviceClient = DeviceClient.Create(IotHubUri, new DeviceAuthenticationWithRegistrySymmetricKey(DeviceId, DeviceKey));

            //Set the Device State to Ready
            State = DeviceState.Connected;
        }

        public void DisconnectDevice()
        {
            //Delete the local device client            
            DeviceClient = null;

            //Set the Device State to Activate
            State = DeviceState.Registered;
        }



        /// <summary>
        /// Send a message to the IoT Hub from the Smart Meter device
        /// </summary>
        public async void SendMessageAsync()
        {
            var telemetryDataPoint = new
            {
                id = DeviceId,
                time = DateTime.UtcNow.ToString("o"),
                temp = CurrentTemperature,
                voltage= CurrentVoltage
            };

            //TODO: 7.Serialize the telemetryDataPoint to JSON
            var messageString = JsonConvert.SerializeObject(telemetryDataPoint);

            //TODO: 8.Encode the JSON string to ASCII as bytes and create new Message with the bytes
            var message = new Message(Encoding.ASCII.GetBytes(messageString));

            //TODO: 9.Send the message to the IoT Hub
            var sendEventAsync = DeviceClient?.SendEventAsync(message);
            if (sendEventAsync != null) await sendEventAsync;
        }



        /// <summary>
        /// Check for new messages sent to this device through IoT Hub.
        /// </summary>
        public async void ReceiveMessageAsync()
        {
            if (DeviceClient == null)
                return;

            try
            {
                Message receivedMessage = await DeviceClient?.ReceiveAsync();
                if (receivedMessage == null)
                {
                    ReceivedMessage = null;
                    return;
                }

                //TODO: 10.Set the received message for this sensor to the string value of the message byte array
                ReceivedMessage = Encoding.ASCII.GetString(receivedMessage.GetBytes());
                if (double.TryParse(ReceivedMessage, out var requestedTemperature))
                {
                    ReceivedTemperatureSetting = requestedTemperature;
                }
                else
                {
                    ReceivedTemperatureSetting = null;
                }

                // Send acknowledgement to IoT Hub that the has been successfully processed.
                // The message can be safely removed from the device queue. If something happened
                // that prevented the device app from completing the processing of the message,
                // IoT Hub delivers it again.

                //TODO: 11.Send acknowledgement to IoT hub that the message was processed
                await DeviceClient?.CompleteAsync(receivedMessage);
            }
            catch (Exception)
            {
                // The device client is null, likely due to it being disconnected since this method was called.
                System.Diagnostics.Debug.WriteLine("The DeviceClient is null. This is likely due to it being disconnected since the ReceiveMessageAsync message was called.");
            }
        }
    }


    public enum DeviceState
    {
        New,
        Installed,
        Registered,
        Connected,
        Transmit
    }
    public enum SensorState
    {
        Cold,
        Normal,
        Hot
    }
}
