using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//利用存储在数组中的学生籍贯和人数，在窗体上画出反映学生地区分布情况的圆饼图
namespace ex10_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;							   //获取Graphics对象
            Rectangle rect = new Rectangle(50, 10, 180, 180);	   //定义画扇形图的矩形
            Rectangle r = new Rectangle(10, 150, 10, 10);           //定义画图例的矩形
            Point p = new Point(30, 150);                           //定义写图例文字的位置
            string[] province = { "湖北", "重庆", "陕西", "黑龙江" };//学生籍贯
            float[] student = { 6, 2, 5, 7 };                        //不同籍贯的学生人数
            float start = 0;                                        //起始角度
            Random rnd = new Random();
            SolidBrush brush2 = new SolidBrush(Color.Black);        //写图例文件用的笔刷
            for (int i = 0; i < student.Length; i++)
            {												   //得到一种随机的颜色
                Color cc = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                SolidBrush brush1 = new SolidBrush(cc);             //得到一种笔刷颜色
                float sweep = student[i] * 18;                      //延伸角度
                g.FillPie(brush1, rect, start, sweep);              //画出一个扇形图
                g.FillRectangle(brush1, r);                         //画出图例
                g.DrawString(province[i], this.Font, brush2, p);    //写出图例文字
                start += sweep;             //把当前扇形的结束角度作为下一个扇形的起始角度
                r.Y += 15;                                          //下一个图例的位置
                p.Y += 15;                                          //下一行图例文字的位置
            }

        }
    }
}
