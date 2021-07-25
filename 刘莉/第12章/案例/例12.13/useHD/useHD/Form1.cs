using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace useHD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 灰度化图像
        private void button1_Click(object sender, EventArgs e)
        {
            Color c = new Color();
            //把图片框1中的图片给一个Bitmap类型
            Bitmap b = new Bitmap(pictureBox1.Image);
            Bitmap b1 = new Bitmap(pictureBox1.Image);
            int rr, gg, bb, cc;
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                for (int j = 0; j < pictureBox1.Height; j++)
                {
                    c = b.GetPixel(i, j);       // 获取指定像素的颜色
                    // 获取指定像素的R、G、B值
                    rr = c.R;
                    gg = c.G;
                    bb = c.B;
                    // 取得三基色R、G、B，求其和的平均值
                    cc = (int)((rr + gg + bb) / 3);
                    if (cc < 0) cc = 0;
                    if (cc > 255) cc = 255;
                    //用FromArgb把整型转换成颜色值  
                    Color c1 = Color.FromArgb(cc, cc, cc);
                    b1.SetPixel(i, j, c1); 
                }
            }
            pictureBox2.Refresh();          // 刷新
            pictureBox2.Image = b1;      // 图片赋给图片框2
        }
    }
}
