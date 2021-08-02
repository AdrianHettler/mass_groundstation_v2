
namespace mass_groundstation_v2
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.lblTcpPort = new System.Windows.Forms.Label();
            this.lblUdpPort = new System.Windows.Forms.Label();
            this.lblGsIP = new System.Windows.Forms.Label();
            this.numTcpPort = new System.Windows.Forms.NumericUpDown();
            this.numUdpPort = new System.Windows.Forms.NumericUpDown();
            this.tbConnectionGsIP = new System.Windows.Forms.TextBox();
            this.lblConnectionExpIP = new System.Windows.Forms.Label();
            this.tbConnectionExpIP = new System.Windows.Forms.TextBox();
            this.tabAmbient = new System.Windows.Forms.TabPage();
            this.groupAmbientPressure = new System.Windows.Forms.GroupBox();
            this.tbAmbientPressure = new System.Windows.Forms.TextBox();
            this.lblAmbientPressure = new System.Windows.Forms.Label();
            this.groupAmbientTemperature = new System.Windows.Forms.GroupBox();
            this.lblAmbientTemperatureOutside = new System.Windows.Forms.Label();
            this.tbAmbientTemperatureOutside = new System.Windows.Forms.TextBox();
            this.lblAmbientTemperatureInside = new System.Windows.Forms.Label();
            this.tbAmbientTemperatureInside = new System.Windows.Forms.TextBox();
            this.tabExperiment = new System.Windows.Forms.TabPage();
            this.btnExpLiftOff = new System.Windows.Forms.Button();
            this.groupExpManualInflation = new System.Windows.Forms.GroupBox();
            this.btnExpInflationOffValve4 = new System.Windows.Forms.Button();
            this.btnExpInflationOffValve3 = new System.Windows.Forms.Button();
            this.btnExpInflationOffValve2 = new System.Windows.Forms.Button();
            this.btnExpInflationOffValve1 = new System.Windows.Forms.Button();
            this.btnExpInflationOnValve4 = new System.Windows.Forms.Button();
            this.btnExpInflationOnValve3 = new System.Windows.Forms.Button();
            this.btnExpInflationOnValve2 = new System.Windows.Forms.Button();
            this.btnExpInflationOnValve1 = new System.Windows.Forms.Button();
            this.pictureExpLogo = new System.Windows.Forms.PictureBox();
            this.groupExpPneu = new System.Windows.Forms.GroupBox();
            this.lblExpPneuInsideStructuresPressure = new System.Windows.Forms.Label();
            this.lblExpPneuOutsideStructuresPressure = new System.Windows.Forms.Label();
            this.lblExpPneuTankPressure = new System.Windows.Forms.Label();
            this.labelExpPneuValve4 = new System.Windows.Forms.Label();
            this.labelExpPneuValve3 = new System.Windows.Forms.Label();
            this.labelExpPneuValve2 = new System.Windows.Forms.Label();
            this.labelExpPneuValve1 = new System.Windows.Forms.Label();
            this.tbExpPneuTankPressure = new System.Windows.Forms.TextBox();
            this.tbExpPneuInsideStructuresPressure = new System.Windows.Forms.TextBox();
            this.tbExpPneuOutsideStructuresPressure = new System.Windows.Forms.TextBox();
            this.pictureExpPneu = new System.Windows.Forms.PictureBox();
            this.groupExpLed = new System.Windows.Forms.GroupBox();
            this.btnExpLedOffStructure2 = new System.Windows.Forms.Button();
            this.btnExpLedOffStructure1 = new System.Windows.Forms.Button();
            this.btnExpLedOnStructure2 = new System.Windows.Forms.Button();
            this.btnExpLedOnStructure1 = new System.Windows.Forms.Button();
            this.groupExpAutoInflation = new System.Windows.Forms.GroupBox();
            this.btnExpInflationStopOutside = new System.Windows.Forms.Button();
            this.btnExpInflationStopInside = new System.Windows.Forms.Button();
            this.btnExpInflationStartOutside = new System.Windows.Forms.Button();
            this.btnExpInflationStartInside = new System.Windows.Forms.Button();
            this.groupExpHDRM = new System.Windows.Forms.GroupBox();
            this.lblExpHDRMActivationTimeOutside = new System.Windows.Forms.Label();
            this.lblExpHDRMActivationTimeInside = new System.Windows.Forms.Label();
            this.numExpHDRMActivationTimeOutside = new System.Windows.Forms.NumericUpDown();
            this.numExpHDRMActivationTimeInside = new System.Windows.Forms.NumericUpDown();
            this.btnExpHDRMOutside = new System.Windows.Forms.Button();
            this.btnExpHDRMInside = new System.Windows.Forms.Button();
            this.groupExpPower = new System.Windows.Forms.GroupBox();
            this.picExpPower = new System.Windows.Forms.PictureBox();
            this.lblExpPowerPower = new System.Windows.Forms.Label();
            this.lblExpPowerCurrent = new System.Windows.Forms.Label();
            this.tbExpPowerPowerEX = new System.Windows.Forms.TextBox();
            this.tbExpPowerPowerBX = new System.Windows.Forms.TextBox();
            this.tbExpPowerCurrentEX = new System.Windows.Forms.TextBox();
            this.tbExpPowerCurrentBX = new System.Windows.Forms.TextBox();
            this.lblExpPowerEXBat = new System.Windows.Forms.Label();
            this.lblExpPowerBXBat = new System.Windows.Forms.Label();
            this.tbExpPowerVoltageEX = new System.Windows.Forms.TextBox();
            this.tbExpPowerVoltageBX = new System.Windows.Forms.TextBox();
            this.lblExpPowerVoltage = new System.Windows.Forms.Label();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.cbLogsEnableLogFile = new System.Windows.Forms.CheckBox();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabelLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConnectionClearTCPList = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTcpPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUdpPort)).BeginInit();
            this.tabAmbient.SuspendLayout();
            this.groupAmbientPressure.SuspendLayout();
            this.groupAmbientTemperature.SuspendLayout();
            this.tabExperiment.SuspendLayout();
            this.groupExpManualInflation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExpLogo)).BeginInit();
            this.groupExpPneu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExpPneu)).BeginInit();
            this.groupExpLed.SuspendLayout();
            this.groupExpAutoInflation.SuspendLayout();
            this.groupExpHDRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpHDRMActivationTimeOutside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpHDRMActivationTimeInside)).BeginInit();
            this.groupExpPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpPower)).BeginInit();
            this.tabLogs.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabConnection);
            this.tabControlMain.Controls.Add(this.tabAmbient);
            this.tabControlMain.Controls.Add(this.tabExperiment);
            this.tabControlMain.Controls.Add(this.tabLogs);
            this.tabControlMain.Location = new System.Drawing.Point(3, 3);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1579, 856);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.btnConnectionClearTCPList);
            this.tabConnection.Controls.Add(this.lblTcpPort);
            this.tabConnection.Controls.Add(this.lblUdpPort);
            this.tabConnection.Controls.Add(this.lblGsIP);
            this.tabConnection.Controls.Add(this.numTcpPort);
            this.tabConnection.Controls.Add(this.numUdpPort);
            this.tabConnection.Controls.Add(this.tbConnectionGsIP);
            this.tabConnection.Controls.Add(this.lblConnectionExpIP);
            this.tabConnection.Controls.Add(this.tbConnectionExpIP);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(1571, 830);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // lblTcpPort
            // 
            this.lblTcpPort.AutoSize = true;
            this.lblTcpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTcpPort.Location = new System.Drawing.Point(45, 113);
            this.lblTcpPort.Name = "lblTcpPort";
            this.lblTcpPort.Size = new System.Drawing.Size(62, 16);
            this.lblTcpPort.TabIndex = 7;
            this.lblTcpPort.Text = "TCP Port";
            // 
            // lblUdpPort
            // 
            this.lblUdpPort.AutoSize = true;
            this.lblUdpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUdpPort.Location = new System.Drawing.Point(43, 87);
            this.lblUdpPort.Name = "lblUdpPort";
            this.lblUdpPort.Size = new System.Drawing.Size(64, 16);
            this.lblUdpPort.TabIndex = 6;
            this.lblUdpPort.Text = "UDP Port";
            // 
            // lblGsIP
            // 
            this.lblGsIP.AutoSize = true;
            this.lblGsIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGsIP.Location = new System.Drawing.Point(43, 62);
            this.lblGsIP.Name = "lblGsIP";
            this.lblGsIP.Size = new System.Drawing.Size(106, 16);
            this.lblGsIP.TabIndex = 5;
            this.lblGsIP.Text = "Groundstation IP";
            // 
            // numTcpPort
            // 
            this.numTcpPort.Location = new System.Drawing.Point(158, 113);
            this.numTcpPort.Name = "numTcpPort";
            this.numTcpPort.Size = new System.Drawing.Size(100, 20);
            this.numTcpPort.TabIndex = 4;
            this.numTcpPort.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numUdpPort
            // 
            this.numUdpPort.Location = new System.Drawing.Point(158, 87);
            this.numUdpPort.Name = "numUdpPort";
            this.numUdpPort.Size = new System.Drawing.Size(100, 20);
            this.numUdpPort.TabIndex = 3;
            this.numUdpPort.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // tbConnectionGsIP
            // 
            this.tbConnectionGsIP.Location = new System.Drawing.Point(158, 61);
            this.tbConnectionGsIP.Name = "tbConnectionGsIP";
            this.tbConnectionGsIP.Size = new System.Drawing.Size(100, 20);
            this.tbConnectionGsIP.TabIndex = 2;
            this.tbConnectionGsIP.Text = "192.168.2.106";
            // 
            // lblConnectionExpIP
            // 
            this.lblConnectionExpIP.AutoSize = true;
            this.lblConnectionExpIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionExpIP.Location = new System.Drawing.Point(43, 36);
            this.lblConnectionExpIP.Name = "lblConnectionExpIP";
            this.lblConnectionExpIP.Size = new System.Drawing.Size(90, 16);
            this.lblConnectionExpIP.TabIndex = 1;
            this.lblConnectionExpIP.Text = "Experiment IP";
            // 
            // tbConnectionExpIP
            // 
            this.tbConnectionExpIP.Location = new System.Drawing.Point(158, 35);
            this.tbConnectionExpIP.Name = "tbConnectionExpIP";
            this.tbConnectionExpIP.Size = new System.Drawing.Size(100, 20);
            this.tbConnectionExpIP.TabIndex = 0;
            this.tbConnectionExpIP.Text = "192.168.2.112";
            // 
            // tabAmbient
            // 
            this.tabAmbient.Controls.Add(this.groupAmbientPressure);
            this.tabAmbient.Controls.Add(this.groupAmbientTemperature);
            this.tabAmbient.Location = new System.Drawing.Point(4, 22);
            this.tabAmbient.Name = "tabAmbient";
            this.tabAmbient.Padding = new System.Windows.Forms.Padding(3);
            this.tabAmbient.Size = new System.Drawing.Size(1571, 830);
            this.tabAmbient.TabIndex = 1;
            this.tabAmbient.Text = "Ambient Conditions";
            this.tabAmbient.UseVisualStyleBackColor = true;
            // 
            // groupAmbientPressure
            // 
            this.groupAmbientPressure.Controls.Add(this.tbAmbientPressure);
            this.groupAmbientPressure.Controls.Add(this.lblAmbientPressure);
            this.groupAmbientPressure.Location = new System.Drawing.Point(790, 6);
            this.groupAmbientPressure.Name = "groupAmbientPressure";
            this.groupAmbientPressure.Size = new System.Drawing.Size(775, 818);
            this.groupAmbientPressure.TabIndex = 1;
            this.groupAmbientPressure.TabStop = false;
            this.groupAmbientPressure.Text = "Pressure";
            // 
            // tbAmbientPressure
            // 
            this.tbAmbientPressure.Location = new System.Drawing.Point(175, 37);
            this.tbAmbientPressure.Name = "tbAmbientPressure";
            this.tbAmbientPressure.ReadOnly = true;
            this.tbAmbientPressure.Size = new System.Drawing.Size(100, 20);
            this.tbAmbientPressure.TabIndex = 1;
            // 
            // lblAmbientPressure
            // 
            this.lblAmbientPressure.AutoSize = true;
            this.lblAmbientPressure.Location = new System.Drawing.Point(84, 40);
            this.lblAmbientPressure.Name = "lblAmbientPressure";
            this.lblAmbientPressure.Size = new System.Drawing.Size(85, 13);
            this.lblAmbientPressure.TabIndex = 0;
            this.lblAmbientPressure.Text = "Current Pressure";
            // 
            // groupAmbientTemperature
            // 
            this.groupAmbientTemperature.Controls.Add(this.lblAmbientTemperatureOutside);
            this.groupAmbientTemperature.Controls.Add(this.tbAmbientTemperatureOutside);
            this.groupAmbientTemperature.Controls.Add(this.lblAmbientTemperatureInside);
            this.groupAmbientTemperature.Controls.Add(this.tbAmbientTemperatureInside);
            this.groupAmbientTemperature.Location = new System.Drawing.Point(6, 6);
            this.groupAmbientTemperature.Name = "groupAmbientTemperature";
            this.groupAmbientTemperature.Size = new System.Drawing.Size(775, 818);
            this.groupAmbientTemperature.TabIndex = 0;
            this.groupAmbientTemperature.TabStop = false;
            this.groupAmbientTemperature.Text = "Temperature";
            // 
            // lblAmbientTemperatureOutside
            // 
            this.lblAmbientTemperatureOutside.AutoSize = true;
            this.lblAmbientTemperatureOutside.Location = new System.Drawing.Point(386, 40);
            this.lblAmbientTemperatureOutside.Name = "lblAmbientTemperatureOutside";
            this.lblAmbientTemperatureOutside.Size = new System.Drawing.Size(143, 13);
            this.lblAmbientTemperatureOutside.TabIndex = 4;
            this.lblAmbientTemperatureOutside.Text = "Current Temperature Outside";
            // 
            // tbAmbientTemperatureOutside
            // 
            this.tbAmbientTemperatureOutside.Location = new System.Drawing.Point(535, 37);
            this.tbAmbientTemperatureOutside.Name = "tbAmbientTemperatureOutside";
            this.tbAmbientTemperatureOutside.ReadOnly = true;
            this.tbAmbientTemperatureOutside.Size = new System.Drawing.Size(100, 20);
            this.tbAmbientTemperatureOutside.TabIndex = 3;
            // 
            // lblAmbientTemperatureInside
            // 
            this.lblAmbientTemperatureInside.AutoSize = true;
            this.lblAmbientTemperatureInside.Location = new System.Drawing.Point(94, 40);
            this.lblAmbientTemperatureInside.Name = "lblAmbientTemperatureInside";
            this.lblAmbientTemperatureInside.Size = new System.Drawing.Size(135, 13);
            this.lblAmbientTemperatureInside.TabIndex = 2;
            this.lblAmbientTemperatureInside.Text = "Current Temperature Inside";
            // 
            // tbAmbientTemperatureInside
            // 
            this.tbAmbientTemperatureInside.Location = new System.Drawing.Point(235, 37);
            this.tbAmbientTemperatureInside.Name = "tbAmbientTemperatureInside";
            this.tbAmbientTemperatureInside.ReadOnly = true;
            this.tbAmbientTemperatureInside.Size = new System.Drawing.Size(100, 20);
            this.tbAmbientTemperatureInside.TabIndex = 1;
            // 
            // tabExperiment
            // 
            this.tabExperiment.Controls.Add(this.btnExpLiftOff);
            this.tabExperiment.Controls.Add(this.groupExpManualInflation);
            this.tabExperiment.Controls.Add(this.pictureExpLogo);
            this.tabExperiment.Controls.Add(this.groupExpPneu);
            this.tabExperiment.Controls.Add(this.groupExpLed);
            this.tabExperiment.Controls.Add(this.groupExpAutoInflation);
            this.tabExperiment.Controls.Add(this.groupExpHDRM);
            this.tabExperiment.Controls.Add(this.groupExpPower);
            this.tabExperiment.Location = new System.Drawing.Point(4, 22);
            this.tabExperiment.Name = "tabExperiment";
            this.tabExperiment.Padding = new System.Windows.Forms.Padding(3);
            this.tabExperiment.Size = new System.Drawing.Size(1571, 830);
            this.tabExperiment.TabIndex = 2;
            this.tabExperiment.Text = "Experiment";
            this.tabExperiment.UseVisualStyleBackColor = true;
            // 
            // btnExpLiftOff
            // 
            this.btnExpLiftOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpLiftOff.Location = new System.Drawing.Point(125, 687);
            this.btnExpLiftOff.Name = "btnExpLiftOff";
            this.btnExpLiftOff.Size = new System.Drawing.Size(181, 74);
            this.btnExpLiftOff.TabIndex = 13;
            this.btnExpLiftOff.Text = "Balloon Lift Off";
            this.btnExpLiftOff.UseVisualStyleBackColor = true;
            this.btnExpLiftOff.Click += new System.EventHandler(this.button_click_handler_misc);
            // 
            // groupExpManualInflation
            // 
            this.groupExpManualInflation.Controls.Add(this.btnExpInflationOffValve4);
            this.groupExpManualInflation.Controls.Add(this.btnExpInflationOffValve3);
            this.groupExpManualInflation.Controls.Add(this.btnExpInflationOffValve2);
            this.groupExpManualInflation.Controls.Add(this.btnExpInflationOffValve1);
            this.groupExpManualInflation.Controls.Add(this.btnExpInflationOnValve4);
            this.groupExpManualInflation.Controls.Add(this.btnExpInflationOnValve3);
            this.groupExpManualInflation.Controls.Add(this.btnExpInflationOnValve2);
            this.groupExpManualInflation.Controls.Add(this.btnExpInflationOnValve1);
            this.groupExpManualInflation.Location = new System.Drawing.Point(7, 349);
            this.groupExpManualInflation.Name = "groupExpManualInflation";
            this.groupExpManualInflation.Size = new System.Drawing.Size(739, 168);
            this.groupExpManualInflation.TabIndex = 12;
            this.groupExpManualInflation.TabStop = false;
            this.groupExpManualInflation.Text = "Manual Inflation";
            // 
            // btnExpInflationOffValve4
            // 
            this.btnExpInflationOffValve4.Location = new System.Drawing.Point(402, 115);
            this.btnExpInflationOffValve4.Name = "btnExpInflationOffValve4";
            this.btnExpInflationOffValve4.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationOffValve4.TabIndex = 12;
            this.btnExpInflationOffValve4.Text = "Valve 4 - OFF";
            this.btnExpInflationOffValve4.UseVisualStyleBackColor = true;
            this.btnExpInflationOffValve4.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOffValve3
            // 
            this.btnExpInflationOffValve3.Location = new System.Drawing.Point(402, 86);
            this.btnExpInflationOffValve3.Name = "btnExpInflationOffValve3";
            this.btnExpInflationOffValve3.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationOffValve3.TabIndex = 11;
            this.btnExpInflationOffValve3.Text = "Valve 3 - OFF";
            this.btnExpInflationOffValve3.UseVisualStyleBackColor = true;
            this.btnExpInflationOffValve3.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOffValve2
            // 
            this.btnExpInflationOffValve2.Location = new System.Drawing.Point(402, 57);
            this.btnExpInflationOffValve2.Name = "btnExpInflationOffValve2";
            this.btnExpInflationOffValve2.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationOffValve2.TabIndex = 10;
            this.btnExpInflationOffValve2.Text = "Valve 2 - OFF";
            this.btnExpInflationOffValve2.UseVisualStyleBackColor = true;
            this.btnExpInflationOffValve2.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOffValve1
            // 
            this.btnExpInflationOffValve1.Location = new System.Drawing.Point(402, 28);
            this.btnExpInflationOffValve1.Name = "btnExpInflationOffValve1";
            this.btnExpInflationOffValve1.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationOffValve1.TabIndex = 9;
            this.btnExpInflationOffValve1.Text = "Valve 1 - OFF";
            this.btnExpInflationOffValve1.UseVisualStyleBackColor = true;
            this.btnExpInflationOffValve1.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOnValve4
            // 
            this.btnExpInflationOnValve4.Location = new System.Drawing.Point(83, 115);
            this.btnExpInflationOnValve4.Name = "btnExpInflationOnValve4";
            this.btnExpInflationOnValve4.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationOnValve4.TabIndex = 8;
            this.btnExpInflationOnValve4.Text = "Valve 4 - ON";
            this.btnExpInflationOnValve4.UseVisualStyleBackColor = true;
            this.btnExpInflationOnValve4.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOnValve3
            // 
            this.btnExpInflationOnValve3.Location = new System.Drawing.Point(83, 86);
            this.btnExpInflationOnValve3.Name = "btnExpInflationOnValve3";
            this.btnExpInflationOnValve3.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationOnValve3.TabIndex = 7;
            this.btnExpInflationOnValve3.Text = "Valve 3 - ON";
            this.btnExpInflationOnValve3.UseVisualStyleBackColor = true;
            this.btnExpInflationOnValve3.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOnValve2
            // 
            this.btnExpInflationOnValve2.Location = new System.Drawing.Point(83, 57);
            this.btnExpInflationOnValve2.Name = "btnExpInflationOnValve2";
            this.btnExpInflationOnValve2.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationOnValve2.TabIndex = 6;
            this.btnExpInflationOnValve2.Text = "Valve 2 - ON";
            this.btnExpInflationOnValve2.UseVisualStyleBackColor = true;
            this.btnExpInflationOnValve2.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOnValve1
            // 
            this.btnExpInflationOnValve1.Location = new System.Drawing.Point(83, 28);
            this.btnExpInflationOnValve1.Name = "btnExpInflationOnValve1";
            this.btnExpInflationOnValve1.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationOnValve1.TabIndex = 5;
            this.btnExpInflationOnValve1.Text = "Valve 1 - ON";
            this.btnExpInflationOnValve1.UseVisualStyleBackColor = true;
            this.btnExpInflationOnValve1.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // pictureExpLogo
            // 
            this.pictureExpLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureExpLogo.Image")));
            this.pictureExpLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureExpLogo.InitialImage")));
            this.pictureExpLogo.Location = new System.Drawing.Point(410, 634);
            this.pictureExpLogo.Name = "pictureExpLogo";
            this.pictureExpLogo.Size = new System.Drawing.Size(241, 190);
            this.pictureExpLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExpLogo.TabIndex = 9;
            this.pictureExpLogo.TabStop = false;
            // 
            // groupExpPneu
            // 
            this.groupExpPneu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupExpPneu.Controls.Add(this.lblExpPneuInsideStructuresPressure);
            this.groupExpPneu.Controls.Add(this.lblExpPneuOutsideStructuresPressure);
            this.groupExpPneu.Controls.Add(this.lblExpPneuTankPressure);
            this.groupExpPneu.Controls.Add(this.labelExpPneuValve4);
            this.groupExpPneu.Controls.Add(this.labelExpPneuValve3);
            this.groupExpPneu.Controls.Add(this.labelExpPneuValve2);
            this.groupExpPneu.Controls.Add(this.labelExpPneuValve1);
            this.groupExpPneu.Controls.Add(this.tbExpPneuTankPressure);
            this.groupExpPneu.Controls.Add(this.tbExpPneuInsideStructuresPressure);
            this.groupExpPneu.Controls.Add(this.tbExpPneuOutsideStructuresPressure);
            this.groupExpPneu.Controls.Add(this.pictureExpPneu);
            this.groupExpPneu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupExpPneu.Location = new System.Drawing.Point(752, 6);
            this.groupExpPneu.Name = "groupExpPneu";
            this.groupExpPneu.Size = new System.Drawing.Size(813, 818);
            this.groupExpPneu.TabIndex = 11;
            this.groupExpPneu.TabStop = false;
            this.groupExpPneu.Text = "Pneumatics Overview";
            // 
            // lblExpPneuInsideStructuresPressure
            // 
            this.lblExpPneuInsideStructuresPressure.AutoSize = true;
            this.lblExpPneuInsideStructuresPressure.Location = new System.Drawing.Point(374, 452);
            this.lblExpPneuInsideStructuresPressure.Name = "lblExpPneuInsideStructuresPressure";
            this.lblExpPneuInsideStructuresPressure.Size = new System.Drawing.Size(86, 26);
            this.lblExpPneuInsideStructuresPressure.TabIndex = 28;
            this.lblExpPneuInsideStructuresPressure.Text = "Inside Structures\r\nPressure";
            // 
            // lblExpPneuOutsideStructuresPressure
            // 
            this.lblExpPneuOutsideStructuresPressure.AutoSize = true;
            this.lblExpPneuOutsideStructuresPressure.Location = new System.Drawing.Point(374, 41);
            this.lblExpPneuOutsideStructuresPressure.Name = "lblExpPneuOutsideStructuresPressure";
            this.lblExpPneuOutsideStructuresPressure.Size = new System.Drawing.Size(97, 26);
            this.lblExpPneuOutsideStructuresPressure.TabIndex = 27;
            this.lblExpPneuOutsideStructuresPressure.Text = "Outside Structures \r\nPressure";
            // 
            // lblExpPneuTankPressure
            // 
            this.lblExpPneuTankPressure.AutoSize = true;
            this.lblExpPneuTankPressure.Location = new System.Drawing.Point(53, 191);
            this.lblExpPneuTankPressure.Name = "lblExpPneuTankPressure";
            this.lblExpPneuTankPressure.Size = new System.Drawing.Size(76, 13);
            this.lblExpPneuTankPressure.TabIndex = 26;
            this.lblExpPneuTankPressure.Text = "Tank Pressure";
            // 
            // labelExpPneuValve4
            // 
            this.labelExpPneuValve4.AutoSize = true;
            this.labelExpPneuValve4.Location = new System.Drawing.Point(632, 178);
            this.labelExpPneuValve4.Name = "labelExpPneuValve4";
            this.labelExpPneuValve4.Size = new System.Drawing.Size(13, 13);
            this.labelExpPneuValve4.TabIndex = 25;
            this.labelExpPneuValve4.Text = "4";
            // 
            // labelExpPneuValve3
            // 
            this.labelExpPneuValve3.AutoSize = true;
            this.labelExpPneuValve3.Location = new System.Drawing.Point(507, 313);
            this.labelExpPneuValve3.Name = "labelExpPneuValve3";
            this.labelExpPneuValve3.Size = new System.Drawing.Size(13, 13);
            this.labelExpPneuValve3.TabIndex = 24;
            this.labelExpPneuValve3.Text = "3";
            // 
            // labelExpPneuValve2
            // 
            this.labelExpPneuValve2.AutoSize = true;
            this.labelExpPneuValve2.Location = new System.Drawing.Point(632, 585);
            this.labelExpPneuValve2.Name = "labelExpPneuValve2";
            this.labelExpPneuValve2.Size = new System.Drawing.Size(13, 13);
            this.labelExpPneuValve2.TabIndex = 23;
            this.labelExpPneuValve2.Text = "2";
            // 
            // labelExpPneuValve1
            // 
            this.labelExpPneuValve1.AutoSize = true;
            this.labelExpPneuValve1.Location = new System.Drawing.Point(507, 722);
            this.labelExpPneuValve1.Name = "labelExpPneuValve1";
            this.labelExpPneuValve1.Size = new System.Drawing.Size(13, 13);
            this.labelExpPneuValve1.TabIndex = 22;
            this.labelExpPneuValve1.Text = "1";
            // 
            // tbExpPneuTankPressure
            // 
            this.tbExpPneuTankPressure.Location = new System.Drawing.Point(56, 207);
            this.tbExpPneuTankPressure.Name = "tbExpPneuTankPressure";
            this.tbExpPneuTankPressure.ReadOnly = true;
            this.tbExpPneuTankPressure.Size = new System.Drawing.Size(73, 20);
            this.tbExpPneuTankPressure.TabIndex = 8;
            // 
            // tbExpPneuInsideStructuresPressure
            // 
            this.tbExpPneuInsideStructuresPressure.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbExpPneuInsideStructuresPressure.Location = new System.Drawing.Point(377, 481);
            this.tbExpPneuInsideStructuresPressure.Name = "tbExpPneuInsideStructuresPressure";
            this.tbExpPneuInsideStructuresPressure.ReadOnly = true;
            this.tbExpPneuInsideStructuresPressure.Size = new System.Drawing.Size(73, 20);
            this.tbExpPneuInsideStructuresPressure.TabIndex = 7;
            // 
            // tbExpPneuOutsideStructuresPressure
            // 
            this.tbExpPneuOutsideStructuresPressure.Location = new System.Drawing.Point(377, 70);
            this.tbExpPneuOutsideStructuresPressure.Name = "tbExpPneuOutsideStructuresPressure";
            this.tbExpPneuOutsideStructuresPressure.ReadOnly = true;
            this.tbExpPneuOutsideStructuresPressure.Size = new System.Drawing.Size(73, 20);
            this.tbExpPneuOutsideStructuresPressure.TabIndex = 6;
            // 
            // pictureExpPneu
            // 
            this.pictureExpPneu.Image = ((System.Drawing.Image)(resources.GetObject("pictureExpPneu.Image")));
            this.pictureExpPneu.Location = new System.Drawing.Point(46, 41);
            this.pictureExpPneu.Name = "pictureExpPneu";
            this.pictureExpPneu.Size = new System.Drawing.Size(721, 740);
            this.pictureExpPneu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExpPneu.TabIndex = 0;
            this.pictureExpPneu.TabStop = false;
            // 
            // groupExpLed
            // 
            this.groupExpLed.Controls.Add(this.btnExpLedOffStructure2);
            this.groupExpLed.Controls.Add(this.btnExpLedOffStructure1);
            this.groupExpLed.Controls.Add(this.btnExpLedOnStructure2);
            this.groupExpLed.Controls.Add(this.btnExpLedOnStructure1);
            this.groupExpLed.Location = new System.Drawing.Point(7, 523);
            this.groupExpLed.Name = "groupExpLed";
            this.groupExpLed.Size = new System.Drawing.Size(740, 105);
            this.groupExpLed.TabIndex = 8;
            this.groupExpLed.TabStop = false;
            this.groupExpLed.Text = "UV Leds";
            // 
            // btnExpLedOffStructure2
            // 
            this.btnExpLedOffStructure2.Location = new System.Drawing.Point(403, 60);
            this.btnExpLedOffStructure2.Name = "btnExpLedOffStructure2";
            this.btnExpLedOffStructure2.Size = new System.Drawing.Size(253, 23);
            this.btnExpLedOffStructure2.TabIndex = 4;
            this.btnExpLedOffStructure2.Text = "UV - OFF Structure 2";
            this.btnExpLedOffStructure2.UseVisualStyleBackColor = true;
            this.btnExpLedOffStructure2.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpLedOffStructure1
            // 
            this.btnExpLedOffStructure1.Location = new System.Drawing.Point(86, 60);
            this.btnExpLedOffStructure1.Name = "btnExpLedOffStructure1";
            this.btnExpLedOffStructure1.Size = new System.Drawing.Size(253, 23);
            this.btnExpLedOffStructure1.TabIndex = 3;
            this.btnExpLedOffStructure1.Text = "UV - OFF Structure 1";
            this.btnExpLedOffStructure1.UseVisualStyleBackColor = true;
            this.btnExpLedOffStructure1.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpLedOnStructure2
            // 
            this.btnExpLedOnStructure2.Location = new System.Drawing.Point(403, 31);
            this.btnExpLedOnStructure2.Name = "btnExpLedOnStructure2";
            this.btnExpLedOnStructure2.Size = new System.Drawing.Size(253, 23);
            this.btnExpLedOnStructure2.TabIndex = 2;
            this.btnExpLedOnStructure2.Text = "UV - ON Structure 2";
            this.btnExpLedOnStructure2.UseVisualStyleBackColor = true;
            this.btnExpLedOnStructure2.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpLedOnStructure1
            // 
            this.btnExpLedOnStructure1.Location = new System.Drawing.Point(86, 31);
            this.btnExpLedOnStructure1.Name = "btnExpLedOnStructure1";
            this.btnExpLedOnStructure1.Size = new System.Drawing.Size(253, 23);
            this.btnExpLedOnStructure1.TabIndex = 1;
            this.btnExpLedOnStructure1.Text = "UV - ON Structure 1";
            this.btnExpLedOnStructure1.UseVisualStyleBackColor = true;
            this.btnExpLedOnStructure1.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // groupExpAutoInflation
            // 
            this.groupExpAutoInflation.Controls.Add(this.btnExpInflationStopOutside);
            this.groupExpAutoInflation.Controls.Add(this.btnExpInflationStopInside);
            this.groupExpAutoInflation.Controls.Add(this.btnExpInflationStartOutside);
            this.groupExpAutoInflation.Controls.Add(this.btnExpInflationStartInside);
            this.groupExpAutoInflation.Location = new System.Drawing.Point(6, 234);
            this.groupExpAutoInflation.Name = "groupExpAutoInflation";
            this.groupExpAutoInflation.Size = new System.Drawing.Size(740, 108);
            this.groupExpAutoInflation.TabIndex = 7;
            this.groupExpAutoInflation.TabStop = false;
            this.groupExpAutoInflation.Text = "Automated Inflation";
            // 
            // btnExpInflationStopOutside
            // 
            this.btnExpInflationStopOutside.Location = new System.Drawing.Point(403, 60);
            this.btnExpInflationStopOutside.Name = "btnExpInflationStopOutside";
            this.btnExpInflationStopOutside.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationStopOutside.TabIndex = 7;
            this.btnExpInflationStopOutside.Text = "Inflation Stop Outside";
            this.btnExpInflationStopOutside.UseVisualStyleBackColor = true;
            this.btnExpInflationStopOutside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationStopInside
            // 
            this.btnExpInflationStopInside.Location = new System.Drawing.Point(84, 60);
            this.btnExpInflationStopInside.Name = "btnExpInflationStopInside";
            this.btnExpInflationStopInside.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationStopInside.TabIndex = 6;
            this.btnExpInflationStopInside.Text = "Inflation Stop Inside";
            this.btnExpInflationStopInside.UseVisualStyleBackColor = true;
            this.btnExpInflationStopInside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationStartOutside
            // 
            this.btnExpInflationStartOutside.Location = new System.Drawing.Point(404, 31);
            this.btnExpInflationStartOutside.Name = "btnExpInflationStartOutside";
            this.btnExpInflationStartOutside.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationStartOutside.TabIndex = 5;
            this.btnExpInflationStartOutside.Text = "Inflation Start Outside";
            this.btnExpInflationStartOutside.UseVisualStyleBackColor = true;
            this.btnExpInflationStartOutside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationStartInside
            // 
            this.btnExpInflationStartInside.Location = new System.Drawing.Point(84, 31);
            this.btnExpInflationStartInside.Name = "btnExpInflationStartInside";
            this.btnExpInflationStartInside.Size = new System.Drawing.Size(253, 23);
            this.btnExpInflationStartInside.TabIndex = 4;
            this.btnExpInflationStartInside.Text = "Inflation Start Inside";
            this.btnExpInflationStartInside.UseVisualStyleBackColor = true;
            this.btnExpInflationStartInside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // groupExpHDRM
            // 
            this.groupExpHDRM.Controls.Add(this.lblExpHDRMActivationTimeOutside);
            this.groupExpHDRM.Controls.Add(this.lblExpHDRMActivationTimeInside);
            this.groupExpHDRM.Controls.Add(this.numExpHDRMActivationTimeOutside);
            this.groupExpHDRM.Controls.Add(this.numExpHDRMActivationTimeInside);
            this.groupExpHDRM.Controls.Add(this.btnExpHDRMOutside);
            this.groupExpHDRM.Controls.Add(this.btnExpHDRMInside);
            this.groupExpHDRM.Location = new System.Drawing.Point(6, 126);
            this.groupExpHDRM.Name = "groupExpHDRM";
            this.groupExpHDRM.Size = new System.Drawing.Size(740, 102);
            this.groupExpHDRM.TabIndex = 5;
            this.groupExpHDRM.TabStop = false;
            this.groupExpHDRM.Text = "HDRM";
            // 
            // lblExpHDRMActivationTimeOutside
            // 
            this.lblExpHDRMActivationTimeOutside.AutoSize = true;
            this.lblExpHDRMActivationTimeOutside.Location = new System.Drawing.Point(482, 60);
            this.lblExpHDRMActivationTimeOutside.Name = "lblExpHDRMActivationTimeOutside";
            this.lblExpHDRMActivationTimeOutside.Size = new System.Drawing.Size(105, 13);
            this.lblExpHDRMActivationTimeOutside.TabIndex = 7;
            this.lblExpHDRMActivationTimeOutside.Text = "Activation Time in [s]";
            // 
            // lblExpHDRMActivationTimeInside
            // 
            this.lblExpHDRMActivationTimeInside.AutoSize = true;
            this.lblExpHDRMActivationTimeInside.Location = new System.Drawing.Point(165, 60);
            this.lblExpHDRMActivationTimeInside.Name = "lblExpHDRMActivationTimeInside";
            this.lblExpHDRMActivationTimeInside.Size = new System.Drawing.Size(105, 13);
            this.lblExpHDRMActivationTimeInside.TabIndex = 6;
            this.lblExpHDRMActivationTimeInside.Text = "Activation Time in [s]";
            // 
            // numExpHDRMActivationTimeOutside
            // 
            this.numExpHDRMActivationTimeOutside.Location = new System.Drawing.Point(593, 58);
            this.numExpHDRMActivationTimeOutside.Name = "numExpHDRMActivationTimeOutside";
            this.numExpHDRMActivationTimeOutside.Size = new System.Drawing.Size(64, 20);
            this.numExpHDRMActivationTimeOutside.TabIndex = 3;
            this.numExpHDRMActivationTimeOutside.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numExpHDRMActivationTimeInside
            // 
            this.numExpHDRMActivationTimeInside.Location = new System.Drawing.Point(276, 58);
            this.numExpHDRMActivationTimeInside.Name = "numExpHDRMActivationTimeInside";
            this.numExpHDRMActivationTimeInside.Size = new System.Drawing.Size(63, 20);
            this.numExpHDRMActivationTimeInside.TabIndex = 2;
            this.numExpHDRMActivationTimeInside.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnExpHDRMOutside
            // 
            this.btnExpHDRMOutside.Location = new System.Drawing.Point(403, 29);
            this.btnExpHDRMOutside.Name = "btnExpHDRMOutside";
            this.btnExpHDRMOutside.Size = new System.Drawing.Size(254, 23);
            this.btnExpHDRMOutside.TabIndex = 1;
            this.btnExpHDRMOutside.Text = "Release HDRM Outside";
            this.btnExpHDRMOutside.UseVisualStyleBackColor = true;
            this.btnExpHDRMOutside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpHDRMInside
            // 
            this.btnExpHDRMInside.Location = new System.Drawing.Point(86, 29);
            this.btnExpHDRMInside.Name = "btnExpHDRMInside";
            this.btnExpHDRMInside.Size = new System.Drawing.Size(253, 23);
            this.btnExpHDRMInside.TabIndex = 0;
            this.btnExpHDRMInside.Text = "Release HDRM Inside";
            this.btnExpHDRMInside.UseVisualStyleBackColor = true;
            this.btnExpHDRMInside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // groupExpPower
            // 
            this.groupExpPower.Controls.Add(this.picExpPower);
            this.groupExpPower.Controls.Add(this.lblExpPowerPower);
            this.groupExpPower.Controls.Add(this.lblExpPowerCurrent);
            this.groupExpPower.Controls.Add(this.tbExpPowerPowerEX);
            this.groupExpPower.Controls.Add(this.tbExpPowerPowerBX);
            this.groupExpPower.Controls.Add(this.tbExpPowerCurrentEX);
            this.groupExpPower.Controls.Add(this.tbExpPowerCurrentBX);
            this.groupExpPower.Controls.Add(this.lblExpPowerEXBat);
            this.groupExpPower.Controls.Add(this.lblExpPowerBXBat);
            this.groupExpPower.Controls.Add(this.tbExpPowerVoltageEX);
            this.groupExpPower.Controls.Add(this.tbExpPowerVoltageBX);
            this.groupExpPower.Controls.Add(this.lblExpPowerVoltage);
            this.groupExpPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupExpPower.Location = new System.Drawing.Point(6, 6);
            this.groupExpPower.Name = "groupExpPower";
            this.groupExpPower.Size = new System.Drawing.Size(740, 114);
            this.groupExpPower.TabIndex = 4;
            this.groupExpPower.TabStop = false;
            this.groupExpPower.Text = "Power";
            // 
            // picExpPower
            // 
            this.picExpPower.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picExpPower.Image = ((System.Drawing.Image)(resources.GetObject("picExpPower.Image")));
            this.picExpPower.Location = new System.Drawing.Point(37, 19);
            this.picExpPower.Name = "picExpPower";
            this.picExpPower.Size = new System.Drawing.Size(158, 84);
            this.picExpPower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExpPower.TabIndex = 4;
            this.picExpPower.TabStop = false;
            // 
            // lblExpPowerPower
            // 
            this.lblExpPowerPower.AutoSize = true;
            this.lblExpPowerPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpPowerPower.Location = new System.Drawing.Point(557, 25);
            this.lblExpPowerPower.Name = "lblExpPowerPower";
            this.lblExpPowerPower.Size = new System.Drawing.Size(42, 13);
            this.lblExpPowerPower.TabIndex = 8;
            this.lblExpPowerPower.Text = "Power";
            // 
            // lblExpPowerCurrent
            // 
            this.lblExpPowerCurrent.AutoSize = true;
            this.lblExpPowerCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpPowerCurrent.Location = new System.Drawing.Point(451, 25);
            this.lblExpPowerCurrent.Name = "lblExpPowerCurrent";
            this.lblExpPowerCurrent.Size = new System.Drawing.Size(48, 13);
            this.lblExpPowerCurrent.TabIndex = 1;
            this.lblExpPowerCurrent.Text = "Current";
            // 
            // tbExpPowerPowerEX
            // 
            this.tbExpPowerPowerEX.Location = new System.Drawing.Point(560, 67);
            this.tbExpPowerPowerEX.Name = "tbExpPowerPowerEX";
            this.tbExpPowerPowerEX.ReadOnly = true;
            this.tbExpPowerPowerEX.Size = new System.Drawing.Size(100, 20);
            this.tbExpPowerPowerEX.TabIndex = 7;
            // 
            // tbExpPowerPowerBX
            // 
            this.tbExpPowerPowerBX.Location = new System.Drawing.Point(560, 41);
            this.tbExpPowerPowerBX.Name = "tbExpPowerPowerBX";
            this.tbExpPowerPowerBX.ReadOnly = true;
            this.tbExpPowerPowerBX.Size = new System.Drawing.Size(100, 20);
            this.tbExpPowerPowerBX.TabIndex = 6;
            // 
            // tbExpPowerCurrentEX
            // 
            this.tbExpPowerCurrentEX.Location = new System.Drawing.Point(454, 67);
            this.tbExpPowerCurrentEX.Name = "tbExpPowerCurrentEX";
            this.tbExpPowerCurrentEX.ReadOnly = true;
            this.tbExpPowerCurrentEX.Size = new System.Drawing.Size(100, 20);
            this.tbExpPowerCurrentEX.TabIndex = 5;
            // 
            // tbExpPowerCurrentBX
            // 
            this.tbExpPowerCurrentBX.Location = new System.Drawing.Point(454, 41);
            this.tbExpPowerCurrentBX.Name = "tbExpPowerCurrentBX";
            this.tbExpPowerCurrentBX.ReadOnly = true;
            this.tbExpPowerCurrentBX.Size = new System.Drawing.Size(100, 20);
            this.tbExpPowerCurrentBX.TabIndex = 4;
            // 
            // lblExpPowerEXBat
            // 
            this.lblExpPowerEXBat.AutoSize = true;
            this.lblExpPowerEXBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpPowerEXBat.Location = new System.Drawing.Point(225, 68);
            this.lblExpPowerEXBat.Name = "lblExpPowerEXBat";
            this.lblExpPowerEXBat.Size = new System.Drawing.Size(115, 15);
            this.lblExpPowerEXBat.TabIndex = 1;
            this.lblExpPowerEXBat.Text = "EXTRA BATTERY";
            // 
            // lblExpPowerBXBat
            // 
            this.lblExpPowerBXBat.AutoSize = true;
            this.lblExpPowerBXBat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpPowerBXBat.Location = new System.Drawing.Point(225, 42);
            this.lblExpPowerBXBat.Name = "lblExpPowerBXBat";
            this.lblExpPowerBXBat.Size = new System.Drawing.Size(117, 15);
            this.lblExpPowerBXBat.TabIndex = 0;
            this.lblExpPowerBXBat.Text = "BEXUS BATTERY";
            // 
            // tbExpPowerVoltageEX
            // 
            this.tbExpPowerVoltageEX.Location = new System.Drawing.Point(348, 67);
            this.tbExpPowerVoltageEX.Name = "tbExpPowerVoltageEX";
            this.tbExpPowerVoltageEX.ReadOnly = true;
            this.tbExpPowerVoltageEX.Size = new System.Drawing.Size(100, 20);
            this.tbExpPowerVoltageEX.TabIndex = 2;
            // 
            // tbExpPowerVoltageBX
            // 
            this.tbExpPowerVoltageBX.Location = new System.Drawing.Point(348, 41);
            this.tbExpPowerVoltageBX.Name = "tbExpPowerVoltageBX";
            this.tbExpPowerVoltageBX.ReadOnly = true;
            this.tbExpPowerVoltageBX.Size = new System.Drawing.Size(100, 20);
            this.tbExpPowerVoltageBX.TabIndex = 0;
            // 
            // lblExpPowerVoltage
            // 
            this.lblExpPowerVoltage.AutoSize = true;
            this.lblExpPowerVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpPowerVoltage.Location = new System.Drawing.Point(345, 25);
            this.lblExpPowerVoltage.Name = "lblExpPowerVoltage";
            this.lblExpPowerVoltage.Size = new System.Drawing.Size(50, 13);
            this.lblExpPowerVoltage.TabIndex = 3;
            this.lblExpPowerVoltage.Text = "Voltage";
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.cbLogsEnableLogFile);
            this.tabLogs.Controls.Add(this.rtbLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1571, 830);
            this.tabLogs.TabIndex = 3;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // cbLogsEnableLogFile
            // 
            this.cbLogsEnableLogFile.AutoSize = true;
            this.cbLogsEnableLogFile.Checked = true;
            this.cbLogsEnableLogFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLogsEnableLogFile.Location = new System.Drawing.Point(7, 21);
            this.cbLogsEnableLogFile.Name = "cbLogsEnableLogFile";
            this.cbLogsEnableLogFile.Size = new System.Drawing.Size(99, 17);
            this.cbLogsEnableLogFile.TabIndex = 1;
            this.cbLogsEnableLogFile.Text = "Enable Log File";
            this.cbLogsEnableLogFile.UseVisualStyleBackColor = true;
            // 
            // rtbLogs
            // 
            this.rtbLogs.Location = new System.Drawing.Point(6, 44);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.Size = new System.Drawing.Size(1559, 780);
            this.rtbLogs.TabIndex = 0;
            this.rtbLogs.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabelLog});
            this.statusStrip.Location = new System.Drawing.Point(0, 863);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1584, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabelLog
            // 
            this.statusStripLabelLog.Name = "statusStripLabelLog";
            this.statusStripLabelLog.Size = new System.Drawing.Size(12, 17);
            this.statusStripLabelLog.Text = "-";
            // 
            // btnConnectionClearTCPList
            // 
            this.btnConnectionClearTCPList.Location = new System.Drawing.Point(339, 33);
            this.btnConnectionClearTCPList.Name = "btnConnectionClearTCPList";
            this.btnConnectionClearTCPList.Size = new System.Drawing.Size(219, 23);
            this.btnConnectionClearTCPList.TabIndex = 8;
            this.btnConnectionClearTCPList.Text = "Clear TCP Commandlist";
            this.btnConnectionClearTCPList.UseVisualStyleBackColor = true;
            this.btnConnectionClearTCPList.Click += new System.EventHandler(this.button_click_handler_misc);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 885);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "MASS Groundstation";
            this.tabControlMain.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.tabConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTcpPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUdpPort)).EndInit();
            this.tabAmbient.ResumeLayout(false);
            this.groupAmbientPressure.ResumeLayout(false);
            this.groupAmbientPressure.PerformLayout();
            this.groupAmbientTemperature.ResumeLayout(false);
            this.groupAmbientTemperature.PerformLayout();
            this.tabExperiment.ResumeLayout(false);
            this.groupExpManualInflation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExpLogo)).EndInit();
            this.groupExpPneu.ResumeLayout(false);
            this.groupExpPneu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExpPneu)).EndInit();
            this.groupExpLed.ResumeLayout(false);
            this.groupExpAutoInflation.ResumeLayout(false);
            this.groupExpHDRM.ResumeLayout(false);
            this.groupExpHDRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpHDRMActivationTimeOutside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpHDRMActivationTimeInside)).EndInit();
            this.groupExpPower.ResumeLayout(false);
            this.groupExpPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpPower)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tabControlMain;
        public System.Windows.Forms.TabPage tabConnection;
        public System.Windows.Forms.Label lblTcpPort;
        public System.Windows.Forms.Label lblUdpPort;
        public System.Windows.Forms.Label lblGsIP;
        public System.Windows.Forms.NumericUpDown numTcpPort;
        public System.Windows.Forms.NumericUpDown numUdpPort;
        public System.Windows.Forms.TextBox tbConnectionGsIP;
        public System.Windows.Forms.Label lblConnectionExpIP;
        public System.Windows.Forms.TextBox tbConnectionExpIP;
        public System.Windows.Forms.TabPage tabAmbient;
        public System.Windows.Forms.GroupBox groupAmbientTemperature;
        public System.Windows.Forms.Label lblAmbientTemperatureOutside;
        public System.Windows.Forms.TextBox tbAmbientTemperatureOutside;
        public System.Windows.Forms.Label lblAmbientTemperatureInside;
        public System.Windows.Forms.TextBox tbAmbientTemperatureInside;
        public System.Windows.Forms.GroupBox groupAmbientPressure;
        public System.Windows.Forms.TextBox tbAmbientPressure;
        public System.Windows.Forms.Label lblAmbientPressure;
        public System.Windows.Forms.TabPage tabExperiment;
        public System.Windows.Forms.GroupBox groupExpPower;
        public System.Windows.Forms.PictureBox picExpPower;
        public System.Windows.Forms.Label lblExpPowerPower;
        public System.Windows.Forms.Label lblExpPowerCurrent;
        public System.Windows.Forms.TextBox tbExpPowerPowerEX;
        public System.Windows.Forms.TextBox tbExpPowerPowerBX;
        public System.Windows.Forms.TextBox tbExpPowerCurrentEX;
        public System.Windows.Forms.TextBox tbExpPowerCurrentBX;
        public System.Windows.Forms.Label lblExpPowerEXBat;
        public System.Windows.Forms.Label lblExpPowerBXBat;
        public System.Windows.Forms.TextBox tbExpPowerVoltageEX;
        public System.Windows.Forms.TextBox tbExpPowerVoltageBX;
        public System.Windows.Forms.Label lblExpPowerVoltage;
        public System.Windows.Forms.TabPage tabLogs;
        public System.Windows.Forms.RichTextBox rtbLogs;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel statusStripLabelLog;
        public System.Windows.Forms.GroupBox groupExpHDRM;
        public System.Windows.Forms.NumericUpDown numExpHDRMActivationTimeOutside;
        public System.Windows.Forms.NumericUpDown numExpHDRMActivationTimeInside;
        public System.Windows.Forms.Button btnExpHDRMOutside;
        public System.Windows.Forms.Button btnExpHDRMInside;
        public System.Windows.Forms.Label lblExpHDRMActivationTimeOutside;
        public System.Windows.Forms.Label lblExpHDRMActivationTimeInside;
        public System.Windows.Forms.GroupBox groupExpAutoInflation;
        public System.Windows.Forms.Button btnExpInflationStopOutside;
        public System.Windows.Forms.Button btnExpInflationStopInside;
        public System.Windows.Forms.Button btnExpInflationStartOutside;
        public System.Windows.Forms.Button btnExpInflationStartInside;
        public System.Windows.Forms.GroupBox groupExpLed;
        public System.Windows.Forms.Button btnExpLedOffStructure2;
        public System.Windows.Forms.Button btnExpLedOffStructure1;
        public System.Windows.Forms.Button btnExpLedOnStructure2;
        public System.Windows.Forms.Button btnExpLedOnStructure1;
        public System.Windows.Forms.PictureBox pictureExpLogo;
        public System.Windows.Forms.GroupBox groupExpPneu;
        public System.Windows.Forms.Label labelExpPneuValve4;
        public System.Windows.Forms.Label labelExpPneuValve3;
        public System.Windows.Forms.Label labelExpPneuValve2;
        public System.Windows.Forms.Label labelExpPneuValve1;
        public System.Windows.Forms.TextBox tbExpPneuTankPressure;
        public System.Windows.Forms.TextBox tbExpPneuInsideStructuresPressure;
        public System.Windows.Forms.TextBox tbExpPneuOutsideStructuresPressure;

        public System.Windows.Forms.PictureBox pictureExpPneu;
        public System.Windows.Forms.Label lblExpPneuInsideStructuresPressure;
        public System.Windows.Forms.Label lblExpPneuOutsideStructuresPressure;
        public System.Windows.Forms.Label lblExpPneuTankPressure;
        public System.Windows.Forms.GroupBox groupExpManualInflation;
        public System.Windows.Forms.Button btnExpInflationOffValve4;
        public System.Windows.Forms.Button btnExpInflationOffValve3;
        public System.Windows.Forms.Button btnExpInflationOffValve2;
        public System.Windows.Forms.Button btnExpInflationOffValve1;
        public System.Windows.Forms.Button btnExpInflationOnValve4;
        public System.Windows.Forms.Button btnExpInflationOnValve3;
        public System.Windows.Forms.Button btnExpInflationOnValve2;
        public System.Windows.Forms.Button btnExpInflationOnValve1;
        public System.Windows.Forms.CheckBox cbLogsEnableLogFile;
        private System.Windows.Forms.Button btnExpLiftOff;
        private System.Windows.Forms.Button btnConnectionClearTCPList;
    }
}

