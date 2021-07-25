using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleEnum
{
    enum Days : int
    {
        Sun, Mon, Tue=4, Wed, Thu, Fri, Sat
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days day = Days.Sun;
            if (Days.Sun == 0)
            {
                Console.WriteLine("枚举类型可以和整数值直接比较");
            }
            Console.WriteLine(day + 3);// 枚举类型可以和整数进行运算。
            // 枚举可以应用到循环
            for (day = Days.Sun; day <= Days.Sat; day++)
            {
                Console.Write("{0,5}", day);
            }
            Console.WriteLine();
            // 另一种循环方式利用Enum类的方法
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.Write("{0,5}", s);
            }
            Console.ReadLine();

        }
    }
}
