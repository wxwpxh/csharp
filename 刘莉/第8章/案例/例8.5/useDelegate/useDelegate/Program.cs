using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace useDelegate
{
    // 自定义一个MyThreadClass类
    public class MyThreadClass
    {
        private string Msg;
        public MyThreadClass(string msg)     // 带参数的构造函数
        {
            this.Msg = msg;
        }
        public void ThreadMain()                    // 线程的主方法 
        {
            Console.WriteLine("字段Msg的值是：{0}",Msg );
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThreadClass mtc = new MyThreadClass("若看到这里，表示数据传递成功！");
            // 实例化对象，并传送值
            Thread thread1 = new Thread(mtc.ThreadMain );
        //    Thread t2=new Thread (new ThreadStart(
            // 传送线程主方法
            thread1.Start();
            Console.Read();         // 获取输入焦点，在DOS窗口中停留
        }
    }
}
