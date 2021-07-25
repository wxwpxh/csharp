using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace ConServer
{
    class ClientHandle
    {
        private string m_usename;
        private TcpClient m_clientsocket = null;//TcpClient实例
        private string m_returnData, m_sendData;//接收和发送数据
        byte[] data;//中间变量
        public TcpClient ClientSocket
        { //属性
            get
            {
                return m_clientsocket;
            }
            set
            {
                m_clientsocket = value;
            }
        }
        public void ResponseClient()
        {
            if (m_clientsocket != null)
            {
                StreamReader rs = new StreamReader(m_clientsocket.GetStream());
                NetworkStream ws = m_clientsocket.GetStream();
                m_returnData = rs.ReadLine();//获取用户名
                m_usename = m_returnData;//保留用户名
                m_sendData = "Welcome " + m_returnData + " to Server";
                Console.WriteLine(m_sendData);//显示信息 
                data = Encoding.ASCII.GetBytes(m_sendData + "\r\n");//回送欢迎信息
                ws.Write(data, 0, data.Length);
                while (true)
                {  //接收信息
                    m_returnData = rs.ReadLine();
                    if (m_returnData.ToUpper().IndexOf("QUIT") > -1)
                    {     //显示退出信息
                        Console.WriteLine(m_usename + " has quited!");
                        break;
                    }
                    else if (m_returnData.ToUpper().IndexOf("GETDATE") > -1)
                    { //回送当前时间
                        m_sendData = DateTime.Now.ToString();
                    }
                    else
                    {  //回送所接收的信息
                        m_sendData = "-->" + m_returnData;
                    }
                    data = Encoding.ASCII.GetBytes(m_sendData + "\r\n");
                    ws.Write(data, 0, data.Length);
                }
                m_clientsocket.Close();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string m_serverIP = "192.168.22.20";
            int m_port = 5555;
            TcpListener m_Listener = null;
            IPAddress m_host;
            if (true)
            {
                try
                {
                    m_host = IPAddress.Parse(m_serverIP);
                    m_Listener = new TcpListener(m_host, m_port);
                    m_Listener.Start();
                    Console.WriteLine("Starting to listen....");
                    while (true)
                    {
                        TcpClient m_client = m_Listener.AcceptTcpClient();
                        ClientHandle m_handle = new ClientHandle();
                        m_handle.ClientSocket = m_client;
                        Thread m_clientthread = new Thread(new
ThreadStart(m_handle.ResponseClient));
                        m_clientthread.Start();
                    }
                    m_Listener.Stop();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception:" + e.Message);
                }
            }
            Console.Read();
        }
    }
}
