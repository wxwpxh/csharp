using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experment8
{
    public class Student
    {
        int no;         //学号
        string name;    //姓名
        int score;      //分数
        public Student(int no, string name, int score)
        {
            this.no = no;
            this.name = name;
            this.score = score;
        }
        public bool pass()
        {
            return score >= 60;
        }
        public void Dispstud()
        {
            Console.WriteLine("[{0},{1},{2}]",no,name,score);
        }
    }
    public class MyClass		//声明可枚举类
    {
        List<Student> list = new List<Student>();
        public MyClass()
        {
            list.Add(new Student(1, "王华", 90));
            list.Add(new Student(2, "李明", 80));
            list.Add(new Student(3, "程成", 58));
            list.Add(new Student(4, "许冰", 70));
            list.Add(new Student(5, "卢萍", 49));
        }      
        public IEnumerable<Student> passlist			//含yield return语句的属性
        {
            get
            {
                foreach(var s in list)
                    if (s.pass())
                        yield return s;
            }
        }
        public IEnumerable<Student> notpasslist			//含yield return语句的属性
        {
            get
            {
                foreach (var s in list)
                    if (!s.pass())
                        yield return s;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Console.WriteLine("成绩合格的学生:");
            foreach (Student item in obj.passlist)
                item.Dispstud();
            Console.WriteLine("成绩不合格的学生:");
            foreach (Student item in obj.notpasslist)
                item.Dispstud();
        }
    }
}
