//csc YieldTest1.cs

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YieldTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerator i = Feige.Fei();

            while (i.MoveNext())
            {
                Console.WriteLine(i.Current);
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }
        class Feige
        {
            public static IEnumerator<int> Fei()
            {
                for (int i = 0; i < 10; i++)
                {
                    yield return i;
                }
            }
        }
    }
}
