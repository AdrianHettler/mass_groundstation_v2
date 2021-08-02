using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace mass_groundstation_v2.network
{
    class network
    {
        public static string get_local_ip()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address.ToString();
            }
        }

        public static PingReply ping_ip(string ip)
        {
            Ping p = new Ping();
            PingReply r;

            r = p.Send(ip);

            return r;
        }

    }
}
