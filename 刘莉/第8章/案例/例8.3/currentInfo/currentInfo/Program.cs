using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace currentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("————主线程状态————");
            Thread currentThread = Thread.CurrentThread;
            currentThread.Name = "The Current Thread";
            //输出当前线程的相关信息
            Console.WriteLine("当前线程的应用程序域：{0},ID：{1}",
    Thread.GetDomain().FriendlyName, Thread.GetDomainID());
            Console.WriteLine("正在执行程序的当前上下文：{0}",  
                Thread .CurrentContext);
            Console.WriteLine("名称：{0}", currentThread.Name);
            Console.WriteLine("当前是否处于活动状态：{0}",
 currentThread.IsAlive);
            Console.WriteLine("状态：{0}", currentThread.ThreadState);
            Console.WriteLine("优先级：{0}", currentThread.Priority);
            Console.WriteLine("当前线程是否为后台线程：{0}", 
                currentThread.IsBackground);
            Console.WriteLine("主线程读取信息完毕");
            Console.Read();
        }
    }
}
