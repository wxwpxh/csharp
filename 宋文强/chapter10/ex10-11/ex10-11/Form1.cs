using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在窗体上画出实心圆形和它的外接矩形
namespace ex10_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;								//获取Graphics对象
            Rectangle rect = new Rectangle(50, 10, 180, 180);		//定义矩形
            Pen pen1 = new Pen(Color.Black);						//定义画笔
            pen1.DashStyle = DashStyle.Dash;						//定义画线为虚线
            SolidBrush brush1 = new SolidBrush(Color.SpringGreen);	//定义实心笔刷
            g.FillEllipse(brush1, rect);		//用实心笔刷在外接矩形内部填充圆形
            g.DrawRectangle(pen1, rect);		//用虚线画出圆形的外接矩形

        }
    }
}
