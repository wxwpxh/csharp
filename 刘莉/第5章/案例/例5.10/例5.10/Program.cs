using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 添加命名空间引用
using System.Collections.Generic;

namespace 例5._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> courses = new Stack<string>();
            courses.Push("大学英语");
            courses.Push("C#程序设计");
            courses.Push("软件工程");
            Console.WriteLine("栈中元素个数：{0}", courses.Count);
            Console.WriteLine("栈顶部元素：{0}", courses.Peek());
            Console.WriteLine("栈中元素个数：{0}", courses.Count);
            // 获取能遍历访问堆栈中所有元素的IEnumerator接口的实例
            IEnumerator<string> myEnumerator = courses.GetEnumerator();
            Console.WriteLine("栈中的元素如下：");
            while (myEnumerator.MoveNext())
            {
                Console.Write("{0}\t", myEnumerator.Current);
            }
            Console.WriteLine();
            int count = courses.Count;
            for (int i = 0; i < count; i++)
                Console.WriteLine("出栈：'{0}' ", courses.Pop());
            Console.WriteLine("出栈后，栈的元素个数为：" + courses.Count);

        }
    }
}
