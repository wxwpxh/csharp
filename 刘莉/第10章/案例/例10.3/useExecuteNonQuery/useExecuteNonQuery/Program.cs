using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace useExecuteNonQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            // 连接字符串
            string strCon =
                @"Data Source = DataServer; Initial Catalog = TestDB; Integrated Security = True;";
            SqlConnection sqlCon = new SqlConnection(strCon);       // 执行连接
            try
            {
                sqlCon.Open();                                                                   // 打开连接
                string istStr = @"insert into JBQK(No, Name, XB, Grade, JG) "+
                    "values('201204036', '张小明', '男', '1204', '重庆市')";                   // 向数据表中插入记录
                SqlCommand sqlCmd = new SqlCommand(istStr, sqlCon);
                sqlCmd .ExecuteNonQuery ();      // 执行插入命令
                Console.WriteLine("基本情况数据表中插入记录成功！");
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex+"数据库连接失败！");                   // 错误信息
            } 
            sqlCon.Close();                                                                  // 关闭连接
            Console.WriteLine("数据库正常关闭！");
            Console.Read();
        }
    }
}
