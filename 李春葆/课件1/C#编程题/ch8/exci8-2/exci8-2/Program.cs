using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci8_2
{
    public class ListIterable<T> : IEnumerable<T>  //声明可枚举类
    {
        List<T> list;
        public ListIterable(List<T> list)        //构造函数
        {
            this.list = list;
        }
        IEnumerator IEnumerable.GetEnumerator() //实现IEnumerable的GetEnumerator方法
        {
            return (IEnumerator)GetEnumerator();            
        }
     
        public IEnumerator<T> GetEnumerator()
        {
            return new ListIterator<T>(list);
        }
    }

    public class ListIterator<T> : IEnumerator<T>   //声明枚举器类
    {
        List<T> list;
        int current;

        public ListIterator(List<T> list)
        {
            this.list = list;
            current = -1;
        }

        public T Current        
        { 
            get
            { return list[current]; } 
        }
        object IEnumerator.Current        	//实现IEnumerator的Current属性
        {
            get
            { return Current; }         	//返回PeopleEnum的Current属性
        }

        public bool MoveNext()
        {
            return ++current < list.Count;
        }

        public void Reset()
        {
            current = -1;
        }
        void IDisposable.Dispose()
        {           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            ListIterable<int> obj = new ListIterable<int>(nums);
            foreach (var i in obj)
                Console.Write("{0} ",i);
            Console.WriteLine();
        }       
    }
}
