using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxOfTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Random rnd = new Random();
            a = rnd.Next(100, 201);
            b = rnd.Next(100, 201);
            if (a > b)
                Console.WriteLine("升序值: {0},{1}", a, b);
            else
                Console.WriteLine("升序值: {0},{1}", a, b);
            Console.ReadLine();

        }
    }
}
