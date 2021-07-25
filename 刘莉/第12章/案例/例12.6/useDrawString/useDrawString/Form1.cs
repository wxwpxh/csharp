using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useDrawString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g ;                        // 创建Graphics对象
        Font font ;                         // 创建Font对象
        Brush brush ;                   // 创建Brush对象
        string fontString = "";        // 要显示的文本
        // 宋体，14号，蓝色，正常
        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            font = new Font("宋体", 14);
            brush = new SolidBrush(Color.Blue);
            fontString = "宋体，14号，蓝色，正常";
            g.DrawString(fontString , font, brush, 20, 10);
        }
        // 宋体，14号，红色，加粗
        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            fontString ="宋体，14号，红色，加粗";
            font = new Font("宋体",14,FontStyle.Bold);
            brush = new SolidBrush(Color.Red);
            g.DrawString(fontString, font, brush, 20,50);
        }
        // 隶书，16号，绿色，下划线
        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            fontString = "隶书，16号，绿色，下划线";
            font = new Font("隶书", 16, FontStyle.Underline);
            brush = new SolidBrush(Color.Green);
            PointF p = new PointF(20, 90);
            g.DrawString(fontString, font, brush, p);
        }
        // 黑体，20号，灰色，倾斜
        private void button4_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            fontString = "黑体，20号，灰色，倾斜";
            font = new Font("隶书", 20, FontStyle.Italic);
            brush = new SolidBrush(Color .Gray);
            PointF p = new PointF(20, 130);
            g.DrawString(fontString, font, brush, p);
        }
    }
}
