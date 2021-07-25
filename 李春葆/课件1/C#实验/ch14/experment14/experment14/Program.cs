using System;
using System.Threading;

namespace experment14
{
    public class MyClass                        //声明类MyClass
    {
        Random r = new Random();
        int sum = 0;
        int x = 0;
        bool mark = false;
        Object thisLock = new Object();
        public void put1()						//生产者1
        {
            Monitor.Enter(thisLock);			//加排它锁
            if (mark)						    //若mark为true,不能放数据,本线程等待
                Monitor.Wait(thisLock);
            mark = !mark;					    //将mark由false改为true
            x = 1;						        //放数据
            Thread.Sleep(r.Next(20, 50));	    //睡眠2-50ms
            Monitor.Pulse(thisLock);			//激活消费者线程
            Monitor.Exit(thisLock);			    //释放排它锁
        }
        public void put2()						//生产者2
        {
            Monitor.Enter(thisLock);			//加排它锁
            if (mark)						    //若mark为true,不能放数据,本线程等待
                Monitor.Wait(thisLock);
            mark = !mark;					    //将mark由false改为true
            x = 2;						        //放数据
            Thread.Sleep(r.Next(20, 50));	    //睡眠2-50ms
            Monitor.Pulse(thisLock);			//激活消费者线程
            Monitor.Exit(thisLock);			    //释放排它锁
        }
        public void get1()						//消费者1
        {
            Monitor.Enter(thisLock);			//加排它锁
            if (!mark)					        //若mark为false,不能取数据,本线程等待
                Monitor.Wait(thisLock);
            mark = !mark;					    //将mark由true改为false
            sum += x;						    //累加数
            Thread.Sleep(r.Next(20, 50));	    //睡眠2-50ms
            Monitor.Pulse(thisLock);			//激活生产者线程
            Monitor.Exit(thisLock);			    //释放排它锁
        }
        public void get2()						//消费者2
        {
            Monitor.Enter(thisLock);			//加排它锁
            if (!mark)					        //若mark为false,不能取数据,本线程等待
                Monitor.Wait(thisLock);
            mark = !mark;					    //将mark由true改为false
            sum += x;						    //累加数
            Thread.Sleep(r.Next(20, 50));	    //睡眠2-50ms
            Monitor.Pulse(thisLock);			//激活生产者线程
            Monitor.Exit(thisLock);			    //释放排它锁
        }
        public void dispsum()
        {
            Console.WriteLine("消费总数={0}", sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            Thread workth1 = new Thread(obj.put1);	//创建工作线程1
            Thread workth2 = new Thread(obj.put2);	//创建工作线程2
            Thread workth3 = new Thread(obj.get1); 	//创建工作线程3
            Thread workth4 = new Thread(obj.get2); 	//创建工作线程4
            workth1.Start();					    //启动工作线程1
            workth2.Start();					    //启动工作线程2
            workth3.Start();					    //启动工作线程3
            workth4.Start();					    //启动工作线程4
            Thread.Sleep(600);
            workth1.Abort();					    //终止工作线程1
            workth2.Abort();					    //终止工作线程2
            workth3.Abort();					    //终止工作线程3
            workth4.Abort();					    //终止工作线程4
            obj.dispsum();
        }
    }
}
