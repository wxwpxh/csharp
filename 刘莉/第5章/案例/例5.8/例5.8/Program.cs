using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 例5._8
{
    // 添加命名空间引用
    using System.Collections.Generic;
    struct Student     		// 定义结构类型
    {
        public int sno;      	// 学号
        public string sname; 	// 姓名
    };
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            List<Student> myset = new List<Student>();
            // myset.Add(3); // 编译错误:无法从int转换为Student
            Student s1 = new Student();
            s1.sno = 101; s1.sname = "李明";
            myset.Add(s1);
            Student s2 = new Student();
            s2.sno = 103; s2.sname = "王华";
            myset.Add(s2);
            Student s3 = new Student();
            s3.sno = 108; s3.sname = "张英";
            myset.Add(s3);
            Student s4 = new Student();
            s4.sno = 105; s4.sname = "张伟";
            myset.Add(s4);
            Console.WriteLine("元素序列:");
            Console.WriteLine("  下标  学号  姓名");
            i = 0;
            foreach (Student st in myset)
            {
                Console.WriteLine("   {0}    {1}   {2}", i, st.sno, st.sname);
                i++;
            }
            Console.WriteLine("容量: {0}", myset.Capacity);
            Console.WriteLine("元素个数: {0}", myset.Count);
            Console.WriteLine("在索引2处插入一个元素");
            Student s5 = new Student();
            s5.sno = 106; s5.sname = "陈兵";
            myset.Insert(2, s5);
            Console.WriteLine("元素序列:");
            Console.WriteLine("  下标  学号  姓名");
            i = 0;
            foreach (Student st in myset)
            {
                Console.WriteLine("   {0}    {1}   {2}", i, st.sno, st.sname);
                i++;
            }
        }
    }

}
