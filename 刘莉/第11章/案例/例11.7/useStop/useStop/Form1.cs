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
namespace useStop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.tcpListener != null)
            {
                tcpListener.Stop();
            }
            else
            {
                MessageBox.Show("侦听器关闭失败！");
            }
        }
        int port ;
        TcpListener tcpListener ;
        private void Form1_Load(object sender, EventArgs e)
        {
            port = 13000;
            tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
        }
    }
}
