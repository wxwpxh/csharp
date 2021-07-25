using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//通过控制台接收用户输入的一个字符，查看这个字符的Unicode码值以及字符本身
namespace ex3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            char ch;
            Console.Write("请通过键盘输入一个字符：");	//提示信息
            a = Console.Read();						//等待用户键盘输入字符
            Console.Write("这个字符的Unicode代码是：");	//提示信息
            Console.WriteLine(a);					//显示输入字符的Unicode码值
            ch = (char)a;							//显式类型转换
            Console.Write("这个字符是：");			//提示信息
            Console.WriteLine(ch);					//显示键盘输入的字符

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
