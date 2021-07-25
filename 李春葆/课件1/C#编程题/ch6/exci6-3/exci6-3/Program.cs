using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci6_3
{
    public class Person        //人类
    {
        private int no;         //编号
        private string name;    //姓名
        public void input()
        {
            Console.Write("  编号:");
            no = int.Parse(Console.ReadLine());
            Console.Write("  姓名:");
            name = Console.ReadLine();
        }
        public void disp()
        {
            Console.WriteLine("  编号:{0}", no);
            Console.WriteLine("  姓名:{0}", name);
        }
    }
    public class Student : Person   //学生类
    {
        private string sclass;      //班号
        private int degree;         //成绩
        new public void input()
        {
            base.input();
            Console.Write("  班号:");
            sclass = Console.ReadLine();
            Console.Write("  成绩:");
            degree = int.Parse(Console.ReadLine());
        }
        new public void disp()
        {
            base.disp();
            Console.WriteLine("  班号:{0}", sclass);
            Console.WriteLine("  成绩:{0}", degree);
        }
    }
    public class Teacher : Person   //教师类
    {
        private string prof;        //职称
        private string depart;      //部门
        new public void input()
        {
            base.input();
            Console.Write("  职称:");
            prof = Console.ReadLine();
            Console.Write("  部门:");
            depart = Console.ReadLine();
        }
        new public void disp()
        {
            base.disp();
            Console.WriteLine("  职称:{0}", prof);
            Console.WriteLine("  部门:{0}", depart);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Teacher t1 = new Teacher();
            Console.WriteLine("输入一个学生数据:"); s1.input();
            Console.WriteLine("输入一个教师数据:"); t1.input();
            Console.WriteLine("显示一个学生数据:"); s1.disp();
            Console.WriteLine("显示一个教师数据:"); t1.disp();
        }
    }
}
