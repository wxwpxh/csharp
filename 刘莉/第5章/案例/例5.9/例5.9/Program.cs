using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 添加命名空间引用
using System.Collections.Generic;


namespace 例5._9
{
    class QueueNumber
    {
        Queue<int> queue = new Queue<int>();	// 创建队列集合
        public void AddNumber()					// 向队列中添加100个随机数
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                queue.Enqueue(random.Next(100) + 1);
            }
            Console.WriteLine("100个随机数添加完毕！");
            foreach (int e in queue)
                Console.Write("{0,5}", e);
            Console.WriteLine();
            Console.WriteLine("元素个数是：{0};第一个元素是：{1}", queue.Count, queue.Peek());
        }
        public int FindNumbers(int n) // 统计与n相同值的元素的个数
        {
            int count = 0;
            while (queue.Count > 0)
            {
                if ((int)queue.Dequeue() == n)
                    count++;
            }
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QueueNumber qn = new QueueNumber();
            qn.AddNumber();
            Console.Write("输入要找的数：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}出现的次数有{1}次！", n, qn.FindNumbers(n));
        }
    }

}
