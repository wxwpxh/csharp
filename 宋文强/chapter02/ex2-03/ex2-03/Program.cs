using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//利用转义字符，使计算机发出响铃声的控制台应用程序
namespace ex2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            char x, y;	//声明字符型变量x,y
            x = '\a';	//向变量x赋值为表示响铃的转义字符
            y = '\'';	//向变量y赋值为表示单引号的转义字符
            Console.Write("您将听到{0}计算机小喇叭{1}发出的一声响", y, y);
            Console.WriteLine(x);	//计算机小喇叭发出响铃声
            Console.ReadLine();
        }
    }
}
