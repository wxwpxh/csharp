using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// 添加命名空间引用
using System.Drawing.Drawing2D;
namespace useHatchBrush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;        // 实例化Graphics类
            // 实例化HatchBrush类
            HatchBrush hBrush1 = 
                new HatchBrush(HatchStyle.DiagonalCross, Color.Chocolate, Color.Red);
            HatchBrush hBrush2 = 
                new HatchBrush(HatchStyle.DashedHorizontal, Color.Green, Color.Black);
            HatchBrush hBrush3 = 
                new HatchBrush(HatchStyle.Weave, Color.BlueViolet, Color.Blue);
            // 阴影椭圆
            Rectangle rect = new Rectangle(20, 80, 100, 200);
            g.FillEllipse(hBrush1, rect );
            // 阴影扇形
            g.FillPie(hBrush2, 150, 30, 200, 240, 0.0f, -150.0f);
            // 阴影多边形
            PointF point1 = new PointF(100.0f, 400.0f);
            PointF point2 = new PointF(150.0f, 260.0f);
            PointF point3 = new PointF(200.0f, 140.0f);
            PointF point4 = new PointF(250.0f, 380.0f);
            PointF point5 = new PointF(350.0f, 260.0f);
            PointF[] curvePoints = { point1, point2, point3, point4, point5 };
            g.FillPolygon(hBrush3, curvePoints); 
        }
    }
}
