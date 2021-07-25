using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//使用ListBox控件，创建用于选修课选择的Windows窗体应用程序（每人限选5门）
namespace ex7_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;	//允许一次选中多项
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int number = 0;
            foreach (string item in listBox1.SelectedItems)         //遍历SelectedItems集合
            {
                label1.Text += "*  " + item + "\n";                 //逐行输出每个被选中的项
                number++;
                if (number >= 5) break;                             //达到规定的门数，退出循环
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
