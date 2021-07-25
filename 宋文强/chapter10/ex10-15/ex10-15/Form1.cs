using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//把“江山如此多娇”的文字轮廓作为图形，连同其他线条和形状一起，添加到图形路径中，然后绘制在窗体上
namespace ex10_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;			        		//定义绘图表面为窗体
            GraphicsPath mypath = new GraphicsPath();		//创建图形路径对象
            Pen mypen = new Pen(Color.Black);				//定义画笔
            FontFamily ff = new FontFamily("华文行楷");		//定义字体
            FontStyle fs = FontStyle.Bold;				//定义字形
            Point p0 = new Point(30, 30);               	//圆形的中心点
            Point p1 = new Point(0, 0);                 	//“阳光”的内端点
            Point p2 = new Point(0, 0);                 	//“阳光”的外端点
            for (int i = 0; i < 8; i++)					//绘出“阳光”
            {
                p1.X = (int)(p0.X + 20 * Math.Cos(Math.PI / 180 * i * 45));
                p1.Y = (int)(p0.Y + 20 * Math.Sin(Math.PI / 180 * i * 45));
                p2.X = (int)(p0.X + 30 * Math.Cos(Math.PI / 180 * i * 45));
                p2.Y = (int)(p0.Y + 30 * Math.Sin(Math.PI / 180 * i * 45));
                mypath.AddLine(p1, p2);                 	//在图形路径中添加直线
                mypath.AddEllipse(15, 15, 30, 30);      	//在图形路径中添加圆形
            }
            mypath.AddString("江山如此多娇", ff, (int)fs, 80, new Point(10, 50),new StringFormat());
            g.DrawPath(mypen, mypath);					//在窗体上绘制图形路径

        }
    }
}
