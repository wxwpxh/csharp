using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//演示在程序运行期间加载图片到图片框，并且通过手工操作实现的动画效果
namespace ex7_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void button1_Click(object sender, EventArgs e)	//图片加载
        {
            pictureBox1.BringToFront();     //把层叠在一起的图片框pictureBox1置于最顶层
            pictureBox1.Load(@"girl1.jpg");
            pictureBox2.Load(@"girl2.jpg");
        }
        private void button2_Click(object sender, EventArgs e)	//图片切换
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }

    }
}
