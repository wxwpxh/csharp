using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace useThreadPool
{
    class ThreadPoolTest
    {
        public void Method(object state)
        {   // 输出1~40间的偶数，每行输出8个数
            string name = DateTime.Now.Millisecond.ToString();
            // 获取日期的毫秒部分
            if (state == null)
            {
                Console.WriteLine("无参方法{0}线程开始执行：", name);
            }
            else
            {
                Console.WriteLine("{0}线程开始执行：", state .ToString ());
            }
            int n=0;
            lock (this)
            {
                for (int i = 1; i <= 40; i++)
                {
                    if (i % 2 == 0)
                    {
                        n++;
                        Console.Write(i + "\t");
                        if (n % 8 == 0)
                        {
                            Console.WriteLine();
                            Thread.Sleep(500);
                        }
                    }
                }
            }
            if (state == null)
            {
                Console.WriteLine("\n无参方法{0}线程结束执行。", name);
            }
            else
            {
                Console.WriteLine("\n{0}线程结束执行。", state.ToString());
            }
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            ThreadPoolTest tpt = new ThreadPoolTest();
            // 将方法Method( )排入队列以便执行
            ThreadPool.QueueUserWorkItem(new WaitCallback(tpt.Method));
            Thread.Sleep(100);
            // 将方法Method( )排入队列以便执行，并指定包含该方法所用数据的对象
            ThreadPool.QueueUserWorkItem(new WaitCallback(tpt.Method),
                "采用带参数的方法：");
            Console.Read();
        }
    }
}
