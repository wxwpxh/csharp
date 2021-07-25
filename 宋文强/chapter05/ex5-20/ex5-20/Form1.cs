using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//查看分别以系统时间为种子和以指定值为种子的随机数序列
namespace ex5_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n;
        private void Form1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();			//以系统时间为种子的Random对象
            Random rnd2 = new Random(2008);		//以2008为种子的Random对象
            n++;
            label1.Text += "\n\n第" + n + "次：\n";
            label1.Text += "以系统时间为种子的随机数序列：\n";
            for (int i = 0; i < 10; i++)
                label1.Text += rnd1.Next(10, 99) + " ";
            label1.Text += "\n以2008为种子的随机数序列：\n";
            for (int i = 0; i < 10; i++)
                label1.Text += rnd2.Next(10, 99) + " ";

        }
    }
}
