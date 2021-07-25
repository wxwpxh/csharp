using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace useConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient();
            IPAddress ipAddress = Dns.GetHostEntry("office.microsoft.com").AddressList[0];
            tcpClient.Connect(ipAddress,80 );
            Console.WriteLine("IPAddress = "+ipAddress .ToString ());
            Console.Read();
        }
    }
}
