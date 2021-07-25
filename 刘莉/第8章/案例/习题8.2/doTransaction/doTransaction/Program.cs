using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace doTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] thrds = new Thread[5];    // 线程数组
            Account acc = new Account(1000);    // 新建帐户对象，初始存款额1000
            for (int i = 0; i < 5; i++)
            { // 每次开始新的线程，执行帐户交易DoTransactions
                Thread t = new Thread(new ThreadStart(acc.DoTransactions));
                thrds[i] = t;
            }
            for (int i = 0; i < 5; i++)
            {
                thrds[i].Start();
            }
            Console.Read();
        }
    }
}
