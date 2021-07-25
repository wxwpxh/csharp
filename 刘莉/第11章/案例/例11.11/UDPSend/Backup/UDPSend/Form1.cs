using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//添加命名空间引用
using System.Net;
using System.Net.Sockets;

namespace UDPSend
{
    public partial class Form1 : Form
    {
        //定义一个UDPClient类型的字段
        UdpClient udpClient;
        public Form1()
        {
            //创建一个未与指定地址或端口绑定的UDPClient实例
            udpClient = new UdpClient(); 
            InitializeComponent();
        }

        //发送数据
        private void button1_Click(object sender, EventArgs e)
        {
            //临时存储textBox1中的数据
            string temp = this.textBox1.Text;
            //将textBox1中的数据（文本）转化为字节编码以便发送
            byte[] bData = System.Text.Encoding.UTF8.GetBytes(temp);
            //向本机的13579端口发送数据（方法1）
            //udpClient.Send(bData, bData.Length, Dns.GetHostName(), 13579);
            //向本机的13579端口发送数据（方法2）
            //利用方法2，可向其他计算机端口方式数据
            udpClient.Connect(IPAddress.Parse("127.0.0.1"), 13579);
            udpClient.Send(bData, bData.Length); 
        }
    }
}