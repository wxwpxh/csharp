using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegate
{
    public delegate bool Comparison(int x, int y);
    class BubbleSorter
    {
        public static void Sort(int[] nArray, Comparison comparison)
        {
            for (int i = 0; i < nArray.Length; i++)
            {
                for (int j = i + 1; j < nArray.Length; j++)
                {
                    if (comparison(nArray[j], nArray[i]))
                    {
                        int temp = nArray[i];
                        nArray[i] = nArray[j];
                        nArray[j] = temp;
                    }
                }
            }
        }
        public static bool CompareValueDescend(int x, int y)//  数值降序比较
        {
            return x > y;
        }
        public static bool CompareAbsAscend(int x, int y) //  绝对值升序比较
        {
            return Math.Abs(x) < Math.Abs(y);
        }
        public static bool CompareStringAscend(int x, int y) //  字符串升序比较
        {
            return string.Compare(x.ToString().Trim(), y.ToString().Trim()) < 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] items = new int[5];
            for (i = 0; i < items.Length; i++)
            {
                Console.Write("输入items[{0}]:", i);
                items[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("按数值降序排列：");
            BubbleSorter.Sort(items, BubbleSorter.CompareValueDescend);
            for (i = 0; i < items.Length; i++)
            {
                Console.Write("{0,5}", items[i]);
            }
            Console.WriteLine();
            Console.WriteLine("按绝对值升序排列：");
            BubbleSorter.Sort(items, BubbleSorter.CompareAbsAscend);
            for (i = 0; i < items.Length; i++)
            {
                Console.Write("{0,5}", items[i]);
            }
            Console.WriteLine();
            Console.WriteLine("按字符串升序排列：");
            BubbleSorter.Sort(items, BubbleSorter.CompareStringAscend);
            for (i = 0; i < items.Length; i++)
            {
                Console.Write("{0,5}", items[i]);
            }
            Console.ReadLine();

        }
    }
}
