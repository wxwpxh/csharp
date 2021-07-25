using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, a, b, c;
            for (i = 100; i <= 999; i++)
            {
                n = i;
                c = n % 10; n = n / 10;
                b = n % 10; n = n / 10;
                a = n;
                if (a * a * a + b * b * b + c * c * c == i)
                {
                    Console.WriteLine("{0}的立方+{1}的立方+{2}的立方 = {3}", a, b, c, a * a * a + b * b * b + c * c * c);
                    //Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
