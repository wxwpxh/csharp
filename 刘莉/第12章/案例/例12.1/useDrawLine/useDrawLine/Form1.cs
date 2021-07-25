using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Drawing.Drawing2D;

namespace useDrawLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();     // 实例化一个Graphics类
            Pen redPen = new Pen(Color .Red ,3); // 实例化一个Pen类
            Point startPoint = new Point(10,10);      // 实例化一个Point类
            Point endPoint = new Point(100,200);
            g.DrawLine(redPen ,startPoint ,endPoint );  // 调用DrawLine方法绘制直线
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();     // 实例化一个Graphics类
            Pen bluePen = new Pen(Color.Blue , 5); // 实例化一个Pen类
           g.DrawLine(bluePen, 270,10,150,200);  // 调用DrawLine方法绘制直线
        }
    }
}
