using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//创建一个用来输入学生个人基本情况的用户界面，编写程序检验在各文本框中输入的文本信息是否合法。
namespace ex7_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 2)			//如果姓名不足2个字则报告出错
                label7.Text = "姓名填写不完整";
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {										//如果性别不为“男”或“女”则报告出错
            if (textBox2.Text == "男" || textBox2.Text == "女")
                label7.Text = "";
            else
                label7.Text = "性别填写错误！";
        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {										//如果“年龄”范围不合理则报告出错
            if (textBox3.Text.Length > 0)
            {
                int age = int.Parse(textBox3.Text);
                if (age < 16) label7.Text = "这一位是少年大学生吗？";
                if (age > 35) label7.Text = age + "岁了才读本科，是不是年龄填错了？";
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {										//如果“年龄”栏输入非数字则拒绝接受
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;				//拒绝接受键入的字符
        }
        private void textBox5_Validated(object sender, EventArgs e)
        {										//如果手机号码长度不足11位则报告出错
            if (textBox5.Text.Length != 11) label7.Text = "手机号码应为11位";
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {										//如果“手机号码”栏输入非数字则拒绝接受
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

    }
}
