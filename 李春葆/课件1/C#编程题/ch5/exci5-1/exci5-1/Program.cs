using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(2, 50);
            Animal a1 = new Animal(4,120);
            p1.show();
            a1.show();
        }
    }
    public class Person   		//定义人类
    {
        public int legs; 		//腿的只数
        protected float weight; //重量
        public Person()         //默认构造函数
        { }
        public Person(int legs1, float weight1)//自定义方法F 
        {
            legs = legs1;
            weight = weight1;
        }
        public void show()
        {
            Console.WriteLine("某人有{0}只腿，重量为{1}kg", legs, weight);
        }
    }
    class Animal    				//定义动物类
    {
        public int num;         	//腿的条数
        private float weight; 		//重量
        public Animal()             //Animal类的默认构造函数
        { }
        public Animal(int n, float w)  //Animal类带2个参数的构造函数
        {
            num = n;
            weight = w;
        }
        public void show()
        {
            Console.WriteLine("某动物有{0}只脚，重量为{1}kg", num, weight);
        }
    }
}
