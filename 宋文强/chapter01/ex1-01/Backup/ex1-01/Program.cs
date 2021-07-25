using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex1_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入您的姓名：");
            string name = Console.ReadLine();		//输入姓名字符串赋值给name变量
            Console.WriteLine("欢迎" + name + "进入C#程序设计的广阔天地!");
            Console.ReadLine();    				/*使得程序执行不会自动退出调试环境*/

        }
    }
}
