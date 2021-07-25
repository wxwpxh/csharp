using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//调用DrawPolygon()和FillPolygon()方法在窗体上画出五角星
namespace ex10_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; 			//获取Graphics对象
            Pen pen1 = new Pen(Color.Yellow,3);	//创建黄颜色画笔
            Brush brush1 = new SolidBrush(Color.Red);
            Point[] star = new Point[10];		//创建point类型数组，用于存储多边形顶点
            for (int i = 0; i < 10; i += 2)		//计算五角星图形的各个顶点
            {
                double angle = Math.PI / 180;	//计算角度1°所对应的弧度值
                star[i].X = (int)(150 + 80 * Math.Cos(angle * 36 * (i + 3.5)));
                star[i].Y = (int)(90 + 80 * Math.Sin(angle * 36 * (i + 3.5)));
                star[i + 1].X = (int)(150 + 30 * Math.Cos(angle * 36 * (i + 4.5)));
                star[i + 1].Y = (int)(90 + 30 * Math.Sin(angle * 36 * (i + 4.5)));
            }
            g.FillPolygon(brush1, star);
            g.DrawPolygon(pen1, star);		//绘制多边形
        }
    }
}
