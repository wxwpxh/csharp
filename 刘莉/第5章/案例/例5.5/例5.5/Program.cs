using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 例5._5
{
    interface IPhoneNumber
    {
        string Name
        {
            get;
            set;
        }
        string Number
        {
            get;
            set;
        }
    }
    // Friend实现IPhoneNumber接口
    class Friend : IPhoneNumber
    {
        string name; // 联系人姓名
        string number; // 联系人电话
        bool isWorkNumber; // 是否是工作电话
        public bool IsWorkNumber
        {
            get { return isWorkNumber; }
        }
        public Friend(string name, string number, bool isWorkNum)
        {
            this.isWorkNumber = isWorkNum;
        }
        // 实现接口成员
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }
    }
    // 供应商实现IPhoneNumber接口
    class Supplier : IPhoneNumber
    {
        string name; // 联系人姓名
        string number; // 联系人电话
        public Supplier(string name, string number)
        {
            this.name = name;
            this.number = number;
        }
        // 实现接口成员
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Number
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
    // Others没有实现接口IPhoneNumber
    class Others
    {
    }
    // 管理电话列表的类PhoneList使用了接口约束
    class PhoneList<T> where T : IPhoneNumber
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
    class Program
    {
        static void Main(string[] args)
        {
            // 实现了IPhoneNumber接口的Friend类做为类型实参
            PhoneList<Friend> plist = new PhoneList<Friend>();
            plist.Add(new Friend("张三", "0535-1234567", true));
            plist.Add(new Friend("李四", "010-12345678", false));
            plist.Add(new Friend("王五", "020-91234567", true));
            plist.findByName("张三");
            Console.WriteLine();
            // 实现了IPhoneNumber接口的Supplier类做为类型实参
            PhoneList<Supplier> plist2 = new PhoneList<Supplier>();
            plist2.Add(new Supplier("Oracle", "010-9876543"));
            plist2.Add(new Supplier("AdobeReader", "010-666666"));
            plist2.findByName("Sun");
            Console.WriteLine();
            // Others做为类型实参时，会出现编译错误
            // PhoneList<Others >  plist4 = new PhoneList<Others > ( );
        }
    }

}
