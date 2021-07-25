using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//创建一个名为Student的结构，并且对它的成员执行读写操作
namespace ex2_19
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

        struct Student		//声明结构
        {
            public string name;
            public string sex;
            public uint age;
            public string phone;
            public uint score;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Student student1;			//创建Student类型的一个实例
            student1.name = "田一妮";
            student1.sex = "女";
            student1.age = 19;
            student1.phone = "68752220";
            student1.score = 100;
            label1.Text += "学生姓名：" + student1.name + "\n";
            label1.Text += "学生性别：" + student1.sex + "\n";
            label1.Text += "学生年龄：" + student1.age + "\n";
            label1.Text += "电话号码：" + student1.phone + "\n";
            label1.Text += "学科成绩：" + student1.score + "\n";

        }

    }
}
