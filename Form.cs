using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using Helper = mass_groundstation_v2.helper.helper;

namespace mass_groundstation_v2
{
    enum device_id : byte
    {
        led_1 = 0,
        led_2 = 1,
        pin_puller_1 = 2,
        pin_puller_2 = 3,
        valve_1 = 4,
        valve_2 = 5,
        valve_3 = 6,
        valve_4 = 7,
        structures_inside = 8,
        structures_outside = 9,
        camera_inside = 10,
        camera_outside = 11
    }

    public partial class Form : System.Windows.Forms.Form
    {
        private network.udp udp_client;
        private network.tcp tcp_client;
        public helper.direct_bitmap frame_bmp = new helper.direct_bitmap(800, 612);
        public DateTime stop_watch_start_time;
        public bool lift_off = false;


        private void init_charts() //init ambient condition charts
        {
            chartTemperature.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            chartTemperature.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTimeOffset;
            chartTemperature.ChartAreas[0].AxisX.Minimum = 0;
            chartTemperature.ChartAreas[0].AxisX.Maximum = 0.417;
            chartTemperature.ChartAreas[0].AxisY.Minimum = -70;
            chartTemperature.ChartAreas[0].AxisY.Maximum = 40;
            chartTemperature.ChartAreas[0].AxisY.Interval = 5;
            chartTemperature.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartTemperature.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartTemperature.ChartAreas[0].AxisX.Title = "Time in [h]";
            chartTemperature.ChartAreas[0].AxisY.Title = "Temperature in [°C]";
            chartTemperature.Series[0].Color = Color.Red;
            chartTemperature.Series[1].Color = Color.Blue;

            chartPressure.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            chartPressure.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTimeOffset;
            chartPressure.ChartAreas[0].AxisX.Minimum = 0;
            chartPressure.ChartAreas[0].AxisX.Maximum = 0.417;
            chartPressure.ChartAreas[0].AxisY.Minimum = 0;
            chartPressure.ChartAreas[0].AxisY.Maximum = 1200;
            chartPressure.ChartAreas[0].AxisY.Interval = 100;
            chartPressure.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            chartPressure.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartPressure.ChartAreas[0].AxisX.Title = "Time in [h]";
            chartPressure.ChartAreas[0].AxisY.Title = "Pressure in [hPa]";
        }

        public Form()
        {
            InitializeComponent();
            init_charts();

            udp_client = new network.udp(tbConnectionExpIP.Text,(int)numUdpPort.Value); //start udp thread and init udp
            tcp_client = new network.tcp(); //start tcp thread
            tcp_client.init(tbConnectionExpIP.Text, (int)numTcpPort.Value); //init tcp_thread
        }

        private void button_click_handler_misc(object sender, EventArgs e)//global button click handler
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnExpLiftOff": //Lift Off Button
                    Helper.print_log("Lift Off!");
                    stop_watch_start_time = DateTime.Now;
                    timerStopWatch.Start();
                    lift_off = true;
                    break;

                case "btnConnectionClearTCPList": //clear tcp command list
                    tcp_client.tcp_command_list.Clear();
                    break;
                default:
                    break;
            }
            
        }
        private void button_click_handler_commands(object sender, EventArgs e)//global button click handler
        {
            byte[] data;
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnExpHDRMInside": //HDRM
                    data = new byte[] { (byte)device_id.pin_puller_1,(byte)numExpHDRMActivationTimeInside.Value }; //device_id,activation_time
                   tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_release_structures, data, network.tcp_message_id.ok, "Exp. Release Structure Command SUCCESS - Inside Structures", "Exp. Release Structure Command FAIL - Inside Structures"));            
                    break;
                case "btnExpHDRMOutside":
                    data = new byte[] { (byte)device_id.pin_puller_2, (byte)numExpHDRMActivationTimeOutside.Value }; //device_id,activation_time
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_release_structures, data, network.tcp_message_id.ok, "Exp. Release Structure Command SUCCESS - Outside Structures", "Exp. Release Structure Command FAIL - Outside Structures"));
                    break;

                case "btnExpInflationStartInside": //Automated Inflation
                    data = new byte[] { (byte)device_id.structures_inside }; //device_id,inflation time
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_start_inflation, data, network.tcp_message_id.ok, "Exp. Start Inflation SUCCESS - Inside Structures", "Exp. Start Inflation FAIL - Inside Structures"));
                    break;
                case "btnExpInflationStopInside":
                    data = new byte[] { (byte)device_id.structures_inside }; //device_id,inflation time
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_stop_inflation, data, network.tcp_message_id.ok, "Exp. Stop Inflation SUCCESS - Inside Structures", "Exp. Stop Inflation FAIL - Inside Structures"));
                    break;
                case "btnExpInflationStartOutside": //Automated Inflation
                    data = new byte[] { (byte)device_id.structures_outside }; //device_id,inflation time
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_start_inflation, data, network.tcp_message_id.ok, "Exp. Start Inflation SUCCESS - Outside Structures", "Exp. Start Inflation FAIL - Outside Structures"));
                    break;
                case "btnExpInflationStopOutside":
                    data = new byte[] { (byte)device_id.structures_outside }; //device_id,inflation time
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_stop_inflation, data, network.tcp_message_id.ok, "Exp. Stop Inflation SUCCESS - Outside Structures", "Exp. Stop Inflation FAIL - Outside Structures"));
                    break;

                case "btnExpLedOnStructure1": //LEDs
                    data = new byte[] { (byte)device_id.led_1}; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_uv_on, data, network.tcp_message_id.ok, "Exp. UV-LEDs ON SUCCESS - Structure 1", "Exp. UV-LEDs ON FAIL - Structure 1"));
                    break;
                case "btnExpLedOffStructure1":
                    data = new byte[] { (byte)device_id.led_1 }; 
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_uv_off, data, network.tcp_message_id.ok, "Exp. UV-LEDs OFF SUCCESS - Structure 1", "Exp. UV-LEDs OFF FAIL - Structure 1"));
                    break;
                case "btnExpLedOnStructure2":
                    data = new byte[] { (byte)device_id.led_2 }; 
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_uv_on, data, network.tcp_message_id.ok, "Exp. UV-LEDs ON SUCCESS - Structure 2", "Exp. UV-LEDs ON FAIL - Structure 2"));
                    break;
                case "btnExpLedOffStructure2":
                    data = new byte[] { (byte)device_id.led_2 };
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_uv_off, data, network.tcp_message_id.ok, "Exp. UV-LEDs OFF SUCCESS - Structure 2", "Exp. UV-LEDs OFF FAIL - Structure 2"));
                    break;

                case "btnExpInflationOnValve1":
                    data = new byte[] { (byte)device_id.valve_1 }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_manual_on, data, network.tcp_message_id.ok, "Exp. VALVE ON SUCCESS - Valve 1", "Exp. VALVE ON FAIL - Valve 1"));
                    break;
                case "btnExpInflationOnValve2":
                    data = new byte[] { (byte)device_id.valve_2 }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_manual_on, data, network.tcp_message_id.ok, "Exp. VALVE ON SUCCESS - Valve 2", "Exp. VALVE ON FAIL - Valve 2"));
                    break;
                case "btnExpInflationOnValve3":
                    data = new byte[] { (byte)device_id.valve_3 }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_manual_on, data, network.tcp_message_id.ok, "Exp. VALVE ON SUCCESS - Valve 3", "Exp. VALVE ON FAIL - Valve 3"));
                    break;
                case "btnExpInflationOnValve4":
                    data = new byte[] { (byte)device_id.valve_4 }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_manual_on, data, network.tcp_message_id.ok, "Exp. VALVE ON SUCCESS - Valve 4", "Exp. VALVE ON FAIL - Valve 4"));
                    break;

                case "btnExpInflationOffValve1":
                    data = new byte[] { (byte)device_id.valve_1 }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_manual_off, data, network.tcp_message_id.ok, "Exp. VALVE OFF SUCCESS - Valve 1", "Exp. VALVE OFF FAIL - Valve 1"));
                    break;
                case "btnExpInflationOffValve2":
                    data = new byte[] { (byte)device_id.valve_2 }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_manual_off, data, network.tcp_message_id.ok, "Exp. VALVE OFF SUCCESS - Valve 2", "Exp. VALVE OFF FAIL - Valve 2"));
                    break;
                case "btnExpInflationOffValve3":
                    data = new byte[] { (byte)device_id.valve_3 }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_manual_off, data, network.tcp_message_id.ok, "Exp. VALVE OFF SUCCESS - Valve 3", "Exp. VALVE OFF FAIL - Valve 3"));
                    break;
                case "btnExpInflationOffValve4":
                    data = new byte[] { (byte)device_id.valve_4 }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_manual_off, data, network.tcp_message_id.ok, "Exp. VALVE OFF SUCCESS - Valve 4", "Exp. VALVE OFF FAIL - Valve 4"));
                    break;

                case "btnCamInside":
                     data = new byte[] { }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_cam_live_inside, data, network.tcp_message_id.ok, "Exp. CAM LIVE INSIDE SUCCESS", "Exp. CAM LIVE INSIDE FAIL"));
                    break;
                case "btnCamOutside":
                    data = new byte[] { }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_cam_live_outside, data, network.tcp_message_id.ok, "Exp. CAM LIVE OUTSIDE SUCCESS", "Exp. CAM LIVE OUTSIDE FAIL"));
                    break;
                case "btnCamStartLive":
                    data = new byte[] { }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_cam_live_start, data, network.tcp_message_id.ok, "Exp. CAM LIVE DTART INSIDE SUCCESS", "Exp. CAM LIVE START INSIDE FAIL"));
                    break;
                case "btnCamStopLive":
                    data = new byte[] { }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_cam_live_stop, data, network.tcp_message_id.ok, "Exp. CAM LIVE STOP INSIDE SUCCESS", "Exp. CAM LIVE STOP INSIDE FAIL"));
                    break;

                case "btnExpValve3Pulse":
                    data = new byte[] { (byte)device_id.valve_3,(byte)numV3PulseTime.Value,(byte)numPulseV3Multi.Value }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_pulse, data, network.tcp_message_id.ok, "Exp. PULSE SUCCESS", "Exp. PULSE FAIL"));
                    break;
                case "btnExpValve1Pulse":
                    data = new byte[] { (byte)device_id.valve_1, (byte)numV1PulseTime.Value, (byte)numPulseV1Multi.Value }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_valves_pulse, data, network.tcp_message_id.ok, "Exp. PULSE SUCCESS", "Exp. PULSE FAIL"));
                    break;

                case "btnCamStartRecInside":
                    data = new byte[] { (byte)device_id.camera_inside }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_cam_start_recording, data, network.tcp_message_id.ok, "Exp. CAM START RECORD INSIDE SUCCESS", "Exp. START RECORD STOP INSIDE FAIL"));
                    break;
                case "btnCamStopRecInside":
                    data = new byte[] { (byte)device_id.camera_inside }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_cam_stop_recording, data, network.tcp_message_id.ok, "Exp. CAM STOP RECORD INSIDE SUCCESS", "Exp. CAM STOP RECORD INSIDE FAIL"));
                    break;
                case "btnCamStartRecOutside":
                    data = new byte[] { (byte)device_id.camera_outside }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_cam_start_recording, data, network.tcp_message_id.ok, "Exp. CAM START RECORD INSIDE SUCCESS", "Exp. START RECORD INSIDE FAIL"));
                    break;
                case "btnCamStopRecOutside":
                    data = new byte[] { (byte)device_id.camera_outside }; //device_id
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_cam_stop_recording, data, network.tcp_message_id.ok, "Exp. CAM STOP RECORD INSIDE SUCCESS", "Exp. CAM STOP RECORD INSIDE FAIL"));
                    break;

                default:
                    break;
            }
        }

        private void timerStopWatch_Tick(object sender, EventArgs e) //update lift off stop watch
        {
            TimeSpan duration = DateTime.Now - stop_watch_start_time;
            statusStripFlightTime.Text = "Flight Time - "+ duration.ToString(@"hh\:mm\:ss");
        }

        private void timerConnectionTest_Tick(object sender, EventArgs e)
        {
            bool ping = true;
            bool tcp_ping = true;

            for(int i = 0; i < tcp_client.tcp_command_list.Count;i++)
            {
                if (tcp_client.tcp_command_list[i].message_id == network.tcp_message_id.ping)
                    ping = false;

                if (tcp_client.tcp_command_list[i].message_id == network.tcp_message_id.tcp_ping)
                    tcp_ping = false;
            }

            if(ping)
                tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.ping, new byte[] { }));

            if(tcp_ping)
                tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.tcp_ping, new byte[] { }));
        }

        private void trackbarScalingAmbTemperature_Scroll(object sender, EventArgs e)
        {
            chartTemperature.ChartAreas[0].AxisX.Maximum = 0.417*trackbarScalingAmbTemperature.Value/100f;
        }

        private void trackbarScalingAmbPressure_Scroll(object sender, EventArgs e)
        {
            chartPressure.ChartAreas[0].AxisX.Maximum = 0.417 * trackbarScalingAmbPressure.Value / 100f;
        }

        private void cbExpHdrmLock_CheckedChanged(object sender, EventArgs e)
        {
            if(cbExpHdrmLock.Checked)
            {
                btnExpHDRMInside.Enabled = false;
                btnExpHDRMOutside.Enabled = false;
            }
            else
            {
                btnExpHDRMInside.Enabled = true;
                btnExpHDRMOutside.Enabled = true;
            }
        }



        private void cbExpManualInflateLock_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExpManualInflateLock.Checked)
            {
                btnExpInflationOffValve1.Enabled = false;
                btnExpInflationOffValve2.Enabled = false;
                btnExpInflationOffValve3.Enabled = false;
                btnExpInflationOffValve4.Enabled = false;
                btnExpInflationOnValve1.Enabled = false;
                btnExpInflationOnValve2.Enabled = false;
                btnExpInflationOnValve3.Enabled = false;
                btnExpInflationOnValve4.Enabled = false;
                btnExpValve1Pulse.Enabled = false;
                btnExpValve3Pulse.Enabled = false;
            }
            else
            {
                btnExpInflationOffValve1.Enabled = true;
                btnExpInflationOffValve2.Enabled = true;
                btnExpInflationOffValve3.Enabled = true;
                btnExpInflationOffValve4.Enabled = true;
                btnExpInflationOnValve1.Enabled = true;
                btnExpInflationOnValve2.Enabled = true;
                btnExpInflationOnValve3.Enabled = true;
                btnExpInflationOnValve4.Enabled = true;
                btnExpValve1Pulse.Enabled = true;
                btnExpValve3Pulse.Enabled = true;
            }
        }

        private void cbExpAutoInflateLock_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExpAutoInflateLock.Checked)
            {
                btnExpInflationStartInside.Enabled = false;
                btnExpInflationStopInside.Enabled = false;
                btnExpInflationStartOutside.Enabled = false;
                btnExpInflationStopOutside.Enabled = false;
            }
            else
            {
                btnExpInflationStartInside.Enabled = true;
                btnExpInflationStopInside.Enabled = true;
                btnExpInflationStartOutside.Enabled = true;
                btnExpInflationStopOutside.Enabled = true;
            }
        }

        private void cbExpUVLock_CheckedChanged(object sender, EventArgs e)
        {
            if (cbExpUVLock.Checked)
            {
                btnExpLedOffStructure2.Enabled = false;
                btnExpLedOffStructure1.Enabled = false;
                btnExpLedOnStructure2.Enabled = false;
                btnExpLedOnStructure1.Enabled = false;
            }
            else
            {
                btnExpLedOffStructure2.Enabled = true;
                btnExpLedOffStructure1.Enabled = true;
                btnExpLedOnStructure2.Enabled = true;
                btnExpLedOnStructure1.Enabled = true;
            }
        }
    }
}
