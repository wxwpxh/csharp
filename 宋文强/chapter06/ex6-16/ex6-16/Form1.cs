using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//编写程序，计算两个矩阵A与B相乘的结果，并在窗体上显示出结果矩阵C
namespace ex6_16
{
    public partial class Form1 : Form
    {
        int[,] a = { { 1, 0, 3 }, { 2, -1, 0 } };
        int[,] b = { { 3, -1 }, { -2, 4 }, { 0, 1 } };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)//在label3在输出矩阵相乘结果
        {
            int[,] c = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    int x = 0;
                    for (int k = 0; k < 3; k++)
                        x += a[i, k] * b[k, j];
                    c[i, j] = x;
                    if (x < 0)
                        label3.Text += c[i, j] + "  ";
                    else
                        label3.Text += " " + c[i, j] + "  ";
                }
                label3.Text += "\n";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "矩阵A的内容：\n";
            label2.Text = "矩阵B的内容：\n";
            label3.Text = "矩阵相乘的结果：\n";
            for (int i = 0; i < 2; i++)					//在label1中显示矩阵A的内容
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a[i, j] < 0)						//判断符号的目的只是为了对齐
                        label1.Text += a[i, j] + "  ";
                    else
                        label1.Text += " " + a[i, j] + "  ";
                }
                label1.Text += "\n";
            }
            for (int i = 0; i < 3; i++)					//在label2中显示矩阵B的内容
            {
                for (int j = 0; j < 2; j++)
                {
                    if (b[i, j] < 0) 						//判断符号的目的只是为了对齐
                        label2.Text += b[i, j] + "  ";
                    else
                        label2.Text += " " + b[i, j] + "  ";
                }
                label2.Text += "\n";
            }

        }
    }
}
