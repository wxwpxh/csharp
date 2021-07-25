using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//已知直角三角形的两个直角边x和y，编写控制台应用程序计算斜边w
namespace ex5_04
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, x, y;
            x = 9;
            y = 12;
            w = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)); //计算 
            Console.WriteLine("斜边的长度为{0}", w);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
