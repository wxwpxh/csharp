using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace 例9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"d:\csharp\source.txt";
            string path1 = @"d:\copyto.txt";
            try
            {
                FileInfo fi = new FileInfo(path);
                Console.Write("文件{0}是否存在：", path);
                Console.WriteLine(fi.Exists.ToString());
                // 如果文件不存在则创建
                if (!fi.Exists)
                {
                    FileStream fs = fi.Create();  // 创建文件
                    Console.WriteLine("--------------文件{0}创建成功---------------", path);
                    Console.WriteLine("文件名：{0}", fs.Name);
                    Console.WriteLine("文件的创建时间：{0}", fi.CreationTime);
                    Console.WriteLine("文件的长度：{0}", fs.Length);
                }
                Console.WriteLine("--------------复制文件---------------");
                Console.WriteLine("将{0}复制到{1}", path, path1);
                fi.CopyTo(path1, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
