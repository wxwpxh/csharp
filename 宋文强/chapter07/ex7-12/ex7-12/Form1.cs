using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//在Windows窗体应用程序的列表框中选择SizeMode属性的取值，进而设置图片框中图片的显示方式
namespace ex7_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.SetBounds(10, 10, 200, 200);	//重新设置图片框的位置和大小
            switch (listBox1.Text)
            {
                case "自动大小(AutoSize)":			//自动改变图片框的大小
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                        break;
                    }
                case "图片居中(CenterImage)":			//使图片在图片框中居中显示
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                        break;
                    }
                case "常规显示(Normal)":				//使图片以图片框左上角为起点显示
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                        break;
                    }
                case "图片拉伸(StretchImage)":			//不能确保原图片宽高比不变
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                case "优化缩放(Zoom)":				//保持原图片宽高比不变
                    {
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    }
            }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SetBounds(10, 10, 200, 200);	//设置图片框在窗体上的位置和大小
            pictureBox1.ImageLocation = "Donald.jpg";	//窗体加载的同时加载图片

        }

    }
}
