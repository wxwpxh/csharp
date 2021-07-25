using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 例9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 绑定到指定目录
            DirectoryInfo dir = new DirectoryInfo(@"d:\C#程序设计\testing");
            try
            {
                //判断待创建的目录是否存在
                if (dir.Exists)
                {
                    Console.WriteLine("{0}已存在", dir.FullName);
                    dir.Delete();
                    Console.WriteLine("已成功删除，请重新创建新目录");
                }
                dir.Create();// 创建目录
                Console.WriteLine("***** Directory Info *****");
                Console.WriteLine("FullName: {0} ", dir.FullName);
                Console.WriteLine("Name: {0} ", dir.Name);
                Console.WriteLine("Parent: {0} ", dir.Parent);
                Console.WriteLine("Creation: {0} ", dir.CreationTime);
                Console.WriteLine("Attributes: {0} ", dir.Attributes);
                Console.WriteLine("Root: {0} ", dir.Root);
                Console.WriteLine("**************************\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("目录操作失败：{0}", ex.ToString());
            }

        }
    }
}
