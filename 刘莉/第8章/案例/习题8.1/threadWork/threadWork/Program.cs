using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading ;

namespace threadWork
{
    public class Worker
    {
        private volatile bool _shouldStop;  
        // 使用Votile以启发编译器，本数据成员将被多线程访问。
        public void DoWork()
        {
            while (!_shouldStop)
            {
                Console.WriteLine("工作线程：working……");
                
            }
            Console.WriteLine("工作线程：terminating gracefully.");
        }
        
    
    public void RequestStop()
    {
        _shouldStop = true;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程：Starting worker thread……");
            // 创建工作线程对象，但不启动线程
            Worker workerObject = new Worker();
            Thread workerThread = new Thread(workerObject.DoWork);
            // 启动工作线程
            workerThread.Start();
            // 循环直至激活工作线程
            while (!workerThread.IsAlive) ;
            Thread.Sleep(1);
            workerObject.RequestStop();
            workerThread.Join();
            Console.WriteLine("主线程：Worker thread has terminated.");
            Console.ReadLine();
        }
    }
}
