using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ex4_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student Stu1 = new Student("刘飞翔", "男", 25, "北京");
            Student Stu2 = new Student("王虹桥", "女", 26, "上海");
            Student Stu3 = new Student("杨柳青", "男", 22, "陕西");
            label1.Text = "学生总数：" + Student.getStudentNumber().ToString() + "\n";
            label1.Text += Stu1.getStudentInfo();
            label1.Text += Stu2.getStudentInfo();
            label1.Text += Stu3.getStudentInfo();
        }
    }
    public class Student
    {
        private int ID;
        private int IDBase = 20080000;
        public static int StudentNumber;
        public string Name;
        public string Sex;
        public int Age;
        public string Home;

        public Student(string name, string sex, int age, string home)
        {
            StudentNumber++;                    //每创建一个Student类的实例，自动加1
            this.ID = IDBase + StudentNumber;
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
            this.Home = home;
        }
        public string getStudentInfo()
        {
            String Info = "";
            Info += "学号:" + ID.ToString() + "  ";
            Info += "姓名:" + Name + "  ";
            Info += "性别:" + Sex + "  ";
            Info += "年龄:" + Age.ToString() + "  ";
            Info += "籍贯:" + Home + "\n";
            return Info;
        }
        public static int getStudentNumber()
        {
            return StudentNumber;
        }
    }
}
