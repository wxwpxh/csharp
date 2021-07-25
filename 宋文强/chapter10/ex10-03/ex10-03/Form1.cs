using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在窗体上添加一个图片框控件，然后分别创建窗体和图片框的Graphics对象，并分别调用GDI+的方法在相应的绘图表面上绘图、写字
namespace ex10_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;					//获取Graphics对象
            Bitmap bmp = new Bitmap(@"白衣天使.jpg");	//获取Bitmap对象
            g.DrawImage(bmp, this.ClientRectangle);		//把图片填充到窗体工作区内
        }
    }
}
