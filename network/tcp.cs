using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;
using System.IO;
using System.Drawing;
using Helper = mass_groundstation_v2.helper.helper;



namespace mass_groundstation_v2.network
{
    public enum tcp_message_id : byte
    {
        blank = 0,
        ok = 1,
        tcp_ping = 2,
        tcp_pong = 3,
        udp_pong = 4,
        reset = 5,
        ping = 6,
        error_unknown_msg_id = 252,
        error_buffer_size  = 253,
        error = 254,

        exp_init = 20,
        exp_release_structures = 21,
        exp_start_inflation = 22,
        exp_uv_on = 23,
        exp_uv_off = 24,
        exp_cam_start = 25,
        exp_cam_stop = 26,
        exp_valves_manual_on = 27,
        exp_valves_manual_off = 28,
        exp_stop_inflation = 29,
        exp_cam_live_inside = 30,
        exp_cam_live_outside = 31,
        exp_cam_live_start = 32,
        exp_cam_live_stop = 33,
        exp_cam_live_interval = 34,
        exp_valves_pulse = 35

    }

    public struct tcp_command
    {
        public tcp_message_id message_id;
        public byte[] data;
        public tcp_message_id expected_return_value;
        public string success_text;
        public string error_text;

        public tcp_command(tcp_message_id message_id_, byte[] data_ , tcp_message_id expected_return_value_ = tcp_message_id.blank, string success_text_ = "", string error_text_ = "")
        {
            message_id = message_id_;
            data = data_;
            expected_return_value = expected_return_value_;
            success_text = success_text_;
            error_text = error_text_;
        }
    }

    public class tcp
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread thd_tcp;
        private bool tcp_connected = false; 

        public List<tcp_command> tcp_command_list = new List<tcp_command>(); //command list to process tcp commands

        void tcp_thread()
        {
            Thread.Sleep(2000); //sleep to prevent uninitialized main form

            while (true)
            {
                Thread.Sleep(20);

                try
                {
                    if (!tcp_connected) // INIT TCP CLIENT
                    {                        
                        try
                        {
                            bool tcp_init = init(Program.main_form.tbConnectionExpIP.Text, (int)Program.main_form.numTcpPort.Value);
                            if (tcp_init)
                            {
                                tcp_connected = send_initial_payload(); //send initial tcp packet to check connection

                                if (tcp_connected)
                                    helper.helper.print_log("TCP INIT SUCCESS");
                                else
                                    helper.helper.print_log("TCP INIT ERROR - IP/PORT found, initial Write/Read Failed");
                            }
                            else
                            {
                                helper.helper.print_log("TCP INIT ERROR - IP/PORT not available (NO CONNECTION)");
                                Thread.Sleep(1000);
                            }
                        }
                        catch (Exception except)
                        {
                            helper.helper.print_log("TCP INIT ERROR - Exception thrown: " + except.Message);
                        }
                    }

                    if(tcp_command_list.Count > 0)
                    {
                        if (tcp_command_list[0].message_id == tcp_message_id.ping) //ping check (tcp not required)
                        {
                            PingReply reply = Helper.ping_ip(Program.main_form.tbConnectionExpIP.Text);

                            if (reply.Status == IPStatus.Success)
                                Helper.change_label(Program.main_form.statusStripPing, reply.RoundtripTime.ToString() + " ms", reply.RoundtripTime < 50 ? Color.Green : Color.Orange);
                            else
                                Helper.change_label(Program.main_form.statusStripPing, "Not connected", Color.Red);

                            tcp_command_list.RemoveAt(0); // remove the processed first entry from command list
                        }
                        else if (tcp_connected) //check if tcp is connected && a tcp command is in command list
                        {
                            try
                            {
                                if (stream.CanWrite)
                                {
                                    if (tcp_command_list[0].message_id == tcp_message_id.tcp_ping) //special tcp commands with different returns
                                    {
                                        byte[] message = new byte[] { (byte)tcp_command_list[0].message_id };
                                        stream.Write(message, 0, message.Length);

                                        if (stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[client.ReceiveBufferSize];
                                            int bytesRead = stream.Read(message_receive, 0, client.ReceiveBufferSize);

                                            if ((tcp_message_id)message_receive[0] == tcp_message_id.tcp_pong)
                                                Helper.change_label(Program.main_form.statusStripTCP, "Connected", Color.Green);                                                                                          
                                            else
                                                Helper.change_label(Program.main_form.statusStripTCP, "Not Connected", Color.Red);
                                        }
                                        tcp_command_list.RemoveAt(0); // remove the processed first entry from command list
                                    }
                                    else //standard tcp commands
                                    {
                                        var mem_stream = new MemoryStream(); //memory stream to append byte array: byte array = (byte)message_id + (byte[])data;
                                        mem_stream.WriteByte((byte)tcp_command_list[0].message_id);
                                        mem_stream.Write(tcp_command_list[0].data, 0, tcp_command_list[0].data.Length);

                                        byte[] message = mem_stream.ToArray();

                                        stream.Write(message, 0, message.Length);

                                        if (stream.CanRead)
                                        {
                                            byte[] message_receive = new byte[client.ReceiveBufferSize];
                                            int bytesRead = stream.Read(message_receive, 0, client.ReceiveBufferSize);

                                            if ((tcp_message_id)message_receive[0] == tcp_command_list[0].expected_return_value)
                                            {
                                                Helper.print_log(tcp_command_list[0].success_text);
                                                tcp_command_list.RemoveAt(0); // remove the processed first entry from command list
                                            }
                                            else
                                                Helper.print_log(tcp_command_list[0].error_text + "- Return: " + message_receive[0].ToString());
                                        }
                                    }
                                }
                            }
                            catch (Exception except)
                            {
                                client.Close();
                                tcp_connected = false;
                                Helper.print_log("TCP READ/WRITE ERROR - Exception: " + except.Message);
                                Helper.change_label(Program.main_form.statusStripTCP, "NOT CONNECTED", Color.Red);
                            }
                        }
                    }
                }
                catch (Exception except)
                {
                    Helper.print_log("TCP THREAD EXCEPTION: " + except.Message);
                }
            }
        }

        public tcp()
        {
            thd_tcp = new Thread(new ThreadStart(tcp_thread));
            thd_tcp.Start();
        }

        public bool init(string experiment_ip, int tcp_port)
        {
            client = new TcpClient();
            var result = client.BeginConnect(experiment_ip, (int)tcp_port, null, null);
            var success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1));

            if (!success)
                return false;
            
            stream = client.GetStream();
            stream.ReadTimeout = 1000;
            stream.WriteTimeout = 1000;

            return true;             
        }

        private bool send_initial_payload()
        {
            byte[] message_ping_payload = { 0xFF, 0xFF, 0xFF, 0xFF };

            if (stream.CanWrite)
            {
                stream.Write(message_ping_payload, 0, message_ping_payload.Length);

                if (stream.CanRead)
                {
                    byte[] message_ping_payload_receive = new byte[client.ReceiveBufferSize];
                    stream.Read(message_ping_payload_receive, 0, client.ReceiveBufferSize);
                    return true;
                }
            }
            return false;
        }
    }
}
