using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ClientText
{
    class Program
    {
        static void Main(string[] args)
        {
            string m_servername = "192.168.22.20";
            string m_username = "DataServer";
            int m_port = 5555;
            TcpClient m_client;
            string m_sendData, m_returnData;
            byte[] data;
            StreamReader rs;
            NetworkStream ws;
            try
            {
                m_client = new TcpClient();
                m_client.Connect(m_servername, m_port);
                rs = new StreamReader(m_client.GetStream());
                ws = m_client.GetStream();
                m_sendData = m_username;
                data = Encoding.ASCII.GetBytes(m_sendData + "\r\n");
                ws.Write(data, 0, data.Length);
                while (true)
                {
                    m_returnData = rs.ReadLine();
                    Console.WriteLine(m_returnData);
                    Console.WriteLine("Input data[GETDATE|QUIT|Other]:");
                    m_sendData = Console.ReadLine();
                    data = Encoding.ASCII.GetBytes(m_sendData + "\r\n");
                    ws.Write(data, 0, data.Length);
                    if (m_sendData.ToUpper().IndexOf("QUIT") > -1)
                    {
                        Console.WriteLine(m_username + " has quited!");
                        break;
                    }
                }
                m_client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.Message);
            }
            Console.Read();
        }
    }
}
