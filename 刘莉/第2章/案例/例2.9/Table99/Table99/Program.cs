using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Table99
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0}*{1}={2,-3}", i, j, i * j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
