using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// 利用GetLength()方法分别测试数组a每个维的长度（即元素个数）
namespace ex6_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int[, ,] a = new int[10, 8, 6];						//创建三维数组对象a
            label1.Text += "第一维长度：" + a.GetLength(0) + "\n";
            label1.Text += "第二维长度：" + a.GetLength(1) + "\n";
            label1.Text += "第三维长度：" + a.GetLength(2) + "\n";

        }
    }
}
