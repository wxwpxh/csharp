using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace useProcess
{
    class ProcessDemo
    {
        public void StartProcess(int n)
        {
            Process p;
            for (int i = 1; i <= n; i++)
            {
                p = Process.Start("calc.exe");
                Console.WriteLine("已运行{0}个计算器进程",i );
                //根据传入的n来启动计算器进程
            }
        }
        public void ExitProcess()
        {
            //获取当前所有正在运行的计算器进程，并逐个调用Kill方法强制结束它们
            Process[] ps = Process.GetProcessesByName("calc");
            foreach (Process p in ps)
            {
                Console.Write("请回车以结束一个计算器进程");
                Console.ReadLine();
                p.Kill();
            }
        }
    }
}
