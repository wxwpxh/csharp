using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TextCount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;//禁用此异常
        }
      
        private Thread thread1 = null;//创建用来计数的线程对象
        private Thread thread2 = null;
        private Thread thread3 = null;
        private void button1_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(counter1));//线程初始化
            thread2 = new Thread(new ThreadStart(counter2));
            thread3 = new Thread(new ThreadStart(counter3));
            thread1.Start();//启动线程
            thread2.Start();
            thread3.Start();
            button2.Enabled = true;
        } 
        //线程1（thread1）的计数方法
        private void counter1()
        {
            while (true)
            {
                int i;
                for (i = 0; i < 10000; i++)
                {
                    Random rnd = new Random();
                    int a = rnd.Next(0, 999);
                    textBox1.Text = a.ToString();
                }
                Thread.Sleep(500);//线程休眠0.5秒
            }
        }
        //线程2（thread2）的计数方法
        private void counter2()
        {
            while (true)
            {
                int i;
                for (i = 0; i < 10000; i++)
                {
                    Random rnd = new Random();
                    int a = rnd.Next(0, 999);
                    textBox2.Text = a.ToString();
                }
                Thread.Sleep(1000);//线程休眠1秒
            }
        }
        //线程3（thread3）的计数方法
        private void counter3()
        {
            while (true)
            {
                int i;
                for (i = 0; i < 10000; i++)
                {
                    Random rnd = new Random();
                    int a = rnd.Next(0, 999);
                    textBox3.Text = a.ToString();
                }
                Thread.Sleep(2000);//线程休眠2秒
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            thread1.Abort();//销毁线程
            thread2.Abort();
            thread3.Abort();
            button2.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
