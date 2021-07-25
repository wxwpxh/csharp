using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在Windows窗体应用程序中，用一个子串替换字符串中出现的所有另一个子串，结果在标签控件label1中输出。
namespace ex5_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            string str1 = "向参加XX会议讨论XX问题的代表致敬，祝你们把XX工作做得更好";
            string substr = "计划生育";
            label1.Text += str1.Replace("XX", substr) + "\n";
            substr = "群众体育";
            label1.Text += str1.Replace("XX", substr) + "\n";

        }
    }
}
