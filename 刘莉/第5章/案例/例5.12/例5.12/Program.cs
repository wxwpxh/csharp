using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 添加命名空间引用
using System.Collections.Generic;

namespace 例5._12
{
    class Program
    {
        static void RandomNumber(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Random().Next(0, 101);
            }
        }
        static void PrintElement<T>(HashSet<T> hs)
        {
            foreach (T e in hs)
                Console.Write("{0,5}", e);
            Console.WriteLine();
        }
        static bool isLessThan5(int e)
        {
            return e < 5;
        }
        static void Main(string[] args)
        {
            HashSet<int> hs1 = new HashSet<int>();
            HashSet<int> hs2 = new HashSet<int>();
            // hs1添加元素
            for (int i = 1; i <= 10; i++)
                hs1.Add(i);
            // hs2添加元素
            for (int i = 2; i < 15; i = i + 2)
                hs2.Add(i);
            // 输出hs1的元素
            Console.WriteLine("hs1的元素：");
            PrintElement<int>(hs1);
            // 输出hs2的元素
            Console.WriteLine("hs2的元素：");
            PrintElement<int>(hs2);
            Console.WriteLine("hs1包含元素3：" + hs1.Contains(3));
            Console.WriteLine("hs1等于hs2:" + hs1.SetEquals(hs2));
            Console.WriteLine("hs1和hs2有重叠：" + hs1.Overlaps(hs2));
            // hs1中的元素为hs1和hs2的并集
            hs1.UnionWith(hs2);
            // 输出hs1的元素
            Console.WriteLine("与hs2并集后hs1的元素：");
            PrintElement<int>(hs1);
            Console.WriteLine("hs2是hs1的子集：" + hs2.IsSubsetOf(hs1));
            // hs1中的元素为hs1和hs2的差集
            hs1.ExceptWith(hs2);
            Console.WriteLine("与hs2差集后hs1的元素：");
            PrintElement<int>(hs1);
            hs1.Add(2);
            // hs1中的元素为hs1和hs2的交集
            hs1.IntersectWith(hs2);
            Console.WriteLine("向hs1中添加元素2之后，再与hs2交集；hs1的元素：");
            PrintElement<int>(hs1);
            hs2.RemoveWhere(isLessThan5);
            Console.WriteLine("删除hs2中小于5的元素");
            PrintElement<int>(hs2);
        }

    }
}
