using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useSolidBrush
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
            Graphics g = e.Graphics;        // 创建Graphics类
            SolidBrush sdBrush1 = new SolidBrush(Color.Red);        // 创建Brush类
            SolidBrush sdBrush2 = new SolidBrush(Color.Green);
             // 红色椭圆
            g.FillEllipse(sdBrush1, 20, 40, 60, 70);
             // 绿色矩形
            Rectangle rect = new Rectangle(20, 150, 200, 100);
            g.FillRectangle(sdBrush2, rect);
        }
    }
}
