using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace showLabel2
{
    public partial class thread2 : Form
    {
        public thread2()        // 构造函数
        {
            InitializeComponent();
        }
        private Thread threadb;     // 定义线程
        delegate void set_Text(string s);    // 定义委托
        set_Text ST;     // 创建委托
        private void thread2_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            ST = new set_Text(set_labelText);   // 实例化
        }
        private void thread2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadb.IsAlive) //判断thread1是否存在，不能撤消一个不存在的线程，否则会引发异常
            {
                threadb.Abort(); //撤消thread1
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            threadb = new Thread(new ThreadStart(runner));
            threadb.Start();
        }
        private void set_labelText(string s)    // 主线程调用的函数
        {
            label1.Text = s;
        }
        private void runner()
        {
            for (int i = 0; i < 101; i++)
            {
                label1.Invoke(ST, new object[] { i.ToString() }); 
                // 通过调用委托，来改变lable1的值
                Thread.Sleep(1000);     // 线程休眠时间，单位是ms
            }
        }
    }
}
