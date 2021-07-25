using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用OnPaint()方法，实现窗体加载后自动显示图片的功能。
namespace ex10_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);//这个语句是开发环境自动生成的，必须保留
            Graphics g = e.Graphics;
            Bitmap bmp = new Bitmap(@"夜思.jpg");
            g.DrawImage(bmp, 0, 0);

        }
    }
}
