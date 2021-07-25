using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;  
using System.Threading;  
using System.Net.Sockets;
using System.Windows.Forms;
namespace PToP
{
    public class AddMessageEventArge : EventArgs  
    {  
        public string mess; //定义一个全局变量  
    }  

    class ClassListener
    {
        private Thread th;  
        private TcpListener tcp1;  
        public bool listenerRun = true;  
        public event EventHandler<AddMessageEventArge> OnAddMessage;  
        //启动线程开始监听  
        public void StartListen()  
        {  
            th = new Thread(new ThreadStart(Listen));  
            th.Start();  
        }  
        //停止监听  
        public void stop()  
        {  
            tcp1.Stop();  
            th.Abort();  
        }  
        public void Listen()  
        {  
            try  
            {  
                IPAddress addr = new IPAddress(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].Address);  
                IPEndPoint iplocalendpoint = new IPEndPoint(addr, 5656);  
                tcp1 = new TcpListener(iplocalendpoint);  
                tcp1.Start();  
                while (listenerRun)  
                {  
                    Socket s = tcp1.AcceptSocket();  
                    string remote = s.RemoteEndPoint.ToString();  
                    Byte[] stream = new Byte[512];  
                    int i = s.Receive(stream);  
                    string msg = "<" + remote + ">" + System.Text.Encoding.UTF8.GetString(stream);  
                     
                    AddMessageEventArge arg = new AddMessageEventArge();  
                    arg.mess = msg;  
                    OnAddMessage(this, arg);  
                }  
            }  
            catch(Exception ex)  
            {  
                MessageBox.Show(ex.ToString());  
            }  
        }  
    }
}
