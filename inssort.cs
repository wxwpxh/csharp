using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void InsertSort(int[] dataArray)
        {
            
            for (int i = 1; i < dataArray.Length; i++) //从数组拿第二个值dataArray[1]和dataArray[0]比较大小，循环至整个数组排好序
            {
                bool isInsert = false;              //标志，判断是否插过了
                int iValue = dataArray[i];          //保存当前需要比对的值dataArray[i] 为 iValue，防止移动数据时被覆盖
                for (int j = i - 1; j >= 0; j--)    // 将dataArray[i]和它前面的的所有值作比较
                {
                    if(dataArray[j] > iValue)       //如果 当前遍历位置的值 dataArray[j] > iValue
                    {
                        dataArray[j + 1] = dataArray[j]; //就把 当前遍历位置的值 dataArray[j] 向后移动一位
                    }
                    else                            //如果 当前遍历位置的值 dataArray[j] < iValue
                    {
                        dataArray[j + 1] = iValue;  //就把 iValue 放到 dataArray[j] 后面 即 dataArray[j + 1]位置
                        isInsert = true;
                        break;                      //一定要记得加break,否则，会插很多次，值会覆盖混乱
                    }
                }
                if (!isInsert)                      //经过循环，标志false显示未被插入，证明iValue是比它前面的值都小，故将其放入数组0号位置
                {
                    dataArray[0] = iValue;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] dataArray = new int[] { 1, 5, 3, 2, 7, 9, 4, 6, 8};
            InsertSort(dataArray);
            foreach(var temp in dataArray)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
} 