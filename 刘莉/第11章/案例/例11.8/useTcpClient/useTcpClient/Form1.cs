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
namespace useTcpClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 实例化一个TcpListener对象，并初始化为空
            TcpListener tcplistener = null;
            // 实例化一个IPAddress对象，用来表示网络IP地址
            IPAddress ipaddress = IPAddress.Parse(textBox1.Text.Trim ());
            // 定义一个int类型变量，用来存储端口号
            int port = Convert.ToInt32(textBox2.Text.Trim());
            // 初始化TcpListener对象
            tcplistener = new TcpListener(ipaddress, port);
            tcplistener.Start();        // 开始TcpListener侦听
            richTextBox1.Text = "等待连接……\n";
            // 实例化一个TcpClient对象，并初始化为空
            TcpClient tcpclient = null;
            if (tcplistener.Pending())      // 判断是否有挂起的连接请求
                // 使用AcceptTcpClient初始化TcpClient对象
                tcpclient = tcplistener.AcceptTcpClient();
            else
                // 使用TcpClient的构造函数初始化TcpClient对象
                tcpclient = new TcpClient(textBox1.Text.Trim(), port);
            richTextBox1.Text += "连接成功！\n";
            tcpclient.Close();          // 关闭TcpClient连接
            tcplistener.Stop();         // 停止TcpListener侦听
        }
    }
}
