using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace QueueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue Ids = new Queue();
            int select;
            Console.WriteLine("输入正整数进入排队，0从排队中移出办理业务，负数退出");
            do
            {
                Console.Write("请输入：");
                select = int.Parse(Console.ReadLine());
                if (select > 0)
                {
                    Ids.Enqueue(select);
                    Console.WriteLine("{0}加入队列", select);
                }
                else if (select == 0)
                    if (Ids.Count > 0)
                        Console.WriteLine("{0}移出队列", Ids.Dequeue());
                    else
                        Console.WriteLine("队列中没有成员");
            } while (select >= 0);

        }
    }
}
