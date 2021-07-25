using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exci9
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("北京");
            comboBox1.Items.Add("上海");
            comboBox1.Items.Add("天津");
            comboBox1.Items.Add("广州");
            comboBox1.Items.Add("武汉");
            comboBox1.Items.Add("沈阳");
            comboBox1.Items.Add("合肥");
            comboBox1.Items.Add("长沙");
            comboBox1.Items.Add("重庆");
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)   //按Enter键后判断
            {
                if (comboBox1.Items.Contains(comboBox1.Text))
                    label2.Text = "你的输入已在组合框！";
                else
                {
                    comboBox1.Items.Add(comboBox1.Text);
                    label2.Text = "你的输入新项已添加到组合框中！";
                }
            }
        }
    }
}
