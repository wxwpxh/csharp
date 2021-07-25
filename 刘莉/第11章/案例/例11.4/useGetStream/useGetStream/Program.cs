using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace useGetStream
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAddress = Dns.Resolve("192.168.22.20").AddressList[0];
            TcpListener tcpListener = new TcpListener(ipAddress,8080);
            tcpListener.Start ();
            //Socket listenSocket = new Socket(AddressFamily.InterNetwork,
            //     SocketType.Stream, ProtocolType.Tcp);
            //// 绑定套接字监听的端口
            //IPAddress hostIP = (Dns.Resolve("localhost")).AddressList[0];
            //IPEndPoint ep = new IPEndPoint(hostIP, 80);
            //listenSocket.Bind(ep);
            //// 开始监听
            //listenSocket.Listen(10);
            TcpClient tcpClient = tcpListener.AcceptTcpClient();        // 接收连接请求
            NetworkStream nstream = tcpClient.GetStream();           // 获取数据流
            byte[] mbyte = new byte[1024];                                         // 建立缓存
            int i = nstream.Read(mbyte ,0,mbyte .Length );                // 将数据流写入缓存
            Console.WriteLine("TcpClent = "+tcpClient .ToString ());
            Console.WriteLine("NetworkStream = "+nstream .ToString ());
            Console.WriteLine("i = "+i.ToString ());
            Console.Read();
        }
    }
}
