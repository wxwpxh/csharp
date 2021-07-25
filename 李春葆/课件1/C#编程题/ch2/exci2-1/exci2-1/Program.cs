using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            float x = 3.5f, y = 2.5f;
            Console.WriteLine("{0}", (float)(a + b) / 2 + (int)x % (int)y);
        }
    }
}
