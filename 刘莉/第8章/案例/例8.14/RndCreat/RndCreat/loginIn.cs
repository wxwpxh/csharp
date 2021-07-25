using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RndCreat
{
    public partial class loginIn : Form
    {
        public loginIn()
        {
            InitializeComponent();
                     CheckForIllegalCrossThreadCalls = false;//禁用此异常
        }
        char[] allchar = new char[] { '0','1','2','3','4',
                '5','6','7','8','9','A','B','C','D','E','F','G',
                'H','I','J','K','L','M','N','O','P','Q','R','S',
                'T','U','V','W','X','Y','Z','a','b','c','d','e','f','g',
                'h','i','j','k','l','m','n','o','p','q','r','s',
                't','u','v','w','x','y','z' };
        //private Thread thread1 = null;//创建用来计数的线程对象
        //private Thread thread2 = null;
        //private Thread thread3 = null;
        //loginIn log = new loginIn();
        private void button1_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(new ThreadStart(backgroundWorker1_DoWork(sender, (DoWorkEventArgs)e)));//线程初始化
            //thread2 = new Thread(new ThreadStart(backgroundWorker2_DoWork(sender, (DoWorkEventArgs ) e));
            //thread3 = new Thread(new ThreadStart(backgroundWorker3_DoWork(sender, (DoWorkEventArgs ) e)));
            //thread1.Start();//启动线程
            //thread2.Start();
            //thread3.Start();
            //backgroundWorker1_DoWork(sender, (DoWorkEventArgs ) e);
            //backgroundWorker2_DoWork(sender, (DoWorkEventArgs)e);
            //backgroundWorker3_DoWork(sender, (DoWorkEventArgs)e);
            this.backgroundWorker1.RunWorkerAsync();
            this.backgroundWorker2.RunWorkerAsync();
            this.backgroundWorker3.RunWorkerAsync();
            button4.Enabled = true;
            button1.Enabled = false;
        }
        ////线程1（thread1）的计数方法
        //private void counter1()
        //{
        //    int i,j;
        //    Random rnd = new Random();          
        //    while (true)
        //    {
        //        for (i = 0; i < 10000; i++)
        //        {
        //            string checkstring = string .Empty ;
        //            for (j = 0; j < 4; j ++)
        //            {
        //                checkstring += allchar[rnd.Next(0, 62)];
        //            }
        //            label1.Text = checkstring;
        //        }
        //        Thread.Sleep(3000);//线程休眠3秒
        //    }
        //}
        ////线程2（thread2）的计数方法
        //private void counter2()
        //{
        //    int i, j;
        //    Random rnd = new Random();
        //    while (true)
        //    {
        //        for (i = 0; i < 10000; i++)
        //        {
        //            string checkstring = string.Empty;
        //            for (j = 0; j < 4; j++)
        //            {
        //                checkstring += allchar[rnd.Next(0, 62)];
        //            }
        //            label2.Text = checkstring;
        //        }
        //        Thread.Sleep(3000);//线程休眠3秒
        //    }
        //}
        ////线程3（thread3）的计数方法
        //private void counter3()
        //{
        //    int i, j;
        //    Random rnd = new Random();
        //    while (true)
        //    {
        //        for (i = 0; i < 10000; i++)
        //        {
        //            string checkstring = string.Empty;
        //            for (j = 0; j < 4; j++)
        //            {
        //                checkstring += allchar[rnd.Next(0, 62)];
        //            }
        //            label3.Text = checkstring;
        //        }
        //        Thread.Sleep(3000);//线程休眠3秒
        //    }
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            //thread1.Abort();//销毁线程
            //thread2.Abort();
            //thread3.Abort();
            this.backgroundWorker1.CancelAsync();
            this.backgroundWorker2.CancelAsync();
            this.backgroundWorker3.CancelAsync();
            MessageBox.Show("label1=" + label1.Text +
                "\r\nlabel2=" + label2.Text +
                "\r\nlabel3=" + label3.Text);
            button1.Enabled = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            if (textBox1.Text.ToString() == label1.Text.ToString() &&
                textBox2.Text.ToString() == label2.Text.ToString() &&
                textBox3.Text.ToString() == label3.Text.ToString())
            {
                MessageBox.Show("验证通过，可以进入下一页面");
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("验证末通过，请重新输入验证码" + "\r\n" +
                "label1=" + label1.Text +
                "\r\nlabel2=" + label2.Text +
                "\r\nlabel3=" + label3.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                button3.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            //MainForm  mfrm= new MainForm ();
            //mfrm.Show();
        }

        private void loginIn_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }
            private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
            {
                int i, j;
                Random rnd = new Random();
                while (true)
                {
                    for (i = 0; i < 10000; i++)
                    {
                        string checkstring = string.Empty;
                        for (j = 0; j < 4; j++)
                        {
                            checkstring += allchar[rnd.Next(0, 62)];
                        }
                        this.label1.Text = checkstring;
                    }
     //               Thread.Sleep(3000);//线程休眠3秒
                }
            }

            private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
            {
                int i, j;
                Random rnd = new Random();
                while (true)
                {
                    for (i = 0; i < 10000; i++)
                    {
                        string checkstring = string.Empty;
                        for (j = 0; j < 4; j++)
                        {
                            checkstring += allchar[rnd.Next(0, 62)];
                        }
                        this.label2.Text = checkstring;
                    }
        //            Thread.Sleep(3000);//线程休眠3秒
                }
            }

            private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
            {
                int i, j;
                Random rnd = new Random();
                while (true)
                {
                    for (i = 0; i < 10000; i++)
                    {
                        string checkstring = string.Empty;
                        for (j = 0; j < 4; j++)
                        {
                            checkstring += allchar[rnd.Next(0, 62)];
                        }
                        this.label3.Text = checkstring;
                    }
         //           Thread.Sleep(3000);//线程休眠3秒
                }
            }
    }
}
