using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序的代码窗口中输入以下代码
namespace ex5_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str1;
            str1 = "Microsoft Visual Studio 2008";
            label1.Text += str1.ToLower() + "\n";		//全部转换成小写字母
            label1.Text += str1.ToUpper() + "\n";		//全部转换成大写字母

        }
    }
}
