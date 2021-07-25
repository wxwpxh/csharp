using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//编写控制台应用程序，利用对数换底公式计算 log2(32768)  (2为底数)
namespace ex5_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Log()方法应用举例——利用换底公式计算以2为底的对数
            double x = 32768, y;
            y = Math.Log(x) / Math.Log(2);
            Console.WriteLine("以2为底{0}的对数值={1}", x, y);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
