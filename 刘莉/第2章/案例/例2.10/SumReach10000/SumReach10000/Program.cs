using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumReach10000
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, sum = 0, reachnum;
            Console.Write("请输入要达到的数：");
            reachnum = int.Parse(Console.ReadLine());
            while (sum < reachnum)
            {
                i++;
                sum += i;
            }
            Console.WriteLine("i={0},sum={1}", i, sum);
            Console.ReadLine();

        }
    }
}
