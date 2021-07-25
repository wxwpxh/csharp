using System;
using System.Collections.Generic;
using System.Text;

namespace experment5_1
{
    class Student               //学生类
    {
        int sno;                //学号
        string sname;           //姓名
        Course[] course;        //Course类对象数组
        int[] score;           //课程成绩数组
        double sgpa1;           //常见GPA值
        double sgpa2;           //标准GPA值
        public int psno         //psno属性可读可写
        {
            get
            { return sno; }
            set
            { sno = value; }
        }
        public string psname        //psname属性可读可写
        {
            get
            { return sname; }
            set
            { sname = value; }
        }
        public void setcourse(params Course[] course1)  //设置课程
        {
            course = new Course[course1.Length];
            for (int i = 0; i < course1.Length; i++)
                course[i] = course1[i];
        }
        public void setscore(int[] score1)  //设置分数
        {
            score = new int[score1.Length];
            for (int i = 0; i < score1.Length; i++)
                score[i] = score1[i];
        }
        public void computegpa()    //根据课程的学分以及学生成绩计算GPA
        {
            int i;
            double s, sumc = 0, sumgpa1 = 0, sumgpa2 = 0;
            for (i = 0; i < score.Length; i++)
            {
                if (score[i] >= 90)
                    s = 4.0;            //点数
                else if (score[i] >= 80)
                    s = 3.0;
                else if (score[i] >= 70)
                    s = 2.0;
                else if (score[i] >= 60)
                    s = 1.0;
                else
                    s = 0.0;
                sumgpa1 += course[i].pcredits * s;
                sumgpa2 += course[i].pcredits * score[i];
                sumc += course[i].pcredits;
            }
            sgpa1 = sumgpa1 / sumc;
            sgpa2 = sumgpa2 * 4 / sumc / 100;
        }
        public void dispstud()  //输出学生信息
        {
            Console.WriteLine("学号:{0}\t姓名:{1}", sno, sname);
            Console.WriteLine("   课程名\t学分\t分数");
            for (int i = 0; i < course.Length; i++)
                Console.WriteLine("   {0}\t{1}\t{2}", course[i].pcname, course[i].pcredits, score[i]);
        }
        public void dispgpa()   //输出GPA
        {
            Console.WriteLine("常见算法GPA={0:n},标准算法GPA={1:n}", sgpa1, sgpa2);
        }
    }
    class Course                            //课程类
    {
        string cname;    	                //课程名 
        int credits;      	                //课程学分
        public Course() { }
        public Course(string name, int xf)  //构造函数
        {
            cname = name;
            credits = xf;
        }
        public string pcname     	        //pcname属性，课程名可读可写
        {
            get
            { return cname; }
            set
            { cname = value; }
        }
        public int pcredits    		        //pcredits属性，课程学分可读可写
        {
            get
            { return credits; }
            set
            { credits = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Course[] course1 = new Course[] {new Course("课程1",4),new Course("课程2",3), 
                new Course("课程3",2),new Course("课程4",6),new Course("课程5",3)};
            int[] score1 = new int[] { 92, 80, 98, 70, 89 };
            Student s1 = new Student();
            s1.psno = 1; s1.psname = "王华";
            s1.setcourse(course1);
            s1.setscore(score1);
            s1.computegpa();
            s1.dispstud();
            s1.dispgpa();
        }
    }
}
