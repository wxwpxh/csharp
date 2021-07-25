using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace showLabel1
{
    public partial class thread1 : Form
    {
        public thread1()        // 构造函数
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//禁用此异常
        }
        private Thread threada;     // 创建用来计数的线程对象
        private void button1_Click(object sender, EventArgs e)
        {
            threada = new Thread(new ThreadStart(runner));
            threada.Start();
        }
        private void runner()       // 计数函数
        {
            for (int i = 0; i < 101; i++)
            {
                label1.Text = i.ToString();
                Thread.Sleep(500);
            }
        }
        private void thread1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
        }
        private void thread1_FormClosing(object sender, FormClosingEventArgs e)
        {       // 销毁线程
             if (threada.IsAlive)
            {
                threada.Abort();
            }
        }
    }
}
