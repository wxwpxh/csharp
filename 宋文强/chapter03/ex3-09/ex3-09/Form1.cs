using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//根据在文本框内输入的百分制成绩score，转换成优、良、中、及格、不及格等五个等级，并在窗体上的标签内显示
namespace ex3_09
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
            string grade;
            score = double.Parse(textBox1.Text);
            if (score >= 90)
                grade = "优秀";
            else if (score >= 80)
                grade = "良好";
            else if (score >= 70)
                grade = "中等";
            else if (score >= 60)
                grade = "及格";
            else
                grade = "不及格";
            label2.Text = "学生成绩为" + grade;

        }
    }
}
