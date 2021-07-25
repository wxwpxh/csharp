using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中，比较两个字符串的大小，判断它们是否相等，结果在标签控件label1中输出
namespace ex5_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str1, str2;
            str1 = "大熊猫团团";
            str2 = "大熊猫圆圆";
            int comp = str1.CompareTo(str2);
            if (comp == 1)
                label1.Text += str1 + "大于" + str2 + "\n";
            else if (comp == 0)
                label1.Text += str1 + "等于" + str2 + "\n";
            else
                label1.Text += str1 + "小于" + str2 + "\n";
            bool b1 = str1.Equals(str2);
            if (b1 == true)
                label1.Text += "二者相等\n";
            else
                label1.Text += "二者不相等\n";

        }
    }
}
