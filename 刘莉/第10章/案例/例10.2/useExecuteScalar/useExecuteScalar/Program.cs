using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace useExecuteScalar
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
                string sqlStr = @"select count(*) from JBQK";                   // 查询数据表中的记录条数
                SqlCommand sqlCmd = new SqlCommand(sqlStr, sqlCon);
                                                                                                           // 执行命令
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());      // 返回的记录数目强制转换成整型
                Console.WriteLine("基本情况数据表中的记录共有{0}条。",count );
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("数据库连接失败！");
            }
            sqlCon.Close();                                                                  // 关闭连接
            Console.WriteLine("数据库正常关闭！");
            Console.Read();
        }
    }
}
