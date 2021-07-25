//csc myloop1.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1 - 100间所有的偶数的和
            int sum = 0;
            for (int i = 2; i <=100; i++)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("1 - 100间所有的偶数的和是{0}",sum);
            Console.ReadKey();
        }
    }
}　　