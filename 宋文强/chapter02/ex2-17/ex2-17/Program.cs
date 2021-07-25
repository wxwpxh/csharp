using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 得到一元二次方程 ax2 + bx + c = 0 的根
                 
写成C#程序代码时应记为：
*/
namespace ex2_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 15; double b = 300;double c=400; 
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            Console.WriteLine("根x1={0},x2={1}", x1, x2);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
