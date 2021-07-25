using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//调用DrawRectangle()和FillRectangle()方法在窗体上画出矩形
namespace ex10_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(20, 20, 250, 120);	//定义矩形
            Pen pen1 = new Pen(Color.Black, 3);					//定义宽度为3的画笔
            HatchBrush brush1 = new HatchBrush(HatchStyle.Cross, Color.Blue, Color.White);
            g.FillRectangle(brush1, rect);						//用图案笔刷填充矩形
            g.DrawRectangle(pen1, rect);						//用画笔绘制矩形轮廓

        }
    }
}
