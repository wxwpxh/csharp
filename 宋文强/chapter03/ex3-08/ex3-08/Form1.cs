using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//创建一个Windows窗体应用程序，根据用户在文本框中输入的分数值，判断学生的成绩是否及格，结果在标签控件中输出
namespace ex3_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score = 0;
            score = double.Parse(textBox1.Text);	//把文本框的Text属性内容显式转换成数值
            if (score >= 60)
                label2.Text = "学生成绩为及格";
            else
                label2.Text = "学生成绩为不及格";


        }
    }
}
