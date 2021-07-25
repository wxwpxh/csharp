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
using System.Threading; 

namespace UDPReceive
{
    public partial class Form1 : Form
    {
        //定义一个UDPClient类型的字段
        UdpClient udpClient;
        //定义一个线程 
        Thread thread;

        public Form1()
        {
            //屏蔽异常以便跨线程访问控件 
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            //创建一个与指定端口绑定的UDPClient
            //实例，此端口须与发送方端口相同 
            udpClient = new UdpClient(13579);
        }

        //监听并接收数据
        private void listen()
        {
            //定义一个终结点，因为此前创建的UDPClient实例已与指定端口绑定，
            //所以，此处的IP地址和端口可任意设置或不设置
            IPEndPoint iep = null;
            while (true)
            {
                //获得发送方的数据包并转换为指定字符类型。
                //ref关键字使参数按引用传递，当控制权传给回调用方法时，
                //在方法中对参数所做的任何更改都将反映在该变量中
                string sData = System.Text.Encoding.UTF8.GetString(udpClient.Receive(ref iep));
                //将接收到的数据添加到listBox1的条目中
                this.listBox1.Items.Add(sData);
            }
        }

        //启动数据接收
        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个线程以监听并接收数据 
            thread = new Thread(new ThreadStart(listen));
            //设置为后台线程，以便关闭窗体时终止线程 
            thread.IsBackground = true;
            thread.Start();
        }

        //关闭窗体时终止线程
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //终止线程
            if (thread!=null) thread.Abort();
        }
    }
}