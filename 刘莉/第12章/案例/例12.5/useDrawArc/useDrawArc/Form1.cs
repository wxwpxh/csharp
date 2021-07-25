using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useDrawArc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;        // 实例化Graphics类
            Pen redPen = new Pen(Color.DarkRed,5);      // 实例化一个Pen类
            Rectangle rect = new Rectangle(30, 30, 220, 100);       // 实例化一个Rectangle类
            g.DrawArc(redPen , rect, 12, 220);      // 调用DrawArc类绘制一个圆弧
        }
    }
}
