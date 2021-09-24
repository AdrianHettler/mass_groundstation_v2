
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.btnConnectionClearTCPList = new System.Windows.Forms.Button();
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
            this.trackbarScalingAmbPressure = new System.Windows.Forms.TrackBar();
            this.chartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbAmbientPressure = new System.Windows.Forms.TextBox();
            this.lblAmbientPressure = new System.Windows.Forms.Label();
            this.groupAmbientTemperature = new System.Windows.Forms.GroupBox();
            this.trackbarScalingAmbTemperature = new System.Windows.Forms.TrackBar();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblAmbientTemperatureOutside = new System.Windows.Forms.Label();
            this.tbAmbientTemperatureOutside = new System.Windows.Forms.TextBox();
            this.lblAmbientTemperatureInside = new System.Windows.Forms.Label();
            this.tbAmbientTemperatureInside = new System.Windows.Forms.TextBox();
            this.tabExperiment = new System.Windows.Forms.TabPage();
            this.btnExpLiftOff = new System.Windows.Forms.Button();
            this.groupExpManualInflation = new System.Windows.Forms.GroupBox();
            this.cbExpManualInflateLock = new System.Windows.Forms.CheckBox();
            this.numPulseV3Multi = new System.Windows.Forms.NumericUpDown();
            this.numPulseV1Multi = new System.Windows.Forms.NumericUpDown();
            this.numV3PulseTime = new System.Windows.Forms.NumericUpDown();
            this.numV1PulseTime = new System.Windows.Forms.NumericUpDown();
            this.btnExpValve3Pulse = new System.Windows.Forms.Button();
            this.btnExpValve1Pulse = new System.Windows.Forms.Button();
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
            this.cbExpUVLock = new System.Windows.Forms.CheckBox();
            this.btnExpLedOffStructure2 = new System.Windows.Forms.Button();
            this.btnExpLedOffStructure1 = new System.Windows.Forms.Button();
            this.btnExpLedOnStructure2 = new System.Windows.Forms.Button();
            this.btnExpLedOnStructure1 = new System.Windows.Forms.Button();
            this.groupExpAutoInflation = new System.Windows.Forms.GroupBox();
            this.cbExpAutoInflateLock = new System.Windows.Forms.CheckBox();
            this.btnExpInflationStopOutside = new System.Windows.Forms.Button();
            this.btnExpInflationStopInside = new System.Windows.Forms.Button();
            this.btnExpInflationStartOutside = new System.Windows.Forms.Button();
            this.btnExpInflationStartInside = new System.Windows.Forms.Button();
            this.groupExpHDRM = new System.Windows.Forms.GroupBox();
            this.cbExpHdrmLock = new System.Windows.Forms.CheckBox();
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
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.tbCameraTimeRemainOutside = new System.Windows.Forms.TextBox();
            this.tbCameraTimeRemainInside = new System.Windows.Forms.TextBox();
            this.btnCamStartRecOutside = new System.Windows.Forms.Button();
            this.btnCamStopRecOutside = new System.Windows.Forms.Button();
            this.btnCamStopRecInside = new System.Windows.Forms.Button();
            this.btnCamStartRecInside = new System.Windows.Forms.Button();
            this.btnCamStopLive = new System.Windows.Forms.Button();
            this.btnCamStartLive = new System.Windows.Forms.Button();
            this.btnCamOutside = new System.Windows.Forms.Button();
            this.btnCamInside = new System.Windows.Forms.Button();
            this.groupCameraLive = new System.Windows.Forms.GroupBox();
            this.pictureBoxLive = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabelLog = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripAlignment = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripTCPDescription = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripTCP = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripPingDescription = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripPing = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripFlightTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStopWatch = new System.Windows.Forms.Timer(this.components);
            this.timerConnectionTest = new System.Windows.Forms.Timer(this.components);
            this.numCamLiveInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTcpPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUdpPort)).BeginInit();
            this.tabAmbient.SuspendLayout();
            this.groupAmbientPressure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarScalingAmbPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).BeginInit();
            this.groupAmbientTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarScalingAmbTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.tabExperiment.SuspendLayout();
            this.groupExpManualInflation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPulseV3Multi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPulseV1Multi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numV3PulseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numV1PulseTime)).BeginInit();
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
            this.tabCamera.SuspendLayout();
            this.groupCameraLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCamLiveInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabConnection);
            this.tabControlMain.Controls.Add(this.tabAmbient);
            this.tabControlMain.Controls.Add(this.tabExperiment);
            this.tabControlMain.Controls.Add(this.tabLogs);
            this.tabControlMain.Controls.Add(this.tabCamera);
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
            this.tbConnectionGsIP.Text = "192.168.2.109";
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
            this.groupAmbientPressure.Controls.Add(this.trackbarScalingAmbPressure);
            this.groupAmbientPressure.Controls.Add(this.chartPressure);
            this.groupAmbientPressure.Controls.Add(this.tbAmbientPressure);
            this.groupAmbientPressure.Controls.Add(this.lblAmbientPressure);
            this.groupAmbientPressure.Location = new System.Drawing.Point(790, 6);
            this.groupAmbientPressure.Name = "groupAmbientPressure";
            this.groupAmbientPressure.Size = new System.Drawing.Size(775, 818);
            this.groupAmbientPressure.TabIndex = 1;
            this.groupAmbientPressure.TabStop = false;
            this.groupAmbientPressure.Text = "Pressure";
            // 
            // trackbarScalingAmbPressure
            // 
            this.trackbarScalingAmbPressure.AccessibleName = "";
            this.trackbarScalingAmbPressure.Location = new System.Drawing.Point(279, 746);
            this.trackbarScalingAmbPressure.Maximum = 100;
            this.trackbarScalingAmbPressure.Minimum = 1;
            this.trackbarScalingAmbPressure.Name = "trackbarScalingAmbPressure";
            this.trackbarScalingAmbPressure.Size = new System.Drawing.Size(250, 45);
            this.trackbarScalingAmbPressure.TabIndex = 7;
            this.trackbarScalingAmbPressure.Value = 30;
            this.trackbarScalingAmbPressure.Scroll += new System.EventHandler(this.trackbarScalingAmbPressure_Scroll);
            // 
            // chartPressure
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPressure.ChartAreas.Add(chartArea1);
            this.chartPressure.Location = new System.Drawing.Point(6, 63);
            this.chartPressure.Name = "chartPressure";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "pressure";
            this.chartPressure.Series.Add(series1);
            this.chartPressure.Size = new System.Drawing.Size(763, 696);
            this.chartPressure.TabIndex = 2;
            this.chartPressure.Text = "chart2";
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
            this.groupAmbientTemperature.Controls.Add(this.trackbarScalingAmbTemperature);
            this.groupAmbientTemperature.Controls.Add(this.chartTemperature);
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
            // trackbarScalingAmbTemperature
            // 
            this.trackbarScalingAmbTemperature.AccessibleName = "";
            this.trackbarScalingAmbTemperature.Location = new System.Drawing.Point(279, 746);
            this.trackbarScalingAmbTemperature.Maximum = 100;
            this.trackbarScalingAmbTemperature.Minimum = 1;
            this.trackbarScalingAmbTemperature.Name = "trackbarScalingAmbTemperature";
            this.trackbarScalingAmbTemperature.Size = new System.Drawing.Size(250, 45);
            this.trackbarScalingAmbTemperature.TabIndex = 6;
            this.trackbarScalingAmbTemperature.Value = 30;
            this.trackbarScalingAmbTemperature.Scroll += new System.EventHandler(this.trackbarScalingAmbTemperature_Scroll);
            // 
            // chartTemperature
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea2);
            this.chartTemperature.Location = new System.Drawing.Point(6, 63);
            this.chartTemperature.Name = "chartTemperature";
            this.chartTemperature.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "temperatureInside";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "temperatureOutside";
            this.chartTemperature.Series.Add(series2);
            this.chartTemperature.Series.Add(series3);
            this.chartTemperature.Size = new System.Drawing.Size(763, 696);
            this.chartTemperature.TabIndex = 5;
            this.chartTemperature.Text = "chart1";
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
            this.groupExpManualInflation.Controls.Add(this.cbExpManualInflateLock);
            this.groupExpManualInflation.Controls.Add(this.numPulseV3Multi);
            this.groupExpManualInflation.Controls.Add(this.numPulseV1Multi);
            this.groupExpManualInflation.Controls.Add(this.numV3PulseTime);
            this.groupExpManualInflation.Controls.Add(this.numV1PulseTime);
            this.groupExpManualInflation.Controls.Add(this.btnExpValve3Pulse);
            this.groupExpManualInflation.Controls.Add(this.btnExpValve1Pulse);
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
            // cbExpManualInflateLock
            // 
            this.cbExpManualInflateLock.AutoSize = true;
            this.cbExpManualInflateLock.Checked = true;
            this.cbExpManualInflateLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpManualInflateLock.Location = new System.Drawing.Point(6, 19);
            this.cbExpManualInflateLock.Name = "cbExpManualInflateLock";
            this.cbExpManualInflateLock.Size = new System.Drawing.Size(50, 17);
            this.cbExpManualInflateLock.TabIndex = 19;
            this.cbExpManualInflateLock.Text = "Lock";
            this.cbExpManualInflateLock.UseVisualStyleBackColor = true;
            this.cbExpManualInflateLock.CheckedChanged += new System.EventHandler(this.cbExpManualInflateLock_CheckedChanged);
            // 
            // numPulseV3Multi
            // 
            this.numPulseV3Multi.Location = new System.Drawing.Point(631, 89);
            this.numPulseV3Multi.Name = "numPulseV3Multi";
            this.numPulseV3Multi.Size = new System.Drawing.Size(63, 20);
            this.numPulseV3Multi.TabIndex = 18;
            this.numPulseV3Multi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numPulseV1Multi
            // 
            this.numPulseV1Multi.Location = new System.Drawing.Point(631, 31);
            this.numPulseV1Multi.Name = "numPulseV1Multi";
            this.numPulseV1Multi.Size = new System.Drawing.Size(63, 20);
            this.numPulseV1Multi.TabIndex = 17;
            this.numPulseV1Multi.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numV3PulseTime
            // 
            this.numV3PulseTime.Location = new System.Drawing.Point(562, 89);
            this.numV3PulseTime.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numV3PulseTime.Name = "numV3PulseTime";
            this.numV3PulseTime.Size = new System.Drawing.Size(63, 20);
            this.numV3PulseTime.TabIndex = 16;
            this.numV3PulseTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numV1PulseTime
            // 
            this.numV1PulseTime.Location = new System.Drawing.Point(562, 31);
            this.numV1PulseTime.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numV1PulseTime.Name = "numV1PulseTime";
            this.numV1PulseTime.Size = new System.Drawing.Size(63, 20);
            this.numV1PulseTime.TabIndex = 15;
            this.numV1PulseTime.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnExpValve3Pulse
            // 
            this.btnExpValve3Pulse.Enabled = false;
            this.btnExpValve3Pulse.Location = new System.Drawing.Point(400, 86);
            this.btnExpValve3Pulse.Name = "btnExpValve3Pulse";
            this.btnExpValve3Pulse.Size = new System.Drawing.Size(156, 23);
            this.btnExpValve3Pulse.TabIndex = 14;
            this.btnExpValve3Pulse.Text = "Valve 3 - PULSE";
            this.btnExpValve3Pulse.UseVisualStyleBackColor = true;
            this.btnExpValve3Pulse.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpValve1Pulse
            // 
            this.btnExpValve1Pulse.Enabled = false;
            this.btnExpValve1Pulse.Location = new System.Drawing.Point(400, 28);
            this.btnExpValve1Pulse.Name = "btnExpValve1Pulse";
            this.btnExpValve1Pulse.Size = new System.Drawing.Size(156, 23);
            this.btnExpValve1Pulse.TabIndex = 13;
            this.btnExpValve1Pulse.Text = "Valve 1 - PULSE";
            this.btnExpValve1Pulse.UseVisualStyleBackColor = true;
            this.btnExpValve1Pulse.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOffValve4
            // 
            this.btnExpInflationOffValve4.Enabled = false;
            this.btnExpInflationOffValve4.Location = new System.Drawing.Point(245, 115);
            this.btnExpInflationOffValve4.Name = "btnExpInflationOffValve4";
            this.btnExpInflationOffValve4.Size = new System.Drawing.Size(149, 23);
            this.btnExpInflationOffValve4.TabIndex = 12;
            this.btnExpInflationOffValve4.Text = "Valve 4 - OFF";
            this.btnExpInflationOffValve4.UseVisualStyleBackColor = true;
            this.btnExpInflationOffValve4.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOffValve3
            // 
            this.btnExpInflationOffValve3.Enabled = false;
            this.btnExpInflationOffValve3.Location = new System.Drawing.Point(245, 86);
            this.btnExpInflationOffValve3.Name = "btnExpInflationOffValve3";
            this.btnExpInflationOffValve3.Size = new System.Drawing.Size(149, 23);
            this.btnExpInflationOffValve3.TabIndex = 11;
            this.btnExpInflationOffValve3.Text = "Valve 3 - OFF";
            this.btnExpInflationOffValve3.UseVisualStyleBackColor = true;
            this.btnExpInflationOffValve3.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOffValve2
            // 
            this.btnExpInflationOffValve2.Enabled = false;
            this.btnExpInflationOffValve2.Location = new System.Drawing.Point(245, 57);
            this.btnExpInflationOffValve2.Name = "btnExpInflationOffValve2";
            this.btnExpInflationOffValve2.Size = new System.Drawing.Size(149, 23);
            this.btnExpInflationOffValve2.TabIndex = 10;
            this.btnExpInflationOffValve2.Text = "Valve 2 - OFF";
            this.btnExpInflationOffValve2.UseVisualStyleBackColor = true;
            this.btnExpInflationOffValve2.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOffValve1
            // 
            this.btnExpInflationOffValve1.Enabled = false;
            this.btnExpInflationOffValve1.Location = new System.Drawing.Point(245, 28);
            this.btnExpInflationOffValve1.Name = "btnExpInflationOffValve1";
            this.btnExpInflationOffValve1.Size = new System.Drawing.Size(149, 23);
            this.btnExpInflationOffValve1.TabIndex = 9;
            this.btnExpInflationOffValve1.Text = "Valve 1 - OFF";
            this.btnExpInflationOffValve1.UseVisualStyleBackColor = true;
            this.btnExpInflationOffValve1.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOnValve4
            // 
            this.btnExpInflationOnValve4.Enabled = false;
            this.btnExpInflationOnValve4.Location = new System.Drawing.Point(83, 115);
            this.btnExpInflationOnValve4.Name = "btnExpInflationOnValve4";
            this.btnExpInflationOnValve4.Size = new System.Drawing.Size(156, 23);
            this.btnExpInflationOnValve4.TabIndex = 8;
            this.btnExpInflationOnValve4.Text = "Valve 4 - ON";
            this.btnExpInflationOnValve4.UseVisualStyleBackColor = true;
            this.btnExpInflationOnValve4.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOnValve3
            // 
            this.btnExpInflationOnValve3.Enabled = false;
            this.btnExpInflationOnValve3.Location = new System.Drawing.Point(83, 86);
            this.btnExpInflationOnValve3.Name = "btnExpInflationOnValve3";
            this.btnExpInflationOnValve3.Size = new System.Drawing.Size(156, 23);
            this.btnExpInflationOnValve3.TabIndex = 7;
            this.btnExpInflationOnValve3.Text = "Valve 3 - ON";
            this.btnExpInflationOnValve3.UseVisualStyleBackColor = true;
            this.btnExpInflationOnValve3.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOnValve2
            // 
            this.btnExpInflationOnValve2.Enabled = false;
            this.btnExpInflationOnValve2.Location = new System.Drawing.Point(83, 57);
            this.btnExpInflationOnValve2.Name = "btnExpInflationOnValve2";
            this.btnExpInflationOnValve2.Size = new System.Drawing.Size(156, 23);
            this.btnExpInflationOnValve2.TabIndex = 6;
            this.btnExpInflationOnValve2.Text = "Valve 2 - ON";
            this.btnExpInflationOnValve2.UseVisualStyleBackColor = true;
            this.btnExpInflationOnValve2.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnExpInflationOnValve1
            // 
            this.btnExpInflationOnValve1.Enabled = false;
            this.btnExpInflationOnValve1.Location = new System.Drawing.Point(83, 28);
            this.btnExpInflationOnValve1.Name = "btnExpInflationOnValve1";
            this.btnExpInflationOnValve1.Size = new System.Drawing.Size(156, 23);
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
            this.groupExpLed.Controls.Add(this.cbExpUVLock);
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
            // cbExpUVLock
            // 
            this.cbExpUVLock.AutoSize = true;
            this.cbExpUVLock.Checked = true;
            this.cbExpUVLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpUVLock.Location = new System.Drawing.Point(6, 19);
            this.cbExpUVLock.Name = "cbExpUVLock";
            this.cbExpUVLock.Size = new System.Drawing.Size(50, 17);
            this.cbExpUVLock.TabIndex = 20;
            this.cbExpUVLock.Text = "Lock";
            this.cbExpUVLock.UseVisualStyleBackColor = true;
            this.cbExpUVLock.CheckedChanged += new System.EventHandler(this.cbExpUVLock_CheckedChanged);
            // 
            // btnExpLedOffStructure2
            // 
            this.btnExpLedOffStructure2.Enabled = false;
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
            this.btnExpLedOffStructure1.Enabled = false;
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
            this.btnExpLedOnStructure2.Enabled = false;
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
            this.btnExpLedOnStructure1.Enabled = false;
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
            this.groupExpAutoInflation.Controls.Add(this.cbExpAutoInflateLock);
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
            // cbExpAutoInflateLock
            // 
            this.cbExpAutoInflateLock.AutoSize = true;
            this.cbExpAutoInflateLock.Checked = true;
            this.cbExpAutoInflateLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpAutoInflateLock.Location = new System.Drawing.Point(6, 19);
            this.cbExpAutoInflateLock.Name = "cbExpAutoInflateLock";
            this.cbExpAutoInflateLock.Size = new System.Drawing.Size(50, 17);
            this.cbExpAutoInflateLock.TabIndex = 9;
            this.cbExpAutoInflateLock.Text = "Lock";
            this.cbExpAutoInflateLock.UseVisualStyleBackColor = true;
            this.cbExpAutoInflateLock.CheckedChanged += new System.EventHandler(this.cbExpAutoInflateLock_CheckedChanged);
            // 
            // btnExpInflationStopOutside
            // 
            this.btnExpInflationStopOutside.Enabled = false;
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
            this.btnExpInflationStopInside.Enabled = false;
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
            this.btnExpInflationStartOutside.Enabled = false;
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
            this.btnExpInflationStartInside.Enabled = false;
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
            this.groupExpHDRM.Controls.Add(this.cbExpHdrmLock);
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
            // cbExpHdrmLock
            // 
            this.cbExpHdrmLock.AutoSize = true;
            this.cbExpHdrmLock.Checked = true;
            this.cbExpHdrmLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpHdrmLock.Location = new System.Drawing.Point(6, 19);
            this.cbExpHdrmLock.Name = "cbExpHdrmLock";
            this.cbExpHdrmLock.Size = new System.Drawing.Size(50, 17);
            this.cbExpHdrmLock.TabIndex = 8;
            this.cbExpHdrmLock.Text = "Lock";
            this.cbExpHdrmLock.UseVisualStyleBackColor = true;
            this.cbExpHdrmLock.CheckedChanged += new System.EventHandler(this.cbExpHdrmLock_CheckedChanged);
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
            this.btnExpHDRMOutside.Enabled = false;
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
            this.btnExpHDRMInside.Enabled = false;
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
            // tabCamera
            // 
            this.tabCamera.Controls.Add(this.label1);
            this.tabCamera.Controls.Add(this.numCamLiveInterval);
            this.tabCamera.Controls.Add(this.tbCameraTimeRemainOutside);
            this.tabCamera.Controls.Add(this.tbCameraTimeRemainInside);
            this.tabCamera.Controls.Add(this.btnCamStartRecOutside);
            this.tabCamera.Controls.Add(this.btnCamStopRecOutside);
            this.tabCamera.Controls.Add(this.btnCamStopRecInside);
            this.tabCamera.Controls.Add(this.btnCamStartRecInside);
            this.tabCamera.Controls.Add(this.btnCamStopLive);
            this.tabCamera.Controls.Add(this.btnCamStartLive);
            this.tabCamera.Controls.Add(this.btnCamOutside);
            this.tabCamera.Controls.Add(this.btnCamInside);
            this.tabCamera.Controls.Add(this.groupCameraLive);
            this.tabCamera.Location = new System.Drawing.Point(4, 22);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamera.Size = new System.Drawing.Size(1571, 830);
            this.tabCamera.TabIndex = 4;
            this.tabCamera.Text = "Camera";
            this.tabCamera.UseVisualStyleBackColor = true;
            // 
            // tbCameraTimeRemainOutside
            // 
            this.tbCameraTimeRemainOutside.Enabled = false;
            this.tbCameraTimeRemainOutside.Location = new System.Drawing.Point(892, 54);
            this.tbCameraTimeRemainOutside.Name = "tbCameraTimeRemainOutside";
            this.tbCameraTimeRemainOutside.Size = new System.Drawing.Size(100, 20);
            this.tbCameraTimeRemainOutside.TabIndex = 10;
            // 
            // tbCameraTimeRemainInside
            // 
            this.tbCameraTimeRemainInside.Enabled = false;
            this.tbCameraTimeRemainInside.Location = new System.Drawing.Point(892, 25);
            this.tbCameraTimeRemainInside.Name = "tbCameraTimeRemainInside";
            this.tbCameraTimeRemainInside.Size = new System.Drawing.Size(100, 20);
            this.tbCameraTimeRemainInside.TabIndex = 9;
            // 
            // btnCamStartRecOutside
            // 
            this.btnCamStartRecOutside.Location = new System.Drawing.Point(588, 52);
            this.btnCamStartRecOutside.Name = "btnCamStartRecOutside";
            this.btnCamStartRecOutside.Size = new System.Drawing.Size(146, 23);
            this.btnCamStartRecOutside.TabIndex = 8;
            this.btnCamStartRecOutside.Text = "Start Recording Outside";
            this.btnCamStartRecOutside.UseVisualStyleBackColor = true;
            this.btnCamStartRecOutside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnCamStopRecOutside
            // 
            this.btnCamStopRecOutside.Location = new System.Drawing.Point(740, 52);
            this.btnCamStopRecOutside.Name = "btnCamStopRecOutside";
            this.btnCamStopRecOutside.Size = new System.Drawing.Size(146, 23);
            this.btnCamStopRecOutside.TabIndex = 7;
            this.btnCamStopRecOutside.Text = "Stop Recording Outside";
            this.btnCamStopRecOutside.UseVisualStyleBackColor = true;
            this.btnCamStopRecOutside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnCamStopRecInside
            // 
            this.btnCamStopRecInside.Location = new System.Drawing.Point(740, 23);
            this.btnCamStopRecInside.Name = "btnCamStopRecInside";
            this.btnCamStopRecInside.Size = new System.Drawing.Size(146, 23);
            this.btnCamStopRecInside.TabIndex = 6;
            this.btnCamStopRecInside.Text = "Stop Recording Inside";
            this.btnCamStopRecInside.UseVisualStyleBackColor = true;
            this.btnCamStopRecInside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnCamStartRecInside
            // 
            this.btnCamStartRecInside.Location = new System.Drawing.Point(588, 23);
            this.btnCamStartRecInside.Name = "btnCamStartRecInside";
            this.btnCamStartRecInside.Size = new System.Drawing.Size(146, 23);
            this.btnCamStartRecInside.TabIndex = 5;
            this.btnCamStartRecInside.Text = "Start Recording Inside";
            this.btnCamStartRecInside.UseVisualStyleBackColor = true;
            this.btnCamStartRecInside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnCamStopLive
            // 
            this.btnCamStopLive.Location = new System.Drawing.Point(19, 53);
            this.btnCamStopLive.Name = "btnCamStopLive";
            this.btnCamStopLive.Size = new System.Drawing.Size(119, 23);
            this.btnCamStopLive.TabIndex = 4;
            this.btnCamStopLive.Text = "Stop Live View";
            this.btnCamStopLive.UseVisualStyleBackColor = true;
            this.btnCamStopLive.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnCamStartLive
            // 
            this.btnCamStartLive.Location = new System.Drawing.Point(19, 24);
            this.btnCamStartLive.Name = "btnCamStartLive";
            this.btnCamStartLive.Size = new System.Drawing.Size(119, 23);
            this.btnCamStartLive.TabIndex = 3;
            this.btnCamStartLive.Text = "Start Live View";
            this.btnCamStartLive.UseVisualStyleBackColor = true;
            this.btnCamStartLive.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnCamOutside
            // 
            this.btnCamOutside.Location = new System.Drawing.Point(149, 53);
            this.btnCamOutside.Name = "btnCamOutside";
            this.btnCamOutside.Size = new System.Drawing.Size(151, 23);
            this.btnCamOutside.TabIndex = 2;
            this.btnCamOutside.Text = "Switch Live View Outside";
            this.btnCamOutside.UseVisualStyleBackColor = true;
            this.btnCamOutside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // btnCamInside
            // 
            this.btnCamInside.Location = new System.Drawing.Point(149, 24);
            this.btnCamInside.Name = "btnCamInside";
            this.btnCamInside.Size = new System.Drawing.Size(151, 23);
            this.btnCamInside.TabIndex = 1;
            this.btnCamInside.Text = "Switch Live View Inside";
            this.btnCamInside.UseVisualStyleBackColor = true;
            this.btnCamInside.Click += new System.EventHandler(this.button_click_handler_commands);
            // 
            // groupCameraLive
            // 
            this.groupCameraLive.Controls.Add(this.pictureBoxLive);
            this.groupCameraLive.Location = new System.Drawing.Point(6, 96);
            this.groupCameraLive.Name = "groupCameraLive";
            this.groupCameraLive.Size = new System.Drawing.Size(1559, 728);
            this.groupCameraLive.TabIndex = 0;
            this.groupCameraLive.TabStop = false;
            this.groupCameraLive.Text = "Live View";
            // 
            // pictureBoxLive
            // 
            this.pictureBoxLive.Location = new System.Drawing.Point(143, 81);
            this.pictureBoxLive.Name = "pictureBoxLive";
            this.pictureBoxLive.Size = new System.Drawing.Size(1289, 585);
            this.pictureBoxLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLive.TabIndex = 0;
            this.pictureBoxLive.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabelLog,
            this.statusStripAlignment,
            this.statusStripTCPDescription,
            this.statusStripTCP,
            this.statusStripPingDescription,
            this.statusStripPing,
            this.statusStripFlightTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 860);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip.Size = new System.Drawing.Size(1579, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStripLabelLog
            // 
            this.statusStripLabelLog.Name = "statusStripLabelLog";
            this.statusStripLabelLog.Size = new System.Drawing.Size(12, 17);
            this.statusStripLabelLog.Text = "-";
            // 
            // statusStripAlignment
            // 
            this.statusStripAlignment.Name = "statusStripAlignment";
            this.statusStripAlignment.Size = new System.Drawing.Size(1137, 17);
            this.statusStripAlignment.Spring = true;
            // 
            // statusStripTCPDescription
            // 
            this.statusStripTCPDescription.Name = "statusStripTCPDescription";
            this.statusStripTCPDescription.Size = new System.Drawing.Size(30, 17);
            this.statusStripTCPDescription.Text = "TCP:";
            // 
            // statusStripTCP
            // 
            this.statusStripTCP.ForeColor = System.Drawing.Color.Red;
            this.statusStripTCP.Name = "statusStripTCP";
            this.statusStripTCP.Size = new System.Drawing.Size(86, 17);
            this.statusStripTCP.Text = "Not connected";
            // 
            // statusStripPingDescription
            // 
            this.statusStripPingDescription.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
            this.statusStripPingDescription.Name = "statusStripPingDescription";
            this.statusStripPingDescription.Size = new System.Drawing.Size(34, 17);
            this.statusStripPingDescription.Text = "Ping:";
            // 
            // statusStripPing
            // 
            this.statusStripPing.ForeColor = System.Drawing.Color.Red;
            this.statusStripPing.Margin = new System.Windows.Forms.Padding(0, 3, 30, 2);
            this.statusStripPing.Name = "statusStripPing";
            this.statusStripPing.Size = new System.Drawing.Size(86, 17);
            this.statusStripPing.Text = "Not connected";
            // 
            // statusStripFlightTime
            // 
            this.statusStripFlightTime.Name = "statusStripFlightTime";
            this.statusStripFlightTime.Size = new System.Drawing.Size(119, 17);
            this.statusStripFlightTime.Text = "Flight Time - 00:00:00";
            // 
            // timerStopWatch
            // 
            this.timerStopWatch.Interval = 1000;
            this.timerStopWatch.Tick += new System.EventHandler(this.timerStopWatch_Tick);
            // 
            // timerConnectionTest
            // 
            this.timerConnectionTest.Enabled = true;
            this.timerConnectionTest.Interval = 1000;
            this.timerConnectionTest.Tick += new System.EventHandler(this.timerConnectionTest_Tick);
            // 
            // numCamLiveInterval
            // 
            this.numCamLiveInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCamLiveInterval.Location = new System.Drawing.Point(353, 39);
            this.numCamLiveInterval.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numCamLiveInterval.Name = "numCamLiveInterval";
            this.numCamLiveInterval.Size = new System.Drawing.Size(68, 20);
            this.numCamLiveInterval.TabIndex = 11;
            this.numCamLiveInterval.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numCamLiveInterval.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Frame Interval";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 882);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackbarScalingAmbPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).EndInit();
            this.groupAmbientTemperature.ResumeLayout(false);
            this.groupAmbientTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarScalingAmbTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.tabExperiment.ResumeLayout(false);
            this.groupExpManualInflation.ResumeLayout(false);
            this.groupExpManualInflation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPulseV3Multi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPulseV1Multi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numV3PulseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numV1PulseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExpLogo)).EndInit();
            this.groupExpPneu.ResumeLayout(false);
            this.groupExpPneu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExpPneu)).EndInit();
            this.groupExpLed.ResumeLayout(false);
            this.groupExpLed.PerformLayout();
            this.groupExpAutoInflation.ResumeLayout(false);
            this.groupExpAutoInflation.PerformLayout();
            this.groupExpHDRM.ResumeLayout(false);
            this.groupExpHDRM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExpHDRMActivationTimeOutside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExpHDRMActivationTimeInside)).EndInit();
            this.groupExpPower.ResumeLayout(false);
            this.groupExpPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExpPower)).EndInit();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.tabCamera.ResumeLayout(false);
            this.tabCamera.PerformLayout();
            this.groupCameraLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLive)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCamLiveInterval)).EndInit();
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
        public System.Windows.Forms.Button btnExpLiftOff;
        public System.Windows.Forms.Button btnConnectionClearTCPList;
        public System.Windows.Forms.ToolStripStatusLabel statusStripAlignment;
        public System.Windows.Forms.ToolStripStatusLabel statusStripFlightTime;
        public System.Windows.Forms.Timer timerStopWatch;
        public System.Windows.Forms.ToolStripStatusLabel statusStripPing;
        public System.Windows.Forms.ToolStripStatusLabel statusStripTCPDescription;
        public System.Windows.Forms.ToolStripStatusLabel statusStripTCP;
        public System.Windows.Forms.ToolStripStatusLabel statusStripPingDescription;
        public System.Windows.Forms.Timer timerConnectionTest;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartPressure;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.TrackBar trackbarScalingAmbTemperature;
        private System.Windows.Forms.TrackBar trackbarScalingAmbPressure;
        private System.Windows.Forms.TabPage tabCamera;
        private System.Windows.Forms.GroupBox groupCameraLive;
        public System.Windows.Forms.PictureBox pictureBoxLive;
        private System.Windows.Forms.Button btnCamOutside;
        private System.Windows.Forms.Button btnCamInside;
        private System.Windows.Forms.Button btnCamStopLive;
        private System.Windows.Forms.Button btnCamStartLive;
        public System.Windows.Forms.NumericUpDown numV3PulseTime;
        public System.Windows.Forms.NumericUpDown numV1PulseTime;
        public System.Windows.Forms.Button btnExpValve3Pulse;
        public System.Windows.Forms.Button btnExpValve1Pulse;
        public System.Windows.Forms.NumericUpDown numPulseV3Multi;
        public System.Windows.Forms.NumericUpDown numPulseV1Multi;
        public System.Windows.Forms.Button btnCamStartRecOutside;
        public System.Windows.Forms.Button btnCamStopRecOutside;
        public System.Windows.Forms.Button btnCamStopRecInside;
        public System.Windows.Forms.Button btnCamStartRecInside;
        public System.Windows.Forms.TextBox tbCameraTimeRemainOutside;
        public System.Windows.Forms.TextBox tbCameraTimeRemainInside;
        private System.Windows.Forms.CheckBox cbExpHdrmLock;
        private System.Windows.Forms.CheckBox cbExpAutoInflateLock;
        private System.Windows.Forms.CheckBox cbExpManualInflateLock;
        private System.Windows.Forms.CheckBox cbExpUVLock;
        private System.Windows.Forms.NumericUpDown numCamLiveInterval;
        private System.Windows.Forms.Label label1;
    }
}

