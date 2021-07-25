using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace code
{
    class Program
    {
         static void Main(string[] args)
        {
            creatCode ccd1 = new creatCode(1);
            creatCode ccd2 = new creatCode(2);
            creatCode ccd3 = new creatCode(3);
            Thread thread1  = new Thread(new ThreadStart(ccd1.counterCode));//线程初始化
           Thread thread2 = new Thread(new ThreadStart(ccd2.counterCode ));
           Thread thread3 = new Thread(new ThreadStart(ccd3.counterCode));
            thread1.Start();//启动线程
            thread2.Start();
            thread3.Start();
            Console.Read();
        }
    }
}
