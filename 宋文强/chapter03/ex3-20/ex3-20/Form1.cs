using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
 * 编写Windows窗体应用程序，单击窗体，根据给定的整数n，生成一个n×n的单位矩阵（即主对角线上的元素值均为1，其余元素值均为0的矩阵），并在窗体上显示输出
 */
namespace ex3_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int n = 7; 
            for (int i = 1; i <= n; i++)				//输出n行
            {
                for (int j = 1; j <= n; j++)			//在同一行上输出n个元素的值
                {
                    if (i == j) label1.Text += " 1 "; else label1.Text += " 0 ";
                }
                label1.Text += "\n";    				//换行
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
