using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace useSuspendResume
{
    class SuspendTest
    {
        // 启动线程，输出英文字母
        static void Method()
        {
            Console.WriteLine("----{0}线程启动----", Thread.CurrentThread.Name);
            int i = 1;
            while (i <= 26)
            {
                Console.Write(Convert .ToChar(i+Convert .ToInt32('A')-1) + "\t");
                if (i % 8 == 0)
                {
                    Console.WriteLine();
                    Thread.Sleep(800);      // 当前线程挂起指定的时间0.5秒
                }
                i++;
            }
            Console.WriteLine("\n----{0}线程结束----", Thread.CurrentThread.Name);
        }
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "主线程";
            Console.WriteLine("{0}线程启动：", Thread.CurrentThread.Name);
            Thread MyThread = new Thread(new ThreadStart(Method));
            MyThread.Name = "子线程";
            MyThread.Start();
            Thread.Sleep(1000);         // 让子线程运行1秒 
            MyThread.Suspend();       // 挂起子线程MyThread
            Console.WriteLine("\n----挂起{0}线程----", MyThread.Name);
            Thread.Sleep(5000);
            MyThread.Resume();        // 继续已挂起的线程
            Console.WriteLine("\n----唤醒{0}线程----", MyThread.Name);
            Thread.Sleep(1000);         // 让子线程运行1秒
            Console.WriteLine("{0}线程终止。", Thread.CurrentThread.Name);
            Console.Read();
        }
    }
}
