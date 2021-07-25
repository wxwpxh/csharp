using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useDrawRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics ;       // 实例化Graphics类
            Pen greenPen = new Pen(Color.Green, 6);     // 实例化Pen类
            Rectangle rect = new Rectangle(30, 10, 220, 180);       // 实例化Rectangle类
            g.DrawRectangle(greenPen, rect);        // 调用Graphics对象的DrawRectangle方法，绘制矩形
        }
    }
}
