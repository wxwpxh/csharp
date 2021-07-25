using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 例5._7
{
    // 定义MyClass1无构造函数
    class MyClass1
    {
    }
    // 定义MyClass2具有无参数构造函数
    class MyClass2
    {
        public MyClass2()
        {
            Console.WriteLine("执行MyClass2的构造函数！");
        }
    }
    // 定义MyClass3具有有参数和无参数构造函数
    class MyClass3
    {
        public MyClass3()
        {
            Console.WriteLine("执行MyClass3无参数的构造函数！");
        }
        public MyClass3(int n)
        {
            Console.WriteLine("执行MyClass3有参数的构造函数！");
            Console.WriteLine("n=" + n);
        }
    }
    // GenClass使用了new( )构造函数约束
    class GenClass<T> where T : new()
    {
        T field;
        public GenClass()
        {
            Console.WriteLine("------------执行T的构造函数！------------");
            // 若去掉new( )构造函数约束，此处会报错
            field = new T();
            // 编译错误，不能给T的构造函数传递参数
            // field = new T(3);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenClass<MyClass1> g1 = new GenClass<MyClass1>();
            GenClass<MyClass2> g2 = new GenClass<MyClass2>();
            GenClass<MyClass3> g3 = new GenClass<MyClass3>();
        }
    }

}
