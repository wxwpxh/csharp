using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//利用键盘上的方向键移动窗体的位置
namespace ex7_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pointX, pointY, myWidth, myHeight;	//这几个变量必须在此处定义
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)           	//"←"的键位置码
                pointX -= 10;				//窗体左移
            else if (e.KeyValue == 38)      	//"↑"的键位置码
                pointY -= 10;				//窗体上移
            else if (e.KeyValue == 39)      	//"→"的键位置码
                pointX += 10;				//窗体右移
            else if (e.KeyValue == 40)      	//"↓"的键位置码
                pointY += 10;				//窗体下移
            this.SetBounds(pointX,pointY, myWidth, myHeight);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pointX = 100;                   //窗体初始位置的水平坐标
            pointY = 50;                    //窗体初始位置的垂直坐标
            myWidth = 300;                  //窗体的初始宽度
            myHeight = 180;                 //窗体的初始高度
            this.SetBounds(pointX, pointY, myWidth, myHeight);
            this.Text = "用方向键移动窗体";
        }

    }
}
