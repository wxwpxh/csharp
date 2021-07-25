using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodTest
{

    class SimpleMath
    {
        private int nValue = 10;
        private static int staticValue = 20;
        public static void staticDisplay()
        {
            Console.WriteLine("静态方法调用");
            //  Console.WriteLine("nValue的值为{0}", nValue);
            //  错误，静态方法引用了非静态成员
            Console.WriteLine("staticValue的值为{0}", staticValue);
        }
        public void Display()
        {
            Console.WriteLine("实例方法调用");
            Console.WriteLine("nValue的值为{0}", nValue);
            Console.WriteLine("staticValue的值为{0}", staticValue);
            //  没问题，实例方法可以引用静态成员
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleMath.Display( );// 错误!,实例方法必须由实例调用
            SimpleMath.staticDisplay();
            SimpleMath smp = new SimpleMath();
            // smp.staticDisplay( ); // 错误!,静态方法必须由类名调用
            smp.Display();
            Console.ReadLine();

        }
    }
}
