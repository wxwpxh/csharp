using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace useListen
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket listenSocket = new Socket(AddressFamily .InterNetwork ,
                 SocketType.Stream,ProtocolType .Tcp );
            // 绑定套接字监听的端口
            IPAddress hostIP=(Dns.Resolve(IPAddress.Any.ToString())).AddressList[0];
            IPEndPoint ep = new IPEndPoint(hostIP, 1000);
            listenSocket.Bind(ep);
            // 开始监听
            listenSocket.Listen(10);
            Console.WriteLine("IPAddress = " + hostIP.ToString () );
            Console.WriteLine("IPEndPoint = " + ep.ToString  ());
            Console.Read();
        }
    }
}
