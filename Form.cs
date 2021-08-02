using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        valve_4 = 7
    }

    public partial class Form : System.Windows.Forms.Form
    {
        private network.udp udp_client;
        private network.tcp tcp_client;

        public Form()
        {
            InitializeComponent();

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
                    helper.helper.print_log("Lift Off!");
                    break;
                case "btnConnectionClearTCPList":
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
                   tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_release_structures, data, network.tcp_message_id.ok, "Exp. Release Structure Command SUCCESS - Inside Structures", "Exp. Release Structure Command FAIL - Outside Structures"));            
                    break;
                case "btnExpHDRMOutside":
                    data = new byte[] { (byte)device_id.pin_puller_2, (byte)numExpHDRMActivationTimeOutside.Value }; //device_id,activation_time
                    tcp_client.tcp_command_list.Add(new network.tcp_command(network.tcp_message_id.exp_release_structures, data, network.tcp_message_id.ok, "Exp. Release Structure Command SUCCESS - Inside Structures", "Exp. Release Structure Command FAIL - Outside Structures"));
                    break;

                case "btnExpInflationStartInside": //Automated Inflation
                    break;
                case "btnExpInflationStopInside":
                    break;
                case "btnExpInflationStartOutside":
                    break;
                case "btnExpInflationStopOutside":
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

                default:
                    break;
            }
        }    
    }
}
