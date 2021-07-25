using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace StackSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Ids = new Stack();
            int select;
            Console.WriteLine("输入正整数进入栈，0从栈中移出，负数退出");
            do
            {
                Console.Write("请输入：");
                select = int.Parse(Console.ReadLine());
                if (select > 0)
                {
                    Ids.Push(select);
                    Console.WriteLine("{0}加入栈", select);
                }
                else if (select == 0)
                    if (Ids.Count > 0)
                        Console.WriteLine("{0}移出栈", Ids.Pop());
                    else
                        Console.WriteLine("栈中没有成员");
            } while (select >= 0);

        }
    }
}
