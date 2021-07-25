using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s1 = 0, s2 = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 1)
                    s1 += n;
                else
                    s2 += n;
            } while (n != 0);
            Console.WriteLine("奇数之和={0}", s1);
            Console.WriteLine("偶数之和={0}", s2);
        }
    }
}
