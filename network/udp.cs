using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;


namespace mass_groundstation_v2.network
{
    class udp
    {
        UdpClient client;
        IPEndPoint endpoint;


        enum udp_message_id : byte
        {
            blank = 0,
            ambient = 100,
            power = 101,
            pneumatics = 102,
            gyro = 103
        }

        public void udp_thread()
        {
            Thread.Sleep(2000); //sleep to prevent uninitialized main form

            while (true)
            {
                try
                {
                    Byte[] received_bytes = client.Receive(ref endpoint);

                    switch ((udp_message_id)received_bytes[0])
                    {
                        case udp_message_id.ambient: //ambient conditions data
                            helper.helper.change_text_box(Program.main_form.tbAmbientTemperatureInside, BitConverter.ToSingle(received_bytes, 1).ToString() + " °C");
                            helper.helper.change_text_box(Program.main_form.tbAmbientTemperatureOutside, BitConverter.ToSingle(received_bytes, 5).ToString() + " °C");
                            helper.helper.change_text_box(Program.main_form.tbAmbientPressure, BitConverter.ToSingle(received_bytes, 9).ToString() + " mbar");
                            break;

                        case udp_message_id.power: //power data
                            float voltage_bx = BitConverter.ToSingle(received_bytes, 1); //convert byte array to float
                            float voltage_ex = BitConverter.ToSingle(received_bytes, 5);
                            float current_bx = BitConverter.ToSingle(received_bytes, 9);
                            float current_ex = BitConverter.ToSingle(received_bytes, 13);
                            float power_bx = voltage_bx * current_bx; // power calculation W = V*A
                            float power_ex = voltage_ex * current_ex;
                            helper.helper.change_text_box(Program.main_form.tbExpPowerVoltageBX, voltage_bx.ToString() + " V");
                            helper.helper.change_text_box(Program.main_form.tbExpPowerVoltageEX, voltage_ex.ToString() + " V");
                            helper.helper.change_text_box(Program.main_form.tbExpPowerCurrentBX, current_bx.ToString() + " A");
                            helper.helper.change_text_box(Program.main_form.tbExpPowerCurrentEX, current_ex.ToString() + " A");
                            helper.helper.change_text_box(Program.main_form.tbExpPowerPowerBX, power_bx.ToString() + " W");
                            helper.helper.change_text_box(Program.main_form.tbExpPowerPowerEX, power_ex.ToString() + " W");
                            break;

                    }

                }
                catch (Exception except)
                {

                }
            }
        }

        public udp(string experiment_ip, int udp_port)
        {
            client = new UdpClient(udp_port);
            endpoint = new IPEndPoint(IPAddress.Parse(experiment_ip), 0);

            Thread thdUDPServer = new Thread(new ThreadStart(udp_thread));
            thdUDPServer.Start();
        }
    }
}
