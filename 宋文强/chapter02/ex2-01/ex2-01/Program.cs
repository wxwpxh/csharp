using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//在控制台应用程序中使用无符号整数类型，企图用来保存负数时出现的错误
namespace ex2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort a, b, c;			//定义了3个无符号短整型变量
            a = 8;
            b = 6;
            c = b - a;				//表达式的值为负，无法向变量c赋值
            Console.WriteLine(c);

        }
    }
}
