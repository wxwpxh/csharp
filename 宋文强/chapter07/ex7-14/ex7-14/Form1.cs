using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用滚动条控制窗体上标签控件中显示文字的大小，并且使标签控件始终保持在水平居中的位置
namespace ex7_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "学无止境";
            label1.Font = new Font("楷体_gb2312", 20, FontStyle.Bold);
            label1.ForeColor = Color.BlueViolet;
            int x = (this.Width - label1.Width) / 2;//标签控件在窗体上的水平位置
            int y = 50;							 //标签控件在窗体上的垂直位置
            Point mypoint = new Point(x, y);
            label1.Location = mypoint;              //标签保持在窗体上水平居中的位置
            hScrollBar1.Dock = DockStyle.Bottom;    //滚动条停靠在窗体底部
            hScrollBar1.Maximum = 80;				//限制最大字号为80
            hScrollBar1.Minimum = 8;				//限制最小字号为8
            hScrollBar1.Value = 20;
        }
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int myfontsize = hScrollBar1.Value;     //用滚动条的Value属性控制显示字号
            label1.Font = new Font("楷体_gb2312", myfontsize, FontStyle.Bold);
            int x = (this.Width - label1.Width) / 2;
            int y = 50;
            Point mypoint = new Point(x, y);
            label1.Location = mypoint;              //标签在窗体上保持水平居中的位置
        }

    }
}
