using System;
using System.Collections.Generic;
using System.Text;

namespace experment6
{
    public class BClass         //基类
    {
        private string name;    //名称
        private int no;         //编号
        public BClass(string na, int n)  //构造函数
        {
            name = na; no = n;
        }
        public void show()
        {
            Console.Write("{0}({1})", name, no);
        }
    }
    public class Book : BClass  //图书类
    {
        string author;          //作者
        public Book(string na, int n, string auth)
            : base(na, n)
        {
            author = auth;
        }
        public void showBook()
        {
            base.show();
            Console.Write("作者:{0}", author);
        }
    }
    public class Reader : BClass     //读者类
    {
        Book[] rent;                //所借图书
        int top;
        public Reader(string na, int n)
            : base(na, n)   //构造函数
        {
            rent = new Book[5];
            top = 0;
        }
        public void rentBook(ref Book b)
        {
            rent[top] = b;
            top++;
        }
        public void showReader()
        {
            Console.Write("读者:");
            base.show();
            Console.WriteLine("所借图书:");
            for (int i = 0; i < top; i++)
            {
                Console.Write("     {0}:", i + 1);   //5个空格
                rent[i].show();
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("C语言", 100, "潭浩强");
            Book b2 = new Book("数据结构", 110, "严蔚敏");
            Book b3 = new Book("软件工程", 210, "陈华");
            Book b4 = new Book("操作系统", 208, "张明");
            Reader r1 = new Reader("王华", 1234);
            Reader r2 = new Reader("李兵", 2600);
            r1.rentBook(ref b1);
            r1.rentBook(ref b2);
            r1.rentBook(ref b3);
            r2.rentBook(ref b4);
            r1.showReader();
            r2.showReader();
        }
    }
}
