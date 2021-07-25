using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// 添加命名空间引用
using System.Data.SqlClient;
namespace useConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            // 连接字符串
            string strCon =
                @"Data Source = .; Initial Catalog = TestDB; Integrated Security = True;";
            SqlConnection sqlCon = new SqlConnection(strCon);       // 执行连接
            sqlCon.Open();                                                                   // 打开连接
            Console.WriteLine("数据库TestDB连接成功！");
            Console.WriteLine("数据库连接状态为：{0}",sqlCon .State .ToString ());
                                                                                                       // 连接状态
            sqlCon.Close();                                                                  // 关闭连接
            Console.WriteLine("数据库正常关闭！");
            Console.Read();
        }
    }
}
