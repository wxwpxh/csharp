using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 例9._3
{//direcory类的操作
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"d:\csharp\mydir";
            string path2 = @"d:\csharp\mydestdir";
            //string path3 = @"d:\csharp\mydestdir";
            try
            {
                //获取应用程序的当前工作目录，及上次访问和写入的时间
                Console.WriteLine("应用程序当前工作目录为：{0}", Directory.GetCurrentDirectory());
                Console.WriteLine("上次访问当前工作目录的时间为：{0}",Directory .GetLastAccessTime (Directory .GetCurrentDirectory ()));
                if (Directory.Exists(path1))
                {
                    Console.WriteLine(path1 + "已存在");
                }
                else
                {
                    Console.WriteLine("目录不存在，准备创建");
                    DirectoryInfo dir=Directory.CreateDirectory(path1);//创建目录
                    DateTime dtime = new DateTime(2012,3,29);
                    //设置指定目录的创建时间
                    Directory.SetCreationTime(path1,dtime );
                }
                Console.WriteLine("目录创建时间为：{0}", Directory.GetCreationTime(path1)); //目录的创建时间
               // Console.WriteLine("其根目录是：{0}",Directory .GetDirectoryRoot (path1 ));
                Console.WriteLine("************************************************\n");
                if (!Directory.Exists(path2))//目标目录不存在时，才可以执行move操作
                {
                    Console.WriteLine("目标目录不存在时可以执行重命名操作！");
                    Directory.Move(path1, path2);//??
                    Console.WriteLine("{0}重命名为{1},成功！\n", path1, path2);
                }
                else
                {
                    Console.WriteLine("要重命名的目标目录已存在，不允许操作！\n");
                }
                Console.WriteLine("************************************************\n");
                //获取当前工作目录的父目录
                string root = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory());
                string[] subdirectory = Directory.GetDirectories (root);
                foreach (string path in subdirectory)
                {
                    Console.WriteLine(path );
 
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("操作失败：{0}", e.ToString());
            }
            
        }
    }
}
