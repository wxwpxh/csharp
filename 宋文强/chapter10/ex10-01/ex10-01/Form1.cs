using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在窗体上添加一个图片框控件，然后分别创建窗体和图片框的Graphics对象，并分别调用GDI+的方法在相应的绘图表面上绘图、写字
namespace ex10_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics mygraphic = this.CreateGraphics();		//与窗体关联的Graphics对象
            Graphics mypicture = pictureBox1.CreateGraphics();//与图片框关联的Graphics对象
            Pen mypen = new Pen(Color.Red);					//创建画笔
            SolidBrush mybrush = new SolidBrush(Color.Black);	//创建笔刷
            mygraphic.DrawEllipse(mypen, 10, 10, 100, 70);	//在窗体上画椭圆
            mygraphic.DrawString("绘图表面为窗体", this.Font, mybrush, 20, 120);
            mypicture.DrawEllipse(mypen, 10, 10, 70, 100);	//在图片框上画椭圆
            mypicture.DrawString("绘图表面为图片框", this.Font, mybrush, 20, 120);
        }
    }
}
