using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThrowException
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, t = 123, s = 0;
            Console.Write("请输入m:");
            m = int.Parse(Console.ReadLine());
            try
            {
                s = s + 100 / (m * 6 + t / m - m * m);
                //throw new DivideByZeroException("计算过程出现除数为0！");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("m={0},s={1}", m, s);
            Console.ReadLine();

        }
    }
}
