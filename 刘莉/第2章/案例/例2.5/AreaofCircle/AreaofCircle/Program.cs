using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaofCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            double r, s;
            string t;
            Console.Write("请输入圆的半径:");
            t = Console.ReadLine();
            r = double.Parse(t);
            s = PI * r * r;
            Console.WriteLine("面积为{0}", s);
            Console.Read(); 

        }
    }
}
