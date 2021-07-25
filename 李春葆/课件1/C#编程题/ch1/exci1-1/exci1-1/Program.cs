using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1234,b=-1234;
            Console.WriteLine("a={0},b={1}",a,b);
            Console.WriteLine("a={0:D5},b={1:D5}", a, b);
            Console.WriteLine("a={0:c3},b={1:c2}", a, b);
        }
    }
}
