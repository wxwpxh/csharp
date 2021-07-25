using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 123.456;
            Console.WriteLine("{0,5:c}", d);
            Console.WriteLine("{0:E4}", d);
            Console.WriteLine("{0:f4}", d);
            Console.WriteLine("{0:g}", d);
            Console.WriteLine("{0:n}", d);
        }
    }
}
