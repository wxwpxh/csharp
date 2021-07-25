using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CreatThread
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个线程
            Thread thread1 = new Thread(new ThreadStart(runner));
            thread1.Start();        // 启动一个线程
            Console.WriteLine("运行Main程序函数");
            //if (thread1.IsAlive)
            //{
            //    thread1.Abort();
            //}
            //if (thread1.ThreadState == ThreadState.Running)
            //{
            //    thread1.Suspend();
            //}
            Console.Read();
        }
        // 线程的主方法
        static  void runner()
        {
            Console.WriteLine("运行runner函数");
        }
    }
}
