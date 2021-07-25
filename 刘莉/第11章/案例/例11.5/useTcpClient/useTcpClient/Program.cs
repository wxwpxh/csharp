using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace useTcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 8080;
            TcpListener server = new TcpListener(Dns.Resolve("192.168.22.20").AddressList [0],port );
            server.Start();
            byte[] bytes = new byte[1024];
            TcpClient client = server.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            Console.WriteLine("NetworkStream = "+stream .ToString ());
            Console.Read();
        }
    }
}
