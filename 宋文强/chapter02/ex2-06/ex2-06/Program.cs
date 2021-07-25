using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//下面的控制台应用程序用于计算3的平方根，结果保存在双精度变量x中
namespace ex2_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = Math.Sqrt(3);			//计算平方根
            Console.WriteLine("3的平方根 = {0}", x);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
