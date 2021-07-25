using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// 在控制台应用程序中使用无符号短整数类型，企图存储的数值过大而导致的溢出错误
namespace ex2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            short a, b, c; 					//定义了3个短整型变量
            a = 51200; 					//常量51200超出了short类型的表达范围
            b = 16;
            c = a * b;						//表达式的值超出了short类型的表达范围
            Console.WriteLine(c);


        }
    }
}
