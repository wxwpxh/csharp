using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;  
using System.Net;  
using System.Threading;  
using System.Windows.Forms;  


namespace PToP
{
    class ClassSender
    {
        private string obj;  
        public ClassSender(string str)  
        {  
            obj=str;  
        }  
        public void Send(string str)  
        {  
            try  
            {  
                TcpClient tcpc = new TcpClient(obj, 5656);  
                NetworkStream tcpstream = tcpc.GetStream();  
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(str);  
                tcpstream.Write(data, 0, data.Length);  
                tcpstream.Close();  
                tcpc.Close();  
            }  
            catch(Exception)  
            {  
                MessageBox.Show("连接被目标主机拒绝!");  
            }  
        }  
    }
}
