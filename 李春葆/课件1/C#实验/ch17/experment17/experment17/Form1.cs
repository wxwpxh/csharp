using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace experment17
{
    public partial class Form1 : Form
    {
        List<Student> students;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<Student>
            {
                new Student {no =120,name="Terry",scores = new List<int>{ 99, 81}},
                new Student {no =116,name = "Fadi",scores = new List<int>{ 99, 86, 90, 94}},
                new Student {no=117,name = "Hanying",scores = new List<int>{ 93, 92, 80, 87}},
                new Student {no=114,name = "Cesar",scores = new List<int>{ 97, 89, 85, 82}},
                new Student {no=115,name = "Debra",scores = new List<int>{ 35, 72, 91, 70}},
                new Student {no=118,name = "Hugo",scores = new List<int>{ 92, 90, 83, 78}},
                new Student {no=113,name = "Sven",scores = new List<int>{ 88, 94, 65, 91}},
                new Student {no=112,name = "Claire",scores = new List<int>{ 75, 84}},
                new Student {no=111,name = "Svetlana",scores = new List<int>{81, 60}},
                new Student {no=119,name = "Lance", scores = new List<int>{ 68, 79}},
                new Student {no=122,name = "Michael",scores = new List<int>{ 94}},
                new Student {no=121,name = "Eugene",scores = new List<int>{ 96, 80, 91}}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mydata = from st in students
                         orderby st.no
                         select new { no=st.no,name=st.name,avg=st.scores.Average() };
            textBox1.Text = "学号\t姓名\t平均分\r\n";
            foreach (var item in mydata)
                textBox1.Text += item.no.ToString() + "\t" + item.name + "\t" + item.avg.ToString() + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mydata = from st in students
                         orderby st.no
                         where st.scores.Average()>80
                         select new { no = st.no, name = st.name, avg = st.scores.Average() };
            textBox1.Text = "学号\t姓名\t平均分\r\n";
            foreach (var item in mydata)
                textBox1.Text += item.no.ToString() + "\t" + item.name + "\t" + item.avg.ToString() + "\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mydata = from st in students
                         orderby st.scores.Count() descending
                         select new { no = st.no, name = st.name, num = st.scores.Count() };
            textBox1.Text = "学号\t姓名\t选课数\r\n";
            foreach (var item in mydata)
                textBox1.Text += item.no.ToString() + "\t" + item.name + "\t" + item.num.ToString() + "\r\n";
        }
    }
    class Student                           //学生类
    {
        public int no { get; set; }         //学号属性
        public string name { get; set; }    //姓名属性
        public List<int> scores;            //成绩表
    }
}
