using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//使用CheckedListBox控件，创建用于选修课选择的Windows窗体应用程序
namespace ex7_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;    	//第一次单击复选框时即改变其状态
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int number = 0;
            foreach (string item in checkedListBox1.CheckedItems)
            {
                label1.Text += "*  " + item + "\n"; 	//逐行输出每个被选中的项
                number++;
                if (number >= 5) break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
