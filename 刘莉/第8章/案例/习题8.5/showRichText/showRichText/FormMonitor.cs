using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace showRichText
{
    public partial class FormMonitor : Form
    {
        public FormMonitor()
        {
            InitializeComponent();
        }
        public delegate void MyInvoke(char str1);
        //创建显示字符的线程对象
        private Thread thread1 = null;
        private Thread thread2 = null;
        private Thread thread3 = null;
       /*
        //显示字符
        private void ShowChar(char ch)
        {
            lock (this)
            {
                richTextBox1.Text += ch;
            }
        }
         */
        //代码修改
        //线程thread1调用的方法（显示字符★）
        private void thread1Show()
        {
            while (true)
            {
                Monitor.Enter(this);
                //在指定对象上获取排他锁
                try
                {
                  //  richTextBox1.Text += '★';
                    MyInvoke mi = new MyInvoke(UpdateForm);
                    this.Invoke(mi, new Object[] { '★' });
                }
                catch (ThreadAbortException)
                {
                    Monitor.Exit(this);
                    //释放指定对象上的排他锁
                    MessageBox.Show("线程终止异常");
                }
                Monitor.Exit(this);
                Thread.Sleep(60);
            }
        }
        public void UpdateForm(char ch)
        {
            richTextBox1.Text += ch;
        }
        //线程thread2调用的方法（显示字符▲）
        private void thread2Show()
        {
            while (true)
            {
                Monitor.Enter(this);
                //在指定对象上获取排他锁
                try
                {
                   // richTextBox1.Text += '▲';
                    MyInvoke mi = new MyInvoke(UpdateForm);
                    this.Invoke(mi, new Object[] { '▲' });
                }
                catch (ThreadAbortException)
                {
                    Monitor.Exit(this);
                    //释放指定对象上的排他锁
                    MessageBox.Show("线程终止异常");
                }
                Monitor.Exit(this); 
                Thread.Sleep(90);
            }
        }
        //线程thread3调用的方法（显示字符☆）
        private void thread3Show()
        {
            while (true)
            {
                Monitor.Enter(this);
                //在指定对象上获取排他锁
                try
                {
                   // richTextBox1.Text += '☆';
                    MyInvoke mi = new MyInvoke(UpdateForm);
                    this.Invoke(mi, new Object[] { '☆' });
                }
                catch (ThreadAbortException)
                {
                    Monitor.Exit(this);
                    //释放指定对象上的排他锁
                    MessageBox.Show("线程终止异常");
                }
               Monitor.Exit(this); 
               Thread.Sleep(30);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(thread1Show));
            thread2 = new Thread(new ThreadStart(thread2Show));
            thread3 = new Thread(new ThreadStart(thread3Show));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread1 != null) thread1.Abort();
            if (thread2 != null) thread2.Abort();
            if (thread3 != null) thread3.Abort();
        }
    }
}
