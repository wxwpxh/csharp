using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] allchar = new char[] { '0','1','2','3','4',
                '5','6','7','8','9','A','B','C','D','E','F','G',
                'H','I','J','K','L','M','N','O','P','Q','R','S',
                'T','U','V','W','X','Y','Z' };
        string checkstring = string.Empty;
        Random rnd = new Random();
        Graphics g ;                        // 创建Graphics对象
        Font font ;                         // 创建Font对象
        Brush brush ;                   // 创建Brush对象

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "abc" && textBox2.Text == "123"&&
                textBox3.Text == checkstring)
            {
                Form2 frm = new Form2();
                frm.Show();
            }
            else if (textBox1.Text != "abc")
            {
                MessageBox.Show("用户名不正确，请重新输入！");
                textBox1.Text = "";
            }
            else if (textBox2.Text != "123")
            {
                MessageBox.Show("密码不正确，请重新输入！");
                textBox2.Text = "";
            }
            else if (textBox3.Text != checkstring)
            { 
                MessageBox .Show ("验证码不正确，请重新输入！");
                textBox3.Text = "";
            }
        }
        private void CreateImage()
        {
            g = this.CreateGraphics();
            font = new Font("Arial Unicode MS", 18, FontStyle.Bold);
            brush = new SolidBrush(Color.Blue);
            for (int i = 0; i < 4; i++)
            {
                checkstring += allchar[rnd.Next(0, 36)];
            }
            g.Clear(this.BackColor);
            g.DrawString(checkstring, font, brush, 40, 160);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateImage();
        }
    }
}
