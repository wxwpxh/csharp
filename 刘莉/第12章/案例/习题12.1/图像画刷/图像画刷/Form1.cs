using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 图像画刷
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;       // 创建一个Graphics类
        Bitmap bitmap;  // 工具文件名创建BMP对象

        // 利用纹理画刷填充图像
        private void button1_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            bitmap = new Bitmap(@"snow.jpg");
            TextureBrush brush = new TextureBrush(bitmap);
            g.FillRectangle(brush,0,0,385,289);
        }

        // 利用阴影画刷填充图形
        private void button2_Click(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            HatchBrush brush = new HatchBrush(HatchStyle.SolidDiamond, Color.RoyalBlue, Color.WhiteSmoke);
            g.FillEllipse(brush, 100, 300, 130, 130);
        }
    }
}
