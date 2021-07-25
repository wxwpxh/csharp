using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 添加命名空间引用
using System.Collections.Generic;

namespace 例5._11
{
    public class Student : IComparable
     {// 学生类
        private string name; // 姓名
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // 年龄
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Student(string name, int age)
        {           
            this.name = name;
            this.age = age;
        }
        public void SayHi( )
        {
            Console.WriteLine("我叫{0}，今年：{1}", this.name, this.age);
        }       
        public int CompareTo(object other)
        {
            return this.Name.CompareTo(((Student)other).Name);
        }
    }
    public class Score
    {
        private int cprogram;		// 《c语言程序设计》成绩
        public int Cprogram
        {
            get { return cprogram; }
            set { cprogram = value; }
        }
        private int java; 		// 《JAVA程序设计》成绩
        public int Java
        {
            get { return java; }
            set { java = value; }
        }
        public Score(int C, int JAVA)
        {
            this.Cprogram = C;
            this.Java = JAVA;
        }
    }
    class Program
    {
        static void Main(string[ ] args)
        {
            Student stu1 = new Student("lisi", 20);
            Score s1 = new Score(70, 80);
            Student stu2 = new Student("wangwu", 19);
            Score s2 = new Score(80, 90);
            Student stu3 = new Student("bobo", 21);
            Score s3 = new Score(90, 100);
            SortedList<Student, Score>  students = new SortedList<Student, Score> ( );
            students.Add(stu1, s1);
            students.Add(stu2, s2);
            students.Add(stu3, s3);
            foreach (Student stu in students.Keys)
            {
                stu.SayHi( );
            }
            students.RemoveAt(2);
            Console.WriteLine("删除索引为2的元素后，集合中元素个数：" + students.Count);
            Console.WriteLine("--------索引访问----------");
            Console.WriteLine("姓名\t年龄\tC语言\tJAVA");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",students.Keys[i].Name, students.Keys[i].Age,students.Values[i].Cprogram, students.Values[i].Java);
            }
        }
}

    }

