using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //file类：类中的成员为静态成员
            string path1 = @"d:\csharp\source.txt";
            string path2 = @"d:\csharp\dest.txt";
            if (!File.Exists(path1))
            {
                //File所有方法都是静态的，调用时需要传入目录路径参数。
                FileStream f = File.Create(path1);
                if (File.Exists(path1))
                {
                    Console.WriteLine("---------------文件创建成功-------------");
                    Console.WriteLine("文件{0}创建成功！", path1);
                    Console.WriteLine("文件名:" + f.Name);
                    Console.WriteLine("文件的大小：" + f.Length);
                }
                else
                    Console.WriteLine("文件{0}创建失败！", path1);
                f.Close();//关闭文件
            }
            else
            {
                Console.WriteLine("{0}文件已存在！", path1);
            }
            Console.WriteLine("---------------移动文件-------------");
            if (!File.Exists(path2))
            {
                Console.WriteLine("若目标文件{0}不存在，则移动。", path2);
                File.Move(path1, path2);
            }
            else
            {
                Console.WriteLine("目标文件{0}存在，无法移动。", path2);
            }          

            
        }
    }
}
