using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//根据在文本框内输入的百分制成绩score，利用switch语句转换成优、良、中、及格、不及格等五个等级，并在窗体上的标签内显示
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
            string grade;
            int score = int.Parse(textBox1.Text);
            switch (score / 10)
            {
                case 10:
                case 9: grade = "优秀";
                    break;
                case 8: grade = "良好";
                    break;
                case 7: grade = "中等";
                    break;
                case 6: grade = "及格";
                    break;
                default: grade = "不及格";
                    break;
            }
            label2.Text = "学生成绩为" + grade;



        }
    }
}
