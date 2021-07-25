using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在窗体上添加一个图片框控件，然后分别创建窗体和图片框的Graphics对象，并分别调用GDI+的方法在相应的绘图表面上绘图、写字
namespace ex10_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SolidBrush mybrush = new SolidBrush(Color.Red);
        Font myfont = new Font("隶书", 36);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics mypic = pictureBox1.CreateGraphics();			//绘图对象为图片框
            mypic.DrawString("童趣", myfont, mybrush, 200, 0); 	//在图片框上书写文字
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(@"童趣.jpg");	//从指定路径图片文件创建Bitmap对象
            Graphics mybmp = Graphics.FromImage(bmp);	//从BitMap对象创建Graphics对象
            mybmp.DrawString("童趣", myfont, mybrush, 200, 0);//在BitMap对象上书写文字
            pictureBox1.Image = bmp;
        }
    }
}
