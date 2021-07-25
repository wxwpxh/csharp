using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
namespace useUdpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            // 实例化UdpClient对象
            UdpClient udpclient=new UdpClient (Convert.ToInt32 (textBox2 .Text ));
            // 调用UdpClient对象的Connect建立默认远程主机
            udpclient .Connect (textBox1 .Text ,Convert.ToInt32 (textBox2 .Text ));
            // 定义一个字节数组，用来存放发送到远程主机的信息
            Byte [] sendBytes=Encoding .Default .GetBytes (textBox3 .Text );
            // 调用UdpClient对象的Send方法将Udp数据报发送到远程主机
            udpclient .Send(sendBytes ,sendBytes .Length );
            // 实例化IPEndPoint对象，用来显示响应主机的标识
            IPEndPoint ipendpoint=new IPEndPoint (IPAddress .Any ,0);
            // 调用UdpClient对象的Receive方法获得从远程主机返回的Udp数据报
            Byte [] receiveBytes=udpclient .Receive (ref ipendpoint );
            // 将获得的Udp数据报转换为字符串形式
            string returData =Encoding .Default .GetString (receiveBytes );
            richTextBox1 .Text ="接收到的信息："+returData .ToString ();
            // 使用IPEndPoint对象的Address和Port属性获得响应主机的IP地址和端口号
            richTextBox1 .Text +="\n这条信息来自主机"+ipendpoint .Address .ToString ()+
                "上的"+ipendpoint .Port .ToString() +"端口";
            // 关闭UdpClient连接
            udpclient .Close ();
        }
    }
}
