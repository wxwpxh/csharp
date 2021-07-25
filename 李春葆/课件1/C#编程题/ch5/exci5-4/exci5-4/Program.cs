using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci5_4
{
    public class Student
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
    }
    class Program
    {
        const int Max = 100;
        static void sort(int n, params Student[] p)		//采用冒泡排序法排序
        {
            int i, j;
            bool exchange;
            Student tmp;
            for (i = 0; i < n - 1; i++)
            {
                exchange = false;
                for (j = n - 2; j >= i; j--)
                    if (p[j + 1].psum > p[j].psum)
                    {
                        tmp = p[j + 1];		//p[j+1]<->p[j]
                        p[j + 1] = p[j];
                        p[j] = tmp;
                        exchange = true;
                    }
                if (exchange == false)
                    break;
            }
        }
        static void Main(string[] args)
        {
            int n, i;
            Student[] p = new Student[Max]; //定义对象引用数组
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)         //创建对象引用的实例
                p[i] = new Student();
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("输入第{0}个学生数据:", i + 1);
                p[i].inscore();
            }
            Console.WriteLine("排序前:");
            Console.WriteLine("\t姓名\t英语\t数学\t总分");
            for (i = 0; i < n; i++)
            {
                Console.Write("序号{0}:", i + 1);
                p[i].display();
            }
            sort(n, p);                      //按总降序排序
            Console.WriteLine("排序后:");
            Console.WriteLine("\t姓名\t英语\t数学\t总分");
            for (i = 0; i < n; i++)
            {
                Console.Write("第{0}名:", i + 1);
                p[i].display();
            }
        }
    }
}
