using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * 变量被定义之后，还必须对它进行初始化，才能在程序中被引用，否则编译时就会报告出错
 */
namespace ex2_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            c = a + b;
            Console.WriteLine(c);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
