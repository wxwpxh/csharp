using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用Graphics对象的DrawCurve()方法，以2°为间隔，在窗体上绘制2个周期的正弦曲线
namespace ex10_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;			//获取Graphics对象
            PointF[] pt = new PointF[720];		//定义点数组
            Pen pen = new Pen(Color.Black);		//定义画笔
            for (int i = 0; i < 720; i++)		//计算获得曲线上每个点的坐标
            {
                pt[i].X = i / 2;
                pt[i].Y = (float)(60 - 50 * Math.Sin(Math.PI / 180 * i));
            }
            g.DrawLine(pen, 0, 60, 400, 60);		//绘制一条表示数轴的直线
            g.DrawCurve(pen, pt);				//绘制基数样条构成的正弦曲线

        }
    }
}
