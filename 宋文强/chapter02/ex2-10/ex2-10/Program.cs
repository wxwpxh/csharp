using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//计算圆面积的控制台应用程序
namespace ex2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double myarea, pi = 3.14159;			//定义了两个双精度浮点类型变量
            int radius = 8;						//定义了整型变量
            myarea = pi * radius * radius;		//整数类型与浮点类型的混合运算
            Console.WriteLine("圆的面积= {0}", myarea);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
