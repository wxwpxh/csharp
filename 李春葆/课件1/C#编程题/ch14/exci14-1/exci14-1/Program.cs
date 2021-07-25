using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace exci14_1
{
    class Program
    {
        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("工作线程: {0}", i);
                Thread.Sleep(10);
            }
        }
        public static void Main()
        {
            Console.WriteLine("主线程:启动一个工作线程.");
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("主线程：工作.");
                Thread.Sleep(10);
            }
            Console.WriteLine("主线程:调用Join()等待直到工作线程中止.");
            t.Join();
            Console.WriteLine("主线程:ThreadProc.Join返回.");
        }
    }
}
