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
using System.Net.Security;  


namespace PToP
{
    public partial class Form1 : Form
    {
        //定义委托  
        public delegate void InvokeDelegate();   
          
        public bool appRun = true;  
        private ClassListener Lie;  
        private ClassSender sen;  
        string Strs = "";  
  

        public Form1()
        {
            InitializeComponent();
        }

        //接收事件  
        void Lie_OnAddMessage(object sender, AddMessageEventArge e)  
        {  
            Strs = e.mess.ToString();  
            Invoke_Click(null, null);  
        }  
  
        //委托   
  
        private void Invoke_Click(object sender, EventArgs e)  
        {  
            textBox1.BeginInvoke(new InvokeDelegate(InvokeMethod));  
        }  
        public void InvokeMethod()  
        {  
            if (textBox1.Text == "")  
            {  
                textBox1.Text = Strs;  
            }  
            else  
            {  
                textBox1.Text = textBox1.Text + "/r/n" + Strs;  
            }  
        }  

        //连接目标计算机  

        private void button1_Click(object sender, EventArgs e)
        {
            try  
            {  
                //连接  
                Lie.listenerRun = false;  
                Lie.stop();  
            }  
            catch (NullReferenceException) { ;}  
            finally  
            {  
                Lie = new ClassListener();  
                Lie.OnAddMessage +=new EventHandler<AddMessageEventArge>(Lie_OnAddMessage);  
                Lie.StartListen();  
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }
        //发送聊天记录信息  
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")  
            {  
                MessageBox.Show("请输入目标主机的IP地址");  
            }  
            else if (richTextBox2.Text == "")  
            {  
                MessageBox.Show("不能发送空信息!");  
            }  
            else  
            {  
                IPAddress ipaddress = new System.Net.IPAddress(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].Address);

                if (richTextBox1.Text == "")  
                {
                    richTextBox1.Text = "<" + ipaddress.ToString() + "> " + richTextBox2.Text;  
                }  
                else  
                {
                    richTextBox1.Text = richTextBox1.Text + "/r/n" + "<" + ipaddress.ToString() + "> " + richTextBox2.Text;  
                }  
                sen = new ClassSender(textBox1.Text);
                sen.Send(richTextBox2.Text);  
            }  
        }
    }
}
