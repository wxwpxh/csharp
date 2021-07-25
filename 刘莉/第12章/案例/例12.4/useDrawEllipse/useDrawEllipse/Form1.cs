using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useDrawEllipse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;        // 创建Graphics对象
            Pen purplePen = new Pen(Color .Purple , 5);     // 创建Pen对象
            Rectangle rect = new Rectangle(30,30,220,100);  // 创建Rectangle对象
            g.DrawEllipse(purplePen, rect);     // 调用DrawEllipse方法绘制椭圆
        }
    }
}
