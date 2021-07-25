using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//利用Unicode编码值向字符型变量赋值的控制台应用程序
namespace ex2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b; 					//声明了两个字符型变量a和b
            a = '\u59DA';				//向字符型变量a赋予一个Unicode编码值
            b = '\u660E'; 				//向字符型变量b赋予另一个Unicode编码值
            Console.WriteLine("你输入的两个Unicode编码的意思是：{0}{1}", a, b);

            Console.ReadLine();//保持窗口不关闭
        }
    }
}
