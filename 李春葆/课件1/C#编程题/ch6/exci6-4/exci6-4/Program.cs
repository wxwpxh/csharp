using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci6_4
{
    public class Student:IComparable 
    {
        private string name;
        private int eng, math, sum;
        public int psum
        {
            get { return sum; }
        }
        public void inscore()
        {
            Console.Write("姓名:");
            name = Console.ReadLine();
            Console.Write("英语:");
            eng = int.Parse(Console.ReadLine());
            Console.Write("数学:");
            math = int.Parse(Console.ReadLine());
            sum = eng + math;
        }
        public void display()
        {
            Console.WriteLine("\t{0}\t{1}\t{2}\t{3}", name, eng, math, sum);
        }
        public int CompareTo(object obj)    //实现接口方法
        {	
            Student s = (Student)obj;　　   //转换为Student实例
            if (psum < s.psum) return 1;
            else if (psum == s.psum) return 0;
            else return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            ArrayList myarr = new ArrayList();
            Student p;                  //定义对象引用
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("输入第{0}个学生数据:", i + 1);
                p = new Student();      //创建对象引用实例
                p.inscore();
                myarr.Add(p);
            }
            Console.WriteLine("排序前:");
            Console.WriteLine("\t姓名\t英语\t数学\t总分");
            i = 1;
            foreach (Student s in myarr)
            {
                Console.Write("序号{0}:", i++);
                s.display();
            }
            myarr.Sort();                      //按总分降序排序
            Console.WriteLine("排序后:");
            Console.WriteLine("\t姓名\t英语\t数学\t总分");
            i = 1;
            foreach (Student s in myarr)
            {
                Console.Write("第{0}名:", i++);
                s.display();
            }
        }
    }
}
