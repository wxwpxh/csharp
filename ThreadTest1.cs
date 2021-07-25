//csc ThreadTest1.cs
// https://www.cnblogs.com/sunchong/p/10780416.html

using System;
using System.Threading;
namespace ThreadTest1
{
   class ThreadTest_V0
   {
        public int count = 0;
        public void Add1()
        {
            int index = 0;
            while (index++ < 1000000)//100万次
            {
                ++count;
            }
        }

        public void Add2()
        {
            int index = 0;
            while (index++ < 1000000)//100万次
            {
                count++;
            }
        }
			   
			   
      static void Main(string[] args)
      {
            ThreadTest_V0 testV0 = new ThreadTest_V0();
            Thread th1 = new Thread(testV0.Add1);
            Thread th2 = new Thread(testV0.Add2);

            th1.Start();
            th2.Start();
            th1.Join();
            th2.Join();

            Console.WriteLine($"V0：count = {testV0.count}");			//100万到200万之间的随机数
      }
   }
}