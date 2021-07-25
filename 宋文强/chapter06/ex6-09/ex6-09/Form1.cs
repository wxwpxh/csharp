using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//利用CopyTo()方法，将数组a复制到数组b，然后修改数组b的内容，查看对数组a是否产生影响
namespace ex6_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "数组 b 各元素的值：\n";
            int[] a = { 1, 3, 5, 7, 9 };
            int[] b = new int[10];
            //a.CopyTo(b, 3);					//利用CopyTo()方法复制数组
            b = a;						//利用数组对象直接赋值方法复制数组
            //b = (int[])a.Clone();		//利用Clone()方法复制数组
            for (int i = b.GetLowerBound(0); i <= b.GetUpperBound(0); i++)
            {
                label1.Text += b[i] + "  ";
            }
            label1.Text += "\n\n数组 b 各元素加 5 以后的值：\n";
            for (int i = b.GetLowerBound(0); i <= b.GetUpperBound(0); i++)
            {
                b[i] += 5;
                label1.Text += b[i] + "  ";
            }
            label1.Text += "\n\n数组 a 各元素的值：\n";
            for (int i = a.GetLowerBound(0); i <= a.GetUpperBound(0); i++)
                label1.Text += a[i] + "  ";

        }
    }
}
