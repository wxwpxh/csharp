using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FourProcess
{
    class SubThread		// 定义SubThread类
    {
        int number;						// 记录当前数值
        public Thread workThrd;			// 定义实例化线程
        public SubThread(string name)		// 构造函数
        {
            number = 0;
            workThrd = new Thread(this.Working);
            workThrd.Name = name;
            workThrd.Start();
        }
        public void Working()				// 实现整数输出
        {
            Console.WriteLine("----子线程：{0}开始执行-----", workThrd.Name);
            while (number <= 3)
            {
                Thread.Sleep(500);			// 当前线程挂起指定的时间0.5秒
                Console.WriteLine("子线程：{0}，现累计数值到：{1}",
    workThrd.Name, number);
                number++;
            }
            Console.WriteLine("----子线程：{0}结束-----", workThrd.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程开始执行：");
            SubThread subT1 = new SubThread("SubTreadOne");
            SubThread subT2 = new SubThread("SubTreadTwo");
            SubThread subT3 = new SubThread("SubTreadThr");
            subT1.workThrd.Join();			// 阻塞调用线程，直到某个线程终止为止
            subT2.workThrd.Join();
            subT3.workThrd.Join();
            Console.WriteLine("主线程结束。");
            Console.Read();
        }
    }
}
