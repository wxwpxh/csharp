using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在文本框中输入年月，计算出指定月份的最后一天，在标签控件label1中输出
namespace ex5_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(textBox1.Text);
            int thismonth = DateTime.DaysInMonth(dt1.Year, dt1.Month);
            label1.Text = string.Format("{0:y}的最后一天是{1}日", dt1, thismonth);
        }

    }
}
