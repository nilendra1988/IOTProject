namespace SmartMeterSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lvSensorData = new System.Windows.Forms.ListView();
            this.colDeviceID = new System.Windows.Forms.ColumnHeader();
            this.colSensorData = new System.Windows.Forms.ColumnHeader();
            this.colDateTime = new System.Windows.Forms.ColumnHeader();
            this.colVoltage = new System.Windows.Forms.ColumnHeader();
            this.lblSensorInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttDeviceStatus = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.Status0 = new System.Windows.Forms.PictureBox();
            this.Status1 = new System.Windows.Forms.PictureBox();
            this.Status2 = new System.Windows.Forms.PictureBox();
            this.Status3 = new System.Windows.Forms.PictureBox();
            this.Status4 = new System.Windows.Forms.PictureBox();
            this.Status5 = new System.Windows.Forms.PictureBox();
            this.Status6 = new System.Windows.Forms.PictureBox();
            this.Status7 = new System.Windows.Forms.PictureBox();
            this.Status8 = new System.Windows.Forms.PictureBox();
            this.Status9 = new System.Windows.Forms.PictureBox();
            this.pStatus = new System.Windows.Forms.Panel();
            this.lblEnrollmentKey = new System.Windows.Forms.Label();
            this.txtGroupEnrollmentKey = new System.Windows.Forms.TextBox();
            this.txtIdScope = new System.Windows.Forms.TextBox();
            this.lblIdScope = new System.Windows.Forms.Label();
            this.Device6 = new System.Windows.Forms.Button();
            this.Device3 = new System.Windows.Forms.Button();
            this.Device1 = new System.Windows.Forms.Button();
            this.Device7 = new System.Windows.Forms.Button();
            this.Device4 = new System.Windows.Forms.Button();
            this.Device8 = new System.Windows.Forms.Button();
            this.Device2 = new System.Windows.Forms.Button();
            this.Device9 = new System.Windows.Forms.Button();
            this.Device5 = new System.Windows.Forms.Button();
            this.Device0 = new System.Windows.Forms.Button();
            this.pDevices = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Status0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status9)).BeginInit();
            this.pStatus.SuspendLayout();
            this.pDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSensorData
            // 
            this.lvSensorData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDeviceID,
            this.colSensorData,
            this.colDateTime,
            this.colVoltage});
            this.lvSensorData.HideSelection = false;
            this.lvSensorData.Location = new System.Drawing.Point(851, 370);
            this.lvSensorData.Name = "lvSensorData";
            this.lvSensorData.ShowGroups = false;
            this.lvSensorData.Size = new System.Drawing.Size(360, 456);
            this.lvSensorData.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvSensorData.TabIndex = 29;
            this.lvSensorData.UseCompatibleStateImageBehavior = false;
            this.lvSensorData.View = System.Windows.Forms.View.Details;
            // 
            // colDeviceID
            // 
            this.colDeviceID.Text = "Device ID";
            this.colDeviceID.Width = 100;
            // 
            // colSensorData
            // 
            this.colSensorData.Text = "Temperature";
            this.colSensorData.Width = 100;
            // 
            // colDateTime
            // 
            this.colDateTime.Text = "Time Stamp";
            this.colDateTime.Width = 150;
            // 
            // colVoltage
            // 
            this.colVoltage.Text = "KWH";
            this.colVoltage.Width = 100;
            // 
            // lblSensorInfo
            // 
            this.lblSensorInfo.AutoSize = true;
            this.lblSensorInfo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSensorInfo.Location = new System.Drawing.Point(47, 615);
            this.lblSensorInfo.Name = "lblSensorInfo";
            this.lblSensorInfo.Size = new System.Drawing.Size(0, 32);
            this.lblSensorInfo.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(35, 953);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 39);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legend";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "< 68 degrees";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(533, 448);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "68-72 degrees";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(533, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "> 72 degrees";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(533, 488);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Location = new System.Drawing.Point(26, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 82);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Runtime Device Registration";
            // 
            // btnRegister
            // 
            this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegister.Location = new System.Drawing.Point(9, 28);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(128, 34);
            this.btnRegister.TabIndex = 36;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDisconnect);
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Location = new System.Drawing.Point(864, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(398, 82);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device Client";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.BackgroundImage")));
            this.btnDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.Location = new System.Drawing.Point(156, 28);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(128, 34);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.Location = new System.Drawing.Point(11, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 34);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Status0
            // 
            this.Status0.BackColor = System.Drawing.Color.Transparent;
            this.Status0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status0.BackgroundImage")));
            this.Status0.ErrorImage = null;
            this.Status0.InitialImage = null;
            this.Status0.Location = new System.Drawing.Point(16, 54);
            this.Status0.Name = "Status0";
            this.Status0.Size = new System.Drawing.Size(17, 18);
            this.Status0.TabIndex = 0;
            this.Status0.TabStop = false;
            this.Status0.Visible = false;
            // 
            // Status1
            // 
            this.Status1.BackColor = System.Drawing.Color.Transparent;
            this.Status1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status1.BackgroundImage")));
            this.Status1.ErrorImage = null;
            this.Status1.InitialImage = null;
            this.Status1.Location = new System.Drawing.Point(54, 54);
            this.Status1.Name = "Status1";
            this.Status1.Size = new System.Drawing.Size(17, 18);
            this.Status1.TabIndex = 1;
            this.Status1.TabStop = false;
            this.Status1.Visible = false;
            // 
            // Status2
            // 
            this.Status2.BackColor = System.Drawing.Color.Transparent;
            this.Status2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status2.BackgroundImage")));
            this.Status2.ErrorImage = null;
            this.Status2.InitialImage = null;
            this.Status2.Location = new System.Drawing.Point(91, 54);
            this.Status2.Name = "Status2";
            this.Status2.Size = new System.Drawing.Size(17, 18);
            this.Status2.TabIndex = 2;
            this.Status2.TabStop = false;
            this.Status2.Visible = false;
            // 
            // Status3
            // 
            this.Status3.BackColor = System.Drawing.Color.Transparent;
            this.Status3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status3.BackgroundImage")));
            this.Status3.ErrorImage = null;
            this.Status3.InitialImage = null;
            this.Status3.Location = new System.Drawing.Point(124, 55);
            this.Status3.Name = "Status3";
            this.Status3.Size = new System.Drawing.Size(17, 18);
            this.Status3.TabIndex = 3;
            this.Status3.TabStop = false;
            this.Status3.Visible = false;
            // 
            // Status4
            // 
            this.Status4.BackColor = System.Drawing.Color.Transparent;
            this.Status4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status4.BackgroundImage")));
            this.Status4.ErrorImage = null;
            this.Status4.InitialImage = null;
            this.Status4.Location = new System.Drawing.Point(160, 54);
            this.Status4.Name = "Status4";
            this.Status4.Size = new System.Drawing.Size(17, 18);
            this.Status4.TabIndex = 4;
            this.Status4.TabStop = false;
            this.Status4.Visible = false;
            // 
            // Status5
            // 
            this.Status5.BackColor = System.Drawing.Color.Transparent;
            this.Status5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status5.BackgroundImage")));
            this.Status5.ErrorImage = null;
            this.Status5.InitialImage = null;
            this.Status5.Location = new System.Drawing.Point(194, 54);
            this.Status5.Name = "Status5";
            this.Status5.Size = new System.Drawing.Size(17, 18);
            this.Status5.TabIndex = 5;
            this.Status5.TabStop = false;
            this.Status5.Visible = false;
            // 
            // Status6
            // 
            this.Status6.BackColor = System.Drawing.Color.Transparent;
            this.Status6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status6.BackgroundImage")));
            this.Status6.ErrorImage = null;
            this.Status6.InitialImage = null;
            this.Status6.Location = new System.Drawing.Point(229, 54);
            this.Status6.Name = "Status6";
            this.Status6.Size = new System.Drawing.Size(17, 18);
            this.Status6.TabIndex = 6;
            this.Status6.TabStop = false;
            this.Status6.Visible = false;
            // 
            // Status7
            // 
            this.Status7.BackColor = System.Drawing.Color.Transparent;
            this.Status7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status7.BackgroundImage")));
            this.Status7.ErrorImage = null;
            this.Status7.InitialImage = null;
            this.Status7.Location = new System.Drawing.Point(263, 54);
            this.Status7.Name = "Status7";
            this.Status7.Size = new System.Drawing.Size(17, 18);
            this.Status7.TabIndex = 7;
            this.Status7.TabStop = false;
            this.Status7.Visible = false;
            // 
            // Status8
            // 
            this.Status8.BackColor = System.Drawing.Color.Transparent;
            this.Status8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status8.BackgroundImage")));
            this.Status8.ErrorImage = null;
            this.Status8.InitialImage = null;
            this.Status8.Location = new System.Drawing.Point(297, 54);
            this.Status8.Name = "Status8";
            this.Status8.Size = new System.Drawing.Size(17, 18);
            this.Status8.TabIndex = 8;
            this.Status8.TabStop = false;
            this.Status8.Visible = false;
            // 
            // Status9
            // 
            this.Status9.BackColor = System.Drawing.Color.Transparent;
            this.Status9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Status9.BackgroundImage")));
            this.Status9.ErrorImage = null;
            this.Status9.InitialImage = null;
            this.Status9.Location = new System.Drawing.Point(327, 55);
            this.Status9.Name = "Status9";
            this.Status9.Size = new System.Drawing.Size(17, 18);
            this.Status9.TabIndex = 9;
            this.Status9.TabStop = false;
            this.Status9.Visible = false;
            // 
            // pStatus
            // 
            this.pStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pStatus.BackgroundImage")));
            this.pStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pStatus.Controls.Add(this.Status9);
            this.pStatus.Controls.Add(this.Status8);
            this.pStatus.Controls.Add(this.Status7);
            this.pStatus.Controls.Add(this.Status6);
            this.pStatus.Controls.Add(this.Status5);
            this.pStatus.Controls.Add(this.Status4);
            this.pStatus.Controls.Add(this.Status3);
            this.pStatus.Controls.Add(this.Status2);
            this.pStatus.Controls.Add(this.Status1);
            this.pStatus.Controls.Add(this.Status0);
            this.pStatus.Location = new System.Drawing.Point(848, 278);
            this.pStatus.Name = "pStatus";
            this.pStatus.Size = new System.Drawing.Size(360, 86);
            this.pStatus.TabIndex = 28;
            // 
            // lblEnrollmentKey
            // 
            this.lblEnrollmentKey.AutoSize = true;
            this.lblEnrollmentKey.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnrollmentKey.Location = new System.Drawing.Point(14, 38);
            this.lblEnrollmentKey.Name = "lblEnrollmentKey";
            this.lblEnrollmentKey.Size = new System.Drawing.Size(368, 32);
            this.lblEnrollmentKey.TabIndex = 39;
            this.lblEnrollmentKey.Text = "DPS Group Enrollment Primary Key";
            // 
            // txtGroupEnrollmentKey
            // 
            this.txtGroupEnrollmentKey.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGroupEnrollmentKey.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGroupEnrollmentKey.Location = new System.Drawing.Point(26, 101);
            this.txtGroupEnrollmentKey.Name = "txtGroupEnrollmentKey";
            this.txtGroupEnrollmentKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGroupEnrollmentKey.Size = new System.Drawing.Size(470, 33);
            this.txtGroupEnrollmentKey.TabIndex = 38;
            this.txtGroupEnrollmentKey.Text = " nWe8Ail4sPmvA/lU/Nxu3u9GbnDtj/rnrxpyZB+iH+Nf1t09ErzjZ8a+3fCVjWCPF6a2jq9dD2/X3ZZx" +
    "2Db+jA==";
            this.txtGroupEnrollmentKey.TextChanged += new System.EventHandler(this.txtGroupEnrollmentKey_TextChanged);
            // 
            // txtIdScope
            // 
            this.txtIdScope.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIdScope.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIdScope.Location = new System.Drawing.Point(533, 101);
            this.txtIdScope.Name = "txtIdScope";
            this.txtIdScope.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIdScope.Size = new System.Drawing.Size(470, 33);
            this.txtIdScope.TabIndex = 40;
            this.txtIdScope.Text = "0ne007CB2CE";
            // 
            // lblIdScope
            // 
            this.lblIdScope.AutoSize = true;
            this.lblIdScope.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdScope.Location = new System.Drawing.Point(524, 38);
            this.lblIdScope.Name = "lblIdScope";
            this.lblIdScope.Size = new System.Drawing.Size(151, 32);
            this.lblIdScope.TabIndex = 41;
            this.lblIdScope.Text = "DPS ID Scope";
            // 
            // Device6
            // 
            this.Device6.BackColor = System.Drawing.Color.Black;
            this.Device6.FlatAppearance.BorderSize = 0;
            this.Device6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device6.Location = new System.Drawing.Point(32, 450);
            this.Device6.Name = "Device6";
            this.Device6.Size = new System.Drawing.Size(99, 41);
            this.Device6.TabIndex = 6;
            this.Device6.UseVisualStyleBackColor = false;
            this.Device6.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device3
            // 
            this.Device3.BackColor = System.Drawing.Color.Black;
            this.Device3.FlatAppearance.BorderSize = 0;
            this.Device3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device3.Location = new System.Drawing.Point(357, 99);
            this.Device3.Name = "Device3";
            this.Device3.Size = new System.Drawing.Size(112, 41);
            this.Device3.TabIndex = 2;
            this.Device3.UseVisualStyleBackColor = false;
            this.Device3.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device1
            // 
            this.Device1.BackColor = System.Drawing.Color.Black;
            this.Device1.FlatAppearance.BorderSize = 0;
            this.Device1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device1.Location = new System.Drawing.Point(32, 99);
            this.Device1.Name = "Device1";
            this.Device1.Size = new System.Drawing.Size(99, 41);
            this.Device1.TabIndex = 1;
            this.Device1.UseVisualStyleBackColor = false;
            this.Device1.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device7
            // 
            this.Device7.BackColor = System.Drawing.Color.Black;
            this.Device7.FlatAppearance.BorderSize = 0;
            this.Device7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device7.Location = new System.Drawing.Point(459, 146);
            this.Device7.Name = "Device7";
            this.Device7.Size = new System.Drawing.Size(10, 18);
            this.Device7.TabIndex = 7;
            this.Device7.UseVisualStyleBackColor = false;
            this.Device7.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device4
            // 
            this.Device4.BackColor = System.Drawing.Color.Black;
            this.Device4.FlatAppearance.BorderSize = 0;
            this.Device4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device4.Location = new System.Drawing.Point(195, 275);
            this.Device4.Name = "Device4";
            this.Device4.Size = new System.Drawing.Size(100, 41);
            this.Device4.TabIndex = 3;
            this.Device4.UseVisualStyleBackColor = false;
            this.Device4.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device8
            // 
            this.Device8.BackColor = System.Drawing.Color.Black;
            this.Device8.FlatAppearance.BorderSize = 0;
            this.Device8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device8.Location = new System.Drawing.Point(357, 275);
            this.Device8.Name = "Device8";
            this.Device8.Size = new System.Drawing.Size(112, 41);
            this.Device8.TabIndex = 8;
            this.Device8.UseVisualStyleBackColor = false;
            this.Device8.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device2
            // 
            this.Device2.BackColor = System.Drawing.Color.Black;
            this.Device2.FlatAppearance.BorderSize = 0;
            this.Device2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device2.Location = new System.Drawing.Point(32, 275);
            this.Device2.Name = "Device2";
            this.Device2.Size = new System.Drawing.Size(99, 41);
            this.Device2.TabIndex = 4;
            this.Device2.UseVisualStyleBackColor = false;
            this.Device2.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device9
            // 
            this.Device9.BackColor = System.Drawing.Color.Black;
            this.Device9.FlatAppearance.BorderSize = 0;
            this.Device9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device9.Location = new System.Drawing.Point(357, 450);
            this.Device9.Name = "Device9";
            this.Device9.Size = new System.Drawing.Size(112, 41);
            this.Device9.TabIndex = 9;
            this.Device9.UseVisualStyleBackColor = false;
            this.Device9.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device5
            // 
            this.Device5.BackColor = System.Drawing.Color.Black;
            this.Device5.FlatAppearance.BorderSize = 0;
            this.Device5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device5.Location = new System.Drawing.Point(195, 450);
            this.Device5.Name = "Device5";
            this.Device5.Size = new System.Drawing.Size(100, 41);
            this.Device5.TabIndex = 5;
            this.Device5.UseVisualStyleBackColor = false;
            this.Device5.Click += new System.EventHandler(this.InstallDevice);
            // 
            // Device0
            // 
            this.Device0.BackColor = System.Drawing.Color.Black;
            this.Device0.FlatAppearance.BorderSize = 0;
            this.Device0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Device0.Location = new System.Drawing.Point(195, 99);
            this.Device0.Name = "Device0";
            this.Device0.Size = new System.Drawing.Size(100, 41);
            this.Device0.TabIndex = 0;
            this.Device0.Text = " ";
            this.Device0.UseVisualStyleBackColor = false;
            this.Device0.Click += new System.EventHandler(this.InstallDevice);
            // 
            // pDevices
            // 
            this.pDevices.BackColor = System.Drawing.Color.Transparent;
            this.pDevices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pDevices.BackgroundImage")));
            this.pDevices.Controls.Add(this.Device0);
            this.pDevices.Controls.Add(this.Device5);
            this.pDevices.Controls.Add(this.Device9);
            this.pDevices.Controls.Add(this.Device2);
            this.pDevices.Controls.Add(this.Device8);
            this.pDevices.Controls.Add(this.Device4);
            this.pDevices.Controls.Add(this.Device7);
            this.pDevices.Controls.Add(this.Device1);
            this.pDevices.Controls.Add(this.Device3);
            this.pDevices.Controls.Add(this.Device6);
            this.pDevices.Location = new System.Drawing.Point(14, 278);
            this.pDevices.Name = "pDevices";
            this.pDevices.Size = new System.Drawing.Size(499, 525);
            this.pDevices.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1339, 1032);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtIdScope);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIdScope);
            this.Controls.Add(this.txtGroupEnrollmentKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEnrollmentKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvSensorData);
            this.Controls.Add(this.pStatus);
            this.Controls.Add(this.lblSensorInfo);
            this.Controls.Add(this.pDevices);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Smart Meter Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Status0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status9)).EndInit();
            this.pStatus.ResumeLayout(false);
            this.pDevices.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvSensorData;
        private System.Windows.Forms.ColumnHeader colDeviceID;
        private System.Windows.Forms.ColumnHeader colSensorData;
        private System.Windows.Forms.ColumnHeader colVoltage;
        private System.Windows.Forms.Label lblSensorInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColumnHeader colDateTime;
        private System.Windows.Forms.ToolTip ttDeviceStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.PictureBox Status0;
        private System.Windows.Forms.PictureBox Status1;
        private System.Windows.Forms.PictureBox Status2;
        private System.Windows.Forms.PictureBox Status3;
        private System.Windows.Forms.PictureBox Status4;
        private System.Windows.Forms.PictureBox Status5;
        private System.Windows.Forms.PictureBox Status6;
        private System.Windows.Forms.PictureBox Status7;
        private System.Windows.Forms.PictureBox Status8;
        private System.Windows.Forms.PictureBox Status9;
        private System.Windows.Forms.Panel pStatus;
        private System.Windows.Forms.Label lblEnrollmentKey;
        private System.Windows.Forms.TextBox txtGroupEnrollmentKey;
        private System.Windows.Forms.TextBox txtIdScope;
        private System.Windows.Forms.Label lblIdScope;
        private System.Windows.Forms.Button Device6;
        private System.Windows.Forms.Button Device3;
        private System.Windows.Forms.Button Device1;
        private System.Windows.Forms.Button Device7;
        private System.Windows.Forms.Button Device4;
        private System.Windows.Forms.Button Device8;
        private System.Windows.Forms.Button Device2;
        private System.Windows.Forms.Button Device9;
        private System.Windows.Forms.Button Device5;
        private System.Windows.Forms.Button Device0;
        private System.Windows.Forms.Panel pDevices;
    }
}

