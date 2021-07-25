using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4, c = 5;
            Console.WriteLine("{0}", (++a - 1) & b + c / 2);
        }
    }
}
