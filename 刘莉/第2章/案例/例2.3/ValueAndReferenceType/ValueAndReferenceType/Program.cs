using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValueAndReferenceType
{
    class Vertex
    {
        public int value = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0;
            int x2 = x1;
            Vertex v1 = new Vertex();
            Vertex v2 = v1;
            // 重新对x2, v2.value赋值
            // 观察对x1和v1的影响,也可以对x1和v1.value赋值来观察x2和v2。
            x2 = 123;
            v2.value = 123;
            Console.WriteLine("x1:{0} , x2:{1}", x1, x2);
            Console.WriteLine("v1:{0} , v2:{1}", v1.value, v2.value);
            Console.Read();

        }
    }
}
