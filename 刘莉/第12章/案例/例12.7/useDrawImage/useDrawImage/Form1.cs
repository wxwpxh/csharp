using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useDrawImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;         // 创建Graphics对象
        Image myImage = Image.FromFile("house.jpg");        // 创建图像对象
        // 图像大小为240*140
        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(this.BackColor );           // 清除整个绘图面，颜色为窗体背景色
            g.DrawImage(myImage ,30,30,240,140);
        }
        // 图像大小为300*200
        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.DrawImage(myImage, 10, 10, 300, 200);
        }
        // 图像大小为100*50
        private void button3_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.DrawImage(myImage, 90, 90, 100, 50);
        }
    }
}
