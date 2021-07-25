using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// 在窗体上添加“红”、“绿”、“蓝”三个水平滚动条，把它们的Maximum属性均设置为255，分别用来控制一个颜色分量，调整图片框的背景色。
namespace ex10_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r, g, b;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            r = hScrollBar1.Value;
            pictureBox1.BackColor = Color.FromArgb(r, g, b);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            g = hScrollBar2.Value;
            pictureBox1.BackColor = Color.FromArgb(r, g, b);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            b = hScrollBar3.Value;
            pictureBox1.BackColor = Color.FromArgb(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Tomato;
        }
    }
}
