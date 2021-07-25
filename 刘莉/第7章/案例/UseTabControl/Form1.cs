using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseTabControl
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        } 
        //当用户在“协议”选项卡中单击“同意”按钮
        private void button1_Click(object sender, EventArgs e)
        { 
            //切换到下一个选项卡
            this.tabControl1.SelectedIndex = this.tabControl1.SelectedIndex + 1;
        }
        //当用户在“协议”选项卡中单击“不同意”按钮
        private void button2_Click(object sender, EventArgs e)
        { 
            this.Close();//关闭当前窗体
        }
        //用户单击“注册”选项卡的“注册”按钮时
        private void button3_Click(object sender, EventArgs e)
        {
            //切换到下一个选项卡
            this.tabControl1.SelectedIndex = this.tabControl1.SelectedIndex + 1;
        }
        //用户单击“注册”选项卡的“取消”按钮时
        private void button4_Click(object sender, EventArgs e)
        {
            //切换到第一个选项卡
            this.tabControl1.SelectedIndex = 0;
        }
        //用户单击“完成”选项卡的“完成”按钮时
        private void button5_Click(object sender, EventArgs e)
        {//切换
            this.Close();//关闭当前窗体
        }
    }
}
