using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace useSocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Socket ConnectSocket(string server, int port)
        {
            Socket socket = null;           // 实例化Socket对象，并初始化为空
            IPHostEntry iphostentry = null;     // 实例化IPHostEntry对象，并初始化为空
            iphostentry = Dns.GetHostEntry (server.Trim ());      // 获得主机信息
            // 循环遍历得到的IP地址列表
            foreach (IPAddress address in iphostentry.AddressList)
            {
                // 使用指定的IP地址和端口号实例化IPEndPoint对象
                IPEndPoint IPEPoint = new IPEndPoint(address, port);
                // 使用Socket的构造函数实例化一个Socket对象，以便用来连接远程主机
                Socket newSocket = new Socket(IPEPoint.AddressFamily, 
                    SocketType.Stream, ProtocolType.Tcp);
                newSocket.Connect(IPEPoint);        // 调用Connect方法连接远程主机
                if (newSocket.Connected)
                {
                    socket = newSocket;
                    break;
                }
                else
                {
                    continue;
                }
            }
            return socket;
        }

        // 获取指定服务器的主页面内容
        private static string SocketSendReceive(string server, int port)
        {
            string request = @"GET/HTTP://" + server + @"/";
            Byte[] btSend = Encoding.ASCII.GetBytes(request);
            Byte[] btReceived = new Byte[256];
            // 调用自定义方法ConnectSocket，使用指定的服务器名和端口号实例化一个Socket对象
            Socket socket = ConnectSocket(server, port);
            if (socket == null)  
                return ("连接失败！");
            // 将请求发送到连接的服务器
            socket.Send(btSend, btSend.Length, 0);
            int intContent = 0;
            string strContent = server + "上的默认页面内容：\n";
            do
            {
                // 从绑定的Socket接收数据
                intContent = socket.Receive(btReceived, btReceived.Length, 0);
                // 将接收到的数据转换为字符串类型
                strContent += Encoding.ASCII.GetString(btReceived, 0, intContent);
            }
            while (intContent > 0);
            return strContent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string server = textBox1.Text;                        // 指定主机名
            int port = Convert.ToInt32(textBox2.Text);      // 指定端口号
            // 调用自定义方法SocketSendReceive获取指定主机的主页面内容
            string strContent = SocketSendReceive(server, port);
            MessageBox.Show(strContent );
        }
    }
}
