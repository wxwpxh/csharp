//csc coroutine1.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YieldTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Feige.Fei())
            {
                Console.WriteLine("返回的结果是：" + i );
            }
        }
        class Feige
        {
            public static IEnumerable<int> Fei()
            {
                for (int i = 0; i < 10; i++)
                {
                    yield return i;
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
