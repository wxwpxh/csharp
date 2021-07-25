using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, s = 0;
            Console.Write("n:");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
                for (j = 1; j <= i; j++)
                    s += j;
            Console.WriteLine("s={0}", s);
        }
    }
}
