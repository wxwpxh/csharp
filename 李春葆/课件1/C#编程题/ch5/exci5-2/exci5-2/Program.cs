using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci5_2
{
    //定义了一个委托，委托在传递方法时，方法必须带两个int型的参数。
    public delegate int Call(int num1, int num2);
    //在Delegates类的内部定义Math类和TestDelegates类。
    class Math
    {
        public int fun1(int num1, int num2)
        {
            return num1 * num1 + num2 * num2;
        }
        public int fun2(int num1, int num2)
        {
            return num1 * num1 - num2 * num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Call objCall; 				//委托的对象
            Math objMath = new Math();	//Math类的对象
            objCall = new Call(objMath.fun1);
            result = objCall(5, 3);		//将委托实例化
            Console.WriteLine("5*5+3*3={0}", result);
            objCall = new Call(objMath.fun2);
            result = objCall(5, 3);		//将委托实例化
            Console.WriteLine("5*5-3*3={0}", result);
        }
    }
}
