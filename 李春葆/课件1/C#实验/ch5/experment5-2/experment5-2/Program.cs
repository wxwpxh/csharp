using System;
using System.Collections.Generic;
using System.Text;

namespace experment5_2
{
    public delegate void EndExamType(DateTime endtime, Student stud);   //声明完成考试委托类型
    public delegate void StartExamType(DateTime starttime);             //声明开始考试委托类型
    public class Student                           //学生类
    {
        private string name;                //学生姓名
        public event EndExamType EndExam;   //定义完成考试事件
        public Student(string name)         //构造函数
        {
            this.name = name;
        }
        public string pname                 //学生姓名属性
        {
            get { return name; }

        }
        public void Testing(DateTime begintime) //学生开始考试事件调用的方法
        {
            Console.WriteLine("学生{0}在{1}时开始答题...", name, begintime);
        }
        public void HandIn()                //学生交卷引发完成考试事件
        {
            EndExam(DateTime.Now, this);
        }

    }
    class Teacher                           //教师类
    {
        public event StartExamType StartExam;
        public void NotifyBeginExam()
        {
            Console.WriteLine("教师宣布开始考试");
            StartExam(DateTime.Now);        //引发开始考试事件
        }
        public void Accept(DateTime accepttime, Student stud)
        {
            Console.WriteLine("  学生" + stud.pname + "完成考试,老师收卷");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Student[] s = new Student[5];
            s[0] = new Student("张军");
            s[1] = new Student("陈华");
            s[2] = new Student("王丽");
            s[3] = new Student("许源");
            s[4] = new Student("刘畅");
            foreach (Student st in s)
            {
                t.StartExam += new StartExamType(st.Testing); //给每个学生订阅教师的开始考试事件
                st.EndExam += new EndExamType(t.Accept);      //给教师订阅每个学生的完成答卷事件
            }
            t.NotifyBeginExam();    //教师宣布开始考试
            Console.WriteLine("经过一段时间...");
            s[1].HandIn();      //一学生完成答题交卷
            Console.WriteLine("经过一段时间...");
            s[2].HandIn();      //一学生完成答题交卷
            Console.WriteLine("经过一段时间...");
            s[4].HandIn();      //一学生完成答题交卷
            Console.WriteLine("经过一段时间...");
            s[0].HandIn();      //一学生完成答题交卷
            Console.WriteLine("经过一段时间...");
            s[3].HandIn();      //一学生完成答题交卷
        }
    }
}
