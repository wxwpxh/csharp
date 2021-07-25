using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//用一个随机2位整数序列为数组a各元素赋值，然后利用Sort()方法将其排序，并利用Reverse()方法将排序后的数组元素逆向排列
namespace ex6_13
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
            int[] a = new int[10];
            label1.Text = "排序前：\n";
            for (int i = 0; i < 10; i++)			//生成随机数序列并保存到数组a
            {
                a[i] = rnd.Next(10, 99);
                label1.Text += a[i] + "  ";
            }
            Array.Sort(a);						//对数组a进行排序
            label1.Text += "\n\n排序后：\n";
            for (int i = 0; i < 10; i++)
                label1.Text += a[i] + "  ";
            Array.Reverse(a);					//对数组a进行逆向排序
            label1.Text += "\n\n逆序排列：\n";
            for (int i = 0; i < 10; i++)
                label1.Text += a[i] + "  ";

        }
    }
}
