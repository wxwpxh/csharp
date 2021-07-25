using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//在一个拥有“是”、“否”按钮组的消息框（图3-5）中，根据用户选择单击的按钮，决定是否结束程序运行
namespace ex3_07
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r1;						//创建DialogResult类的实例
            r1 = MessageBox.Show("处理完成，结束程序运行吗？", "结束",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r1 == DialogResult.Yes)				//如果选择了“是”按钮，则关闭程序
                this.Close();
            label1.Text = "程序继续运行";

        }
    }
}
