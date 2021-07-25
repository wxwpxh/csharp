﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace threadComplicate
{
    class MyThread
    {
        public void ActionMethod()
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("线程{0}:" + Thread.CurrentThread.Name, i.ToString ());
            }
            Console.WriteLine(Thread .CurrentThread .Name + "执行结束。");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "--主线程--";
            MyThread newObj = new MyThread();
            // 启动子线程, 并为该线程执行 ActionMethod
            Thread objThread = new Thread(new ThreadStart(newObj.ActionMethod));
            objThread.Name = "**子线程**"; 
            objThread.Start();         // 这将为主线程执行 ActionMethod
            newObj.ActionMethod();      // 实例化的对象newObj执行方法ActionMethod
            Console.Read();
        }
    }
}
