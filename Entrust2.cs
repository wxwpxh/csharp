//csc Entrust2.cs
//概念：委托就是可以用方法名调用另一方法的便捷方法，可以简化switch等语句的重复
//https://blog.csdn.net/weixin_41963036/article/details/80295111
using System;
namespace Func
{
    public delegate int MyDel(int num);//声明一个自定义委托
    class Program
    {
        static int Add1(int a)
        {
            int b = 10 + a;
            Console.WriteLine("——Add1———");
            return b;
 
        }
 
        static int Add2(int a)
        {
            int b = 10 - a;
            Console.WriteLine("——Add2———");
            return b;
 
        }
 
        static void Calculate(MyDel ex, int a)
        {
            var result = ex(a);
            Console.WriteLine(result + "\n");
        }
 
        static void Main(string[] args)
        {
            Calculate(Add1, 1);
            Calculate(Add2, 10);
            Console.ReadKey();
        }
    }
}