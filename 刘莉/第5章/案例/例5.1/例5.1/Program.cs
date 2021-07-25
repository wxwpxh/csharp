using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 例5._1
{
    class GenClass<T>
    {
        T ob;						// 声明一个T类型的变量
        static int i;				// 静态成员count用来统计泛型类实例化的次数
        public GenClass(T t)
        {
            ob = t;
            i++;
        }
        public T GetOb()
        {
            return ob;				// 返回T类型的ob
        }
        // 显示T的数据类型
        public void ShowType()
        {
            Console.WriteLine("T的数据类型是：{0}", typeof(T));
        }
        // 返回泛型类实例化的次数
        public static int Counter()
        {
            return i;
        }
    }
    // 使用泛型类
    class GenDemo
    {
        static void Main(string[] args)
        {
            GenClass<int> iob; // 声明一个int类型的对象iob
            iob = new GenClass<int>(3); // 实例化iob对象
            iob.ShowType(); // 显示iob对象的数据类型
            int i = iob.GetOb();
            Console.WriteLine("iob={0}", i);
            // 输出实例化次数
            Console.WriteLine("实例化次数：{0}", GenClass<int>.Counter());
            Console.WriteLine();
            // 实例化一个string类型的对象strob
            GenClass<string> strob = new GenClass<string>("Hello World.");
            strob.ShowType(); // 显示strob对象的数据类型
            string s = strob.GetOb();
            Console.WriteLine("strob={0}", s);
            // 实例化一个string类型的对象strob2
            GenClass<string> strob2 = new GenClass<string>("Hello World.");
            // 输出实例化次数
            Console.WriteLine("实例化次数：{0}", GenClass<int>.Counter());
        }
    }

}
