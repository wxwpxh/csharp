// csc ThreadTest2.cs
// https://blog.csdn.net/qq_19895789/article/details/100113383

using System;
using System.Threading;
namespace LeeCarry
{
    public class Test
    {
        private static Semaphore gold=new Semaphore(3,3);//第一个参数为目前可用请求数，第二个参数为最大请求数

        public static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                Thread t = new Thread(DoMining);
                t.Start(i);
            }
            
        }
        private static void DoMining(object obj)
        {
            int id=Convert.ToInt32(obj);
            for(int i=0;i<5;i++)
            {
                gold.WaitOne();//如果还有请求数就直接通过请求数减一，没有请求数就暂停在这等有请求时通过
                Console.WriteLine("我是{0}号矿工，现在开始采矿",id);
                Thread.Sleep(1000);
                Console.WriteLine("我是{0}号矿工，现在采矿完成",id);
                gold.Release();//释放请求数
            }
        }
    }
}
