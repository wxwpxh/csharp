using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 例6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //确定按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //验证密码是否为“123456”
            if (txtMM.Text   == "123456")
            {
                //label3设为可见状态，提示“登录成功”
                label3.Text = "登录成功！";
                label3.Visible = true;
                //是，显示文本编辑器窗口
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else
            {
                //密码不正确，提示“密码错误，请重新输入”
                label3.Visible = true;
                label3.Text = "密码错误，请重新输入！";
                //焦点移到“密码”文本框，并清空“密码”文本框
                txtMM.Focus();
                txtMM.Clear();
            }          
        }
        //"取消"按钮
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();//关闭“登录”窗口
        }
    }
}
