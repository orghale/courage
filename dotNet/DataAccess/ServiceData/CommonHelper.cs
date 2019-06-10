using System;
using System.Net;
using System.Net.Sockets;

namespace LottoGistAdmin.DataAccess.ServiceData
{
    public class CommonHelper
    {
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                //if (ip.AddressFamily == AddressFamily.InterNetwork)
                if (ip.AddressFamily != AddressFamily.InterNetworkV6)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }
    }
}