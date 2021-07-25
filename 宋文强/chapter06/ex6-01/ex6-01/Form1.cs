using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//程序运行后，单击窗体，在数组a[]中存放10个2位随机正整数，然后计算它们的累加和
namespace ex6_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "随机数：";
            Random rnd = new Random();			//声明随机数对象rnd
            int sum = 0; 						//用于保存累加和的变量赋初值为0
            int[] a = new int[10]; 				//定义数组并初始化
            for (int i = 0; i < 10; i++)			//循环结束的条件为 i<10 而不是 i<=10
            {
                a[i] = rnd.Next(10, 100);			//给每个数组元素赋予随机数值10~99
                sum += a[i];					//计算累加和
                label1.Text += a[i] + "  ";		//10个随机数在窗体上输出成一行
            }
            label1.Text += "\n\n累加和 = " + sum;	//空2行，然后显示输出累加和

        }
    }
}
