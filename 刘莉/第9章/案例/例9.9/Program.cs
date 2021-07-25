using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace 例9._9
{
    class Program
    {
        static void Main(string[] args)
        {            
           string strContent = "Welcome to the new world!\n" +
                    "Wish you have a good day!\n" +
                    "This is the end!\n";
           Console.WriteLine("原始文本内容如下\n");
            Console.WriteLine("{0}", strContent);
            // 将strContent转换为大写字母并创建一个连续的段落
            string strLine, strP = null;
            StringReader strReader = new StringReader(strContent);
            while (true)
            {
                strLine = strReader.ReadLine();
                if (strLine != null)
                {
                   strP = strP + strLine.ToUpper()+" ";
                }
                else
                {
                    strP = strP + "\n";
                    break;
                }
            }
            Console.WriteLine("修改后内容\n");
            Console.WriteLine("{0}", strP);
            // 从连续的段落strP恢复原始文本内容strContent.
            int iCh;
            char convertedCh;
            StringWriter strWriter = new StringWriter();
            strReader = new StringReader(strP);
            bool flag = true;
            while (true)
            {
                iCh = strReader.Read();
                // 转换成字符前，检查字符串是否结束.
                if (iCh == -1) break;
                convertedCh = Convert.ToChar(iCh);
                if (convertedCh == '!') //一个句子后加入2个回车换行
                {
                    strWriter.Write(convertedCh); 
                    strWriter.Write("\n");
                    // 忽略句子间的空格.
                    strReader.Read();
                    strReader.Read();
                    flag = true;
                }
                else
                {
                    //每行第一个字母大写，其余小写
                    if (flag)                  
                        strWriter.Write(convertedCh);                  
                    else                    
                        strWriter.Write(char.ToLower(convertedCh));
                    flag = false;
                }
            }
            Console.WriteLine("还原后的原始文本内容\n");
            Console.WriteLine("{0}", strWriter.ToString());                 
        }
    }
}
