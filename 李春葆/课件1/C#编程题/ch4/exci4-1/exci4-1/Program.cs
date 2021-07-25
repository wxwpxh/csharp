using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 1, 8, 3, 4, 7, 9, 6, 10, 2, 5 };
            int n = 10, max1, max2, i;
            max1 = a[0] > a[1] ? a[0] : a[1];
            max2 = a[0] > a[1] ? a[1] : a[0];
            for (i = 2; i < n; i++)
                if (max1 < a[i])
                {
                    max2 = max1;
                    max1 = a[i];
                }
            Console.WriteLine("max1={0},max2={1}", max1, max2);
        }
    }
}
