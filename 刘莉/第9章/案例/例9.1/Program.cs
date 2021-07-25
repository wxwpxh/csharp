using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 例9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("驱动器{0}", d.Name);//驱动器的名称
                Console.WriteLine("  类型{0}", d.DriveType);//驱动器的类型
                if (d.IsReady == true)
                {
                    Console.WriteLine("  卷标:{0}", d.VolumeLabel);//驱动器的卷标
                    Console.WriteLine("  文件系统:{0}", d.DriveFormat);//NTFS或FAT32
                    Console.WriteLine("  当前用户可用空间:{0}", d.AvailableFreeSpace);
                    Console.WriteLine("  可用空间:{0}", d.TotalFreeSpace);
                    Console.WriteLine("  磁盘总大小:{0}", d.TotalSize);
                }
            }
        }
    }
}
