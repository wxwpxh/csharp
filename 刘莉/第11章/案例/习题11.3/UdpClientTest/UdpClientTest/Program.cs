using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace UdpClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient1 = new UdpClient();
            string hostIP = "192.168.22.20";
            string sendMsg = "hello,world!";
            byte[] data = Encoding.ASCII.GetBytes(sendMsg);
            udpClient1.Send(data, data.Length, hostIP, 7);
            IPEndPoint endPoint = new IPEndPoint(IPAddress .Parse ("192.168.22.20"), 70);
            byte[] recBytes = udpClient1.Receive(ref endPoint);
            string recMessage = Encoding.ASCII.GetString(recBytes, 0,
     recBytes.Length);
            Console.WriteLine(recMessage);
            Console.Read();
        }
    }
}
