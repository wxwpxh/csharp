﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            bool prime = true;
            Console.Write("输入一个大于3的正整数:");
            n = int.Parse(Console.ReadLine());
            for (i = 3; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            if (prime) Console.WriteLine("{0}是素数", n);
            else Console.WriteLine("{0}不是素数", n);
        }
    }
}
