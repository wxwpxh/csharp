using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//通过控制台接收用户输入的一个字符串，并通过控制台输出这个字符串的内容
namespace ex3_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("请通过键盘输入一个字符串：");
            s = Console.ReadLine();						//等待用户键盘输入字符串
            Console.Write("刚才输入的字符串是：");
            Console.WriteLine(s);

            Console.ReadLine();  /*使得程序执行不会自动退出调试环境*/
        }
    }
}
