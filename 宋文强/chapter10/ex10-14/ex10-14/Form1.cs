using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在窗体上绘制由2段贝塞尔曲线构成的连续曲线
namespace ex10_14
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
            Pen pen = new Pen(Color.Black);
            Point[] points ={ new Point(10, 70), new Point(50, 0), new Point(90, 180), new Point(120, 70), 
                          new Point(180, -20), new Point(210, 180),	new Point(250, 70)};			//2段贝塞尔曲线由7个点组成
            g.DrawBeziers(pen, points);

        }
    }
}
