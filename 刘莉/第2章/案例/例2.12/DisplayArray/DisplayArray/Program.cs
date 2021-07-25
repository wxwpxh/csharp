using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = new int[] { 10, 20, 30, 40, 50 };
            foreach (int nVariable in arrayOfInts)
            {
                //nVariable++;//错误不能为其赋值
                Console.WriteLine(nVariable);
            }
            Console.ReadLine();

        }
    }
}
