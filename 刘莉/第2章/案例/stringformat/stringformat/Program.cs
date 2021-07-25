using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stringformat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 200;
            double t = 12345.6789;
            Console.WriteLine("{0:x5}--{0,5}--{1,-10:f2}--{1:e4}", i, t);
            Console.Read();
        }
    }
}
