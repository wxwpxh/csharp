using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*演示窗体事件的发生过程，程序中包含了6个事件过程。当窗体加载，执行一次鼠标单击操作并关闭窗体时，label1中记录了各事件依次发生的过程*/
namespace ex7_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text += "窗体加载事件发生\n\n";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text += "鼠标单击窗体事件发生\n\n";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text += "鼠标键按下事件发生\n\n";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text += "鼠标键释放事件发生\n\n";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            label1.Text += "窗体将要关闭\n\n";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("窗体已经关闭");
        }
    }
}
