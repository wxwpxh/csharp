using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chapter6._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static  int Count = 0;//题目总数
        private int t=60;//测试时间为60秒
        public static  int right = 0;//正确的题目总数      
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = t.ToString();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            RandomNum();            
        }
        //自定义方法：产生1-100的随机数并在文本框中显示
        private void  RandomNum()
        {
            Random ran = new Random();
            int n1,n2;
            n1=ran.Next(1, 101);//产生一个加数
            n2 = ran.Next(1, 101);//产生一个加数
            textBox1.Text = n1.ToString();
            textBox2.Text =n2 .ToString();
            textBox3.Text = "";
            Count++;        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t <= 0)
            {
                timer1.Enabled = false;
                textBox3.Enabled = false;
                MessageBox.Show("时间到！");
                textBox3.Enabled = false;//不允许输入
                Form2 frm2 = new Form2();
                //以模式对话框的形式显示测试结果
                frm2.ShowDialog();
            }
            t = t - 1;
            label4.Text  = t.ToString();            
        }
        //当按下回车键时，表示确认输入结果
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            int sum;
            sum=int.Parse (textBox1 .Text )+int .Parse (textBox2 .Text );
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox3.Text  ==sum.ToString ())
                    right++;
                RandomNum();
            }
        }
        //用户自行结束测试
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = false;//不允许输入
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
        //测试程序的使用说明
        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        
       
    }
}
