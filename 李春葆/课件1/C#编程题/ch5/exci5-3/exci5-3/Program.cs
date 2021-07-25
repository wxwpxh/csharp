using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci5_3
{
    class List
    {
        private int Max = 100;  //存储最多元素
        private int num = 0;    //存储的实际元素个数
        private object[] list;  //存储元素数组
        public List()           //构造函数
        {
            list = new object[Max];
        }
        public void add(object obj) //添加一个元素
        {
            list[num] = obj;
            num++;
        }
        public void delete(int pos) //删除一个元素
        {
            for (int i = pos + 1; i < num; i++)
                list[i - 1] = list[i];
            num--;
        }
        public object get(int pos)  //获取指定位置的元素
        {
            if (pos < num)
                return list[pos];
            else
                return null;
        }
        public int getnum()     //获取实际元素个数
        {
            return num;
        }
        public string disp()    //获取所有元素
        {
            string s = "";
            for (int i = 0; i < num; i++)
                s += list[i] + " ";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.add("abc");
            list.add(1.23);
            list.add(2);
            list.add('a');
            Console.WriteLine("元素序列:{0}", list.disp());
            Console.WriteLine("元素个数:{0}", list.getnum());
            Console.WriteLine("位置1的元素:{0}", list.get(1));
            Console.WriteLine("删除位置2的元素");
            list.delete(2);
            Console.WriteLine("元素序列:{0}", list.disp());
        }
    }
}
