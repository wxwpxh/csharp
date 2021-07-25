using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//下列控制台应用程序执行时，向单精度浮点变量x赋值3.14159326，查看输出结果
namespace ex2_05
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;					//定义变量x为单精度浮点类型
            x = 3.1415926f;				//若省略后缀f，则认为是double类型，发生错误
            Console.WriteLine(x);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
