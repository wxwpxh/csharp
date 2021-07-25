using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experment9
{
    public partial class Form1 : Form
    {
        struct StudType
        {
            public int no;
            public string name;
            public string sex;
            public string sclass;
            public DateTime rq;
        }
        StudType[] stud = new StudType[10]; //定义一个结构类型的数组
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //给定义的数组赋初值
            stud[0].no = 1; stud[0].name = "王华"; stud[0].sex = "男";
            stud[0].rq = new DateTime(1980, 2, 10); stud[0].sclass = "99091";
            stud[1].no = 2; stud[1].name = "李强"; stud[1].sex = "男";
            stud[1].rq = new DateTime(1981, 10, 4); stud[1].sclass = "99101";
            stud[2].no = 3; stud[2].name = "张丽"; stud[2].sex = "女";
            stud[2].rq = new DateTime(1980, 3, 2); stud[2].sclass = "99091";
            stud[3].no = 4; stud[3].name = "汪洋"; stud[3].sex = "男";
            stud[3].rq = new DateTime(1980, 1, 5); stud[3].sclass = "99101";
            stud[4].no = 5; stud[4].name = "江华"; stud[4].sex = "男";
            stud[4].rq = new DateTime(1980, 3, 10); stud[4].sclass = "99091";
            stud[5].no = 6; stud[5].name = "李英"; stud[5].sex = "女";
            stud[5].rq = new DateTime(1980, 6, 2); stud[5].sclass = "99101";
            stud[6].no = 7; stud[6].name = "胡军"; stud[6].sex = "男";
            stud[6].rq = new DateTime(1981, 10, 9); stud[6].sclass = "99091";
            stud[7].no = 8; stud[7].name = "刘驰"; stud[7].sex = "女";
            stud[7].rq = new DateTime(1982, 5, 2); stud[7].sclass = "99101";
            stud[8].no = 9; stud[8].name = "宋仁"; stud[8].sex = "男";
            stud[8].rq = new DateTime(1980, 8, 3); stud[8].sclass = "99101";
            stud[9].no = 10; stud[9].name = "许兵"; stud[9].sex = "男";
            stud[9].rq = new DateTime(1980, 11, 8); stud[9].sclass = "99091";
            //将学号都添加到组合框中
            for (int i = 0; i < 10; i++)
                comboBox1.Items.Add(stud[i].no);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                int i = 0;   //查找指定学号的学生记录
                while (Convert.ToInt32(comboBox1.Text) != stud[i].no)
                    i = i + 1;
                if (i >= 10)
                    MessageBox.Show("没有该学号的记录");
                else
                {
                    textBox1.Text = stud[i].no.ToString();  //显示找到的学生记录
                    textBox2.Text = stud[i].name;
                    textBox3.Text = stud[i].sex;
                    textBox4.Text = stud[i].sclass;
                    textBox5.Text = stud[i].rq.ToString();
                }
            }
        }
    }
}
