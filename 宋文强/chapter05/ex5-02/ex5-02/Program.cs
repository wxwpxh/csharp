using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//编写控制台应用程序，当var分别取正值和负值时，输出Math.Ceiling(var)和Math.Floor(var)的返回值
namespace ex5_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ceilling()和Floor()方法应用举例
            double x, y;
            x = Math.Ceiling(3.75);
            y = Math.Ceiling(-3.75);
            Console.WriteLine("Ceiling(3.75)={0}, Ceiling(-3.75)={1}", x, y);
            x = Math.Floor(3.75);
            y = Math.Floor(-3.75);
            Console.WriteLine("Floor(3.75)={0}, Floor(-3.75)={1}", x, y);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
