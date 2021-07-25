using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在窗体上显示输出一个由1位随机整数（0~9）构成的6×6矩阵，并在矩阵的下方显示出每行元素中的最大值
namespace ex6_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[,] a = new int[6, 6];				//用来存放矩阵元素的二维数组
            int[] m = new int[6];				//用来存放每行元素中最大值的一维数组
            for (int i = 0; i < 6; i++)
            {
                m[i] = 0;
                for (int j = 0; j < 6; j++)
                {
                    a[i, j] = rnd.Next(0, 10);		//用随机数0~9为二维数组的每个元素赋值
                    label1.Text += a[i, j] + "  ";
                    if (a[i, j] > m[i]) m[i] = a[i, j];//找出每行元素中的最大值
                }
                label1.Text += "\n";
            }
            for (int i = 0; i < 6; i++)			//显示输出每行元素中的最大值
            {
                label1.Text += "第" + i + "行的最大值=" + m[i] + "\n";
            }

        }
    }
}
