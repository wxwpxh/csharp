using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nValue = new int[50];//大体估计数组大小
            int count = 1, i, j;
            nValue[0] = 2;//2是一个质数。
            for (i = 3; i < 100; i += 2)
            {
                for (j = 0; j < count; j++)
                    if (i % nValue[j] == 0)
                        break;
                if (j == count)
                {
                    nValue[count] = i;
                    count++;
                }
            }
            Console.Write("100之内的质数:");
            for (i = 0; i < count; i++)
            {
                if (i % 10 == 0)
                    Console.WriteLine();
                Console.Write("{0,5}", nValue[i]);
            }
            Console.ReadLine();

        }
    }
}
