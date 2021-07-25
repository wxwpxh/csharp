using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 例5._2
{
    class GClass2<T, V>
    {
        T f1; V f2;
        public GClass2(T f1, V f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }
        public T GetValue1()
        {
            return this.f1;
        }
        public V GetValue2()
        {
            return this.f2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GClass2<int, string> twoPara = new GClass2<int, string>(2013, "Hello,World!");
            Console.WriteLine(twoPara.GetValue1());
            Console.WriteLine(twoPara.GetValue2());
        }
    }
}
