using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 例5._4
{
    // 基类：电话号码
    class PhoneNumber
    {
        string name; // 联系人姓名
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string number; // 联系人电话
        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public PhoneNumber(string name, string number)
        {
            this.name = name;
            this.number = number;
        }
    }

    // 子类：Friend
    class Friend : PhoneNumber
    {
        bool isWorkNumber; // 是否是工作电话
        public bool IsWorkNumber
        {
            get { return isWorkNumber; }
        }
        public Friend(string name, string number, bool isWorkNum)
            : base(name, number)
        {
            this.isWorkNumber = isWorkNum;
        }
    }

    // 供应商
    class Supplier : PhoneNumber
    {
        public Supplier(string name, string number) : base(name, number) { }
        // 其它成员
    }
    class Others
    {
    }
    // 管理电话列表的类PhoneList
    class PhoneList<T> where T : PhoneNumber
    {
        T[] phList;
        int end;
        public PhoneList()
        {
            this.phList = new T[10];
            end = 0;
        }
        public bool Add(T newNumber)
        {
            if (end == 10)
                return false;
            phList[end] = newNumber;
            end++;
            return true;
        }
        public void findByName(string name)
        {
            for (int i = 0; i < end; i++)
            {
                if (phList[i].Name == name)
                {
                    Console.WriteLine("{0}的联系电话是：{1}", name, phList[i].Number);
                    return;
                }
            }
            Console.WriteLine("没有找到{0}的联系方式！", name);
        }
    }
    // 主调用函数代码：
    class Program
    {
        static void Main(string[] args)
        {
            // Friend做为类型实参
            PhoneList<Friend> plist = new PhoneList<Friend>();
            plist.Add(new Friend("张三", "0535-1234567", true));
            plist.Add(new Friend("李四", "010-12345678", false));
            plist.Add(new Friend("王五", "020-91234567", true));
            plist.findByName("张三");
            Console.WriteLine();
            // Supplier做为类型实参
            PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
            plist2.Add(new Supplier("Oracle", "010-9876543"));
            plist2.Add(new Supplier("AdobeReader", "010-666666"));
            plist2.findByName("Sun");
            Console.WriteLine();
            // PhoneNumber做为类型实参
            PhoneList<PhoneNumber> plist3 = new PhoneList<PhoneNumber>();
            // Others做为类型实参时，会出现编译错误
            // PhoneList<Others >  plist4 = new PhoneList<Others > ( );
        }
    }

}
