using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//创建一个表现“月亮围绕地球旋转”动画效果的应用程序。
namespace ex7_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double degree = Math.PI / 180, angle = 0, r = 120;
        Point p = new Point(0, 0);
        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;				//旋转开始或暂停
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            p.X = (int)(r * (1 + Math.Cos(angle * degree)));
            p.Y = (int)(r * (1 + Math.Sin(angle * degree)));
            pictureBox2.Location = p;						//窗体加载时“月亮”的初始定位
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            p.X = (int)(r * (1 + Math.Cos(angle * degree)));//计算“月亮”的水平位置
            p.Y = (int)(r * (1 + Math.Sin(angle * degree)));//计算“月亮”的垂直位置
            pictureBox2.Location = p;						//将“月亮”移动到新的位置
            angle += 5;									//修正角度
            if (angle == 360) angle = 0;					//若已旋转一周，则重新开始
        }  

    }
}
