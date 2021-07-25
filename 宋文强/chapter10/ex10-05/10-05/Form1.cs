using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//创建一个新的窗体，适当调整它的宽度和高度，然后在窗体上添加一个Label控件，并通过Click事件观察窗体大小与窗体工作区大小
namespace _10_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text += "窗体宽度：" + this.Width + "\n";
            label1.Text += "窗体高度：" + this.Height + "\n";
            label1.Text += "窗体工作区宽度：" + this.ClientRectangle.Width + "\n";
            label1.Text += "窗体工作区高度：" + this.ClientRectangle.Height;

        }
    }
}
