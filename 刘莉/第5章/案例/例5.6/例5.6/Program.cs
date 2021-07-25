using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 例5._6
{
    // 定义类MyClass
    class MyClass { }
    class GenClass<T> where T : class
    {
        T field;
        public GenClass()
        {
            field = null; // null是引用类型特有的赋值方式，可空类型除外
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 引用类型MyClass作为类型实参
            GenClass<MyClass> g = new GenClass<MyClass>();
            // double作为类型实参时会出现编译错误”double必须是引用类型才能作为类型参数”
            // GenClass<double>  g1 = new GenClass<double> ( ); 
        }
    }

}
