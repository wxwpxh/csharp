using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exci7_1
{
    class Queue<T>
    {
        int maxsize;					//队列中元素最多个数
		T[] data;						//存放队列中T类型的元素
		int front,rear;					//队列顶指针
		public Queue()				    //构造函数
		{
            maxsize = 10;
			data = new T[maxsize];
			front = rear = 0;
        }
		public Queue(int n)			    //重载构造函数
		{
            maxsize = n;
			data = new T[maxsize];
			front = rear =0;
		}
		public bool QueueEmpty()		//判断队列空方法
		{	
            return front==rear; 
        }
        public bool QueueFull()         //判断队列满方法
        {
            return (rear + 1) % maxsize == front;
        }
		public bool EnQueue(T e)		//元素e进队列方法
		{
            if (QueueFull())		        //队列满返回false
				return false;
            rear = (rear + 1) % maxsize;
			data[rear] = e;
			return true;
		}
		public bool DeQueue(ref T e)		//元素出队列方法
		{	
            if (QueueEmpty())			//队列空返回false
				return false;
            front = (front + 1) % maxsize;
			e = data[front];
			return true;
		}
    }
    class Program
    {
        static void Main(string[] args)
        {
            int e = 0;
            Queue<int> q = new Queue<int>();	//定义整数队列
            q.EnQueue(1);						//进队列3个整数
            q.EnQueue(3);
            q.EnQueue(2);
            Console.Write("整数队列出队列次序：");
            while (!q.QueueEmpty())					//队列不空时出队列元素
            {
                q.DeQueue(ref e);
                Console.Write("{0} ", e);
            }
            Console.WriteLine();
            string e1 = "";
            Queue<string> q1 = new Queue<string>();	//定义字符串队列
            q1.EnQueue("Mary");						//进队列3个字符串
            q1.EnQueue("John");
            q1.EnQueue("Simth");
            Console.Write("字符串队列出队列次序：");
            while (!q1.QueueEmpty())				//队列不空时出队列元素
            {
                q1.DeQueue(ref e1);
                Console.Write("{0} ", e1);
            }
            Console.WriteLine();
        }
    }
}
