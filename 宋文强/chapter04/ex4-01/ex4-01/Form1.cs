using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex4_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Person student1 = new Person();			//创建了Person类的第一个实例
            student1.name = "高山";					//为第一个实例student1的字段赋值
            student1.sex = "男";
            label1.Text += student1.sex + "同学" + student1.name + "说：朋友们好！\n\n";
            Person student2 = new Person();			//创建了Person类的第二个实例
            //Person student2 = student1;
            student2.name = "吕蒙";					//为第二个实例student2的字段赋值
            student2.sex = "女";
            label1.Text += student2.sex + "同学" + student2.name + "说：朋友们好！\n\n";
        }
    }
}
