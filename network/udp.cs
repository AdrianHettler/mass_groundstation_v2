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
using Helper = mass_groundstation_v2.helper.helper;
using System.Drawing;
using System.Windows.Forms;

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
            gyro = 103,
            picture = 104
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
                            float ambient_temperature_inside = BitConverter.ToSingle(received_bytes, 1);
                            float ambient_temperature_outside = BitConverter.ToSingle(received_bytes, 5);
                            float ambient_pressure = BitConverter.ToSingle(received_bytes, 9);
                            int cam_remaining_inside = BitConverter.ToInt32(received_bytes, 13);
                            int cam_remaining_outside = BitConverter.ToInt32(received_bytes, 17);


                            Helper.change_text_box(Program.main_form.tbAmbientTemperatureInside, ambient_temperature_inside.ToString() + " °C");
                            Helper.change_text_box(Program.main_form.tbAmbientTemperatureOutside, ambient_temperature_outside.ToString() + " °C");
                            Helper.change_text_box(Program.main_form.tbAmbientPressure, ambient_pressure.ToString() + " mbar");

                            Helper.change_text_box(Program.main_form.tbCameraTimeRemainInside, cam_remaining_inside.ToString() + " s");
                            Helper.change_text_box(Program.main_form.tbCameraTimeRemainOutside, cam_remaining_outside.ToString() + " s");

                            if (Program.main_form.lift_off)
                            {
                                TimeSpan time = DateTime.Now - Program.main_form.stop_watch_start_time;

                                Helper.chart_add_xy(Program.main_form.chartTemperature, "temperatureInside", time, ambient_temperature_inside);
                                Helper.chart_add_xy(Program.main_form.chartTemperature, "temperatureOutside", time, ambient_temperature_outside);
                                Helper.chart_add_xy(Program.main_form.chartPressure, "pressure", time, ambient_pressure);
                            }


                            string output_text = DateTime.Now.ToString("HH:mm:ss;") +ambient_temperature_inside.ToString()+";" + ambient_temperature_outside.ToString() +";"+ ambient_pressure.ToString();

                           // TimeSpan duration = DateTime.Now - stop_watch_start_time;
                           // statusStripFlightTime.Text = "Flight Time - " + duration.ToString(@"hh\:mm\:ss");


                           // Helper.write_log(output_text, Path.Combine(Program.application_path + "\\" + Program.application_start_time, "log_file_" + Program.application_start_time + ".txt"));

                            Helper.write_log(output_text, Path.Combine("C:\\bexus_logs\\" + Program.application_start_time, "amb_log_file_" + Program.application_start_time + ".txt"));
                            Helper.write_log(output_text, Path.Combine(Program.application_path + "\\" + Program.application_start_time, "amb_log_file_" + Program.application_start_time + ".txt"));



                            //write_log(output_text, Path.Combine("C:\\bexus_logs\\" + Program.application_start_time, "log_file_" + Program.application_start_time + ".txt"));


                            break;

                        case udp_message_id.power: //power data
                            float voltage_bx = BitConverter.ToSingle(received_bytes, 1); //convert byte array to float
                            float voltage_ex = BitConverter.ToSingle(received_bytes, 5);
                            float current_bx = BitConverter.ToSingle(received_bytes, 9);
                            float current_ex = BitConverter.ToSingle(received_bytes, 13);
                            float power_bx = voltage_bx * current_bx; // power calculation W = V*A
                            float power_ex = voltage_ex * current_ex;
                            Helper.change_text_box(Program.main_form.tbExpPowerVoltageBX, voltage_bx.ToString() + " V");
                            Helper.change_text_box(Program.main_form.tbExpPowerVoltageEX, voltage_ex.ToString() + " V");
                            Helper.change_text_box(Program.main_form.tbExpPowerCurrentBX, current_bx.ToString() + " A");
                            Helper.change_text_box(Program.main_form.tbExpPowerCurrentEX, current_ex.ToString() + " A");
                            Helper.change_text_box(Program.main_form.tbExpPowerPowerBX, power_bx.ToString() + " W");
                            Helper.change_text_box(Program.main_form.tbExpPowerPowerEX, power_ex.ToString() + " W");

                            string log_power = DateTime.Now.ToString("HH:mm:ss;") + voltage_bx.ToString() + ";" + voltage_ex.ToString() + ";" + current_bx.ToString() + ";" + current_ex.ToString() + ";" + power_bx.ToString() + ";" + power_ex.ToString();

                          
                            Helper.write_log(log_power, Path.Combine("C:\\bexus_logs\\" + Program.application_start_time, "power_log_file_" + Program.application_start_time + ".txt"));
                            Helper.write_log(log_power, Path.Combine(Program.application_path + "\\" + Program.application_start_time, "power_log_file_" + Program.application_start_time + ".txt"));


                            break;

                        case udp_message_id.picture:
                            //if (BitConverter.ToUInt16(received_bytes, 1) == 0)
                            //{
                            //    Program.main_form.frame_bmp.Bitmap.Clear
                            //}
                                Byte[] picture_data = received_bytes.Skip(3).ToArray();
                            Program.main_form.frame_bmp.SetLine(BitConverter.ToUInt16(received_bytes, 1), picture_data);



                            if (BitConverter.ToUInt16(received_bytes, 1) == 255)
                            {
                                Program.main_form.pictureBoxLive.Invoke((MethodInvoker)delegate
                                {
                                    Program.main_form.pictureBoxLive.Image = Program.main_form.frame_bmp.Bitmap;
                                });

                            }

                            break;

                        case udp_message_id.pneumatics: //power data
                            float pressure_structures_outside =  BitConverter.ToSingle(received_bytes, 1); //convert byte array to float
                            float pressure_structures_inside = BitConverter.ToSingle(received_bytes, 5);
                            float pressure_tank = ((BitConverter.ToSingle(received_bytes, 9)-0.1f)/9.9f)*16;

                            Helper.change_text_box(Program.main_form.tbExpPneuInsideStructuresPressure, pressure_structures_inside.ToString() + " mbar");
                            Helper.change_text_box(Program.main_form.tbExpPneuOutsideStructuresPressure, pressure_structures_outside.ToString() + " mbar");
                            Helper.change_text_box(Program.main_form.tbExpPneuTankPressure, pressure_tank.ToString() + " bar");


                            string log_pneu = DateTime.Now.ToString("HH:mm:ss;") + pressure_structures_outside.ToString() + ";" + pressure_structures_inside.ToString() + ";" + pressure_tank.ToString();


                            Helper.write_log(log_pneu, Path.Combine("C:\\bexus_logs\\" + Program.application_start_time, "pneu_log_file_" + Program.application_start_time + ".txt"));
                            Helper.write_log(log_pneu, Path.Combine(Program.application_path + "\\" + Program.application_start_time, "pneu_log_file_" + Program.application_start_time + ".txt"));



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
