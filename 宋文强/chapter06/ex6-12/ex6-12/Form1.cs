using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//利用Array.Copy()方法，把数组a中的部分元素复制到数组b中的指定区域内
namespace ex6_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int[] a = { 1, 3, 5, 7, 9 };
            int[] b = new int[10];
            Array.Copy(a, 2, b, 4, 3);
            label1.Text = "源数组内容：\n";
            for (int i = 0; i < 5; i++)
                label1.Text += a[i] + " ";
            label1.Text += "\n\n目标数组内容：\n";
            for (int i = 0; i < 10; i++)
                label1.Text += b[i] + " ";

        }
    }
}
