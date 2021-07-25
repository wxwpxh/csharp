using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 0.0;
            int i;
            for (i = 1; i <= 2000; i++)
                if (i % 2 == 1)
                    pi = pi + 1.0 / (2 * i - 1);
                else
                    pi = pi - 1.0 / (2 * i - 1);
            pi = 4 * pi;
            Console.WriteLine("π={0}", pi);
        }
    }
}
