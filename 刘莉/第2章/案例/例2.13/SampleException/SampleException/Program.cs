using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SampleException
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter write = null;
            try
            {
                //新建文本文件或覆盖已有文件，并写入文本
                write = File.CreateText(@"C:\welcome.txt");
                write.WriteLine("欢迎来到C# World!");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (write != null)
                    write.Close();
            }
            Console.ReadLine();

        }
    }
}