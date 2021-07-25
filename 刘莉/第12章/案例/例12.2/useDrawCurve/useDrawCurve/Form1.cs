using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useDrawCurve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;        // 实例化一个Graphics类
            Pen pen1 = new Pen(Color.Blue, 3);// 实例化一个Pen类
            // 实例化Point有序对
            Point[] points1 =
            {
                new Point (20,190),
                new Point (60,50),
                new Point (100,180),
                new Point (140,60),
                new Point (180,170),
                new Point (220,70),
                new Point (260,160)
            };
            // 绘制一条弯曲度为0.5的开口曲线
            g.DrawCurve(pen1,points1 );
            Pen pen2 = new Pen(Color.Red, 3);
            Point[] points2 = 
            {
                 new Point (40,370),
                new Point (80,230),
                new Point (120,360),
                new Point (160,240),
                new Point (200,350),
                new Point (240,250),
                new Point (280,340)
            };
            // 绘制一个弯曲度为0.9的封闭曲线
            g.DrawClosedCurve(pen2, points2,
                0.9f, System.Drawing.Drawing2D.FillMode .Winding);
        }
    }
}
