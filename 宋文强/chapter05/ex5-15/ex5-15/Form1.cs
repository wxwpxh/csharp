using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//利用AppendFormat()方法控制数据输出格式
namespace ex5_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            StringBuilder strb = new StringBuilder("张三丰五月份的工资总额是：");
            double pay = 2750;
            strb.AppendFormat("{0:C}元", pay);
            label1.Text = strb.ToString();

        }
    }
}
