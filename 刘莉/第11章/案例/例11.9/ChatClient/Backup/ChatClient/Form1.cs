using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//添加新的名称空间引用
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//禁用此异常
        }

        //客户机与服务器之间的连接状态
        public bool bConnected = false;
        //侦听线程
        public Thread tAcceptMsg = null;
        //用于Socket通信的IP地址和端口
        public IPEndPoint IPP = null;
        //Socket通信
        public Socket socket = null;
        //网络访问的基础数据流
        public NetworkStream nStream = null;
        //创建读取器
        public TextReader tReader = null;
        //创建编写器
        public TextWriter wReader = null;

        //显示信息
        public void AcceptMessage()
        {
            string sTemp; //临时存储读取的字符串
            while(bConnected)
            {
                try
                {
                    //连续从当前流中读取字符串直至结束
                    sTemp = tReader.ReadLine();
                    if (sTemp.Length != 0)
                    {
                        //richTextBox2_KeyPress()和AcceptMessage()
                        //都将向richTextBox1写字符，可能访问有冲突，
                        //所以，需要多线程互斥
                        lock (this)
                        {
                            richTextBox1.Text = "服务器：" + sTemp + "\n" + richTextBox1.Text;
                        }
                    }
                }
                catch
                {
                   MessageBox.Show("无法与服务器通信。");
                }
            }
            //禁止当前Socket上的发送与接收
            socket.Shutdown(SocketShutdown.Both);
            //关闭Socket，并释放所有关联的资源
            socket.Close();
        }

        //创建与服务器的连接，侦听并显示聊天信息
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPP = new IPEndPoint(IPAddress.Parse(textBox1.Text), int.Parse(textBox2.Text));
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(IPP);
                if (socket.Connected)
                {
                    nStream = new NetworkStream(socket);
                    tReader = new StreamReader(nStream);
                    wReader = new StreamWriter(nStream);
                    tAcceptMsg = new Thread(new ThreadStart(this.AcceptMessage));
                    tAcceptMsg.Start();
                    bConnected = true;
                    button1.Enabled = false;
                    MessageBox.Show("与服务器成功建立连接，可以通信。");
                }
            }
            catch
            {
                MessageBox.Show("无法与服务器通信。");
            }
        }

        //发送信息
        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//按下的是回车键
            {
                if (bConnected)
                {
                    try
                    {
                        //richTextBox2_KeyPress()和AcceptMessage()
                        //都将向richTextBox1写字符，可能访问有冲突，
                        //所以，需要多线程互斥
                        lock (this)
                        {
                            richTextBox1.Text = "客户机：" + richTextBox2.Text + richTextBox1.Text;
                            //客户机聊天信息写入网络流，以便服务器接收
                            wReader.WriteLine(richTextBox2.Text);
                            //清理当前缓冲区数据，使所有缓冲数据写入基础设备
                            wReader.Flush();
                            //发送成功后，清空输入框并聚集之
                            richTextBox2.Text = "";
                            richTextBox2.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("与服务器连接断开。");
                    }
                }
                else
                {
                    MessageBox.Show("未与服务器建立连接，不能通信。");
                }
            }
        }

        //关闭窗体时断开socket连接，并终止线程（否则，VS调试程序将仍处于运行状态）
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                socket.Close();
                tAcceptMsg.Abort();
            }
            catch
            {}
        }

    }
}