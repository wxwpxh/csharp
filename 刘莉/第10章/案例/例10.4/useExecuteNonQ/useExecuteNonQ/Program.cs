using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace useExecuteNonQ
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
                sqlCon.Open();                                  // 打开连接
                string uptStr = @"Update JBQK set JG='宁夏回族自治区' where No='1234000'";  // 向数据表中修改记录
                SqlCommand sqlCmd = new SqlCommand(uptStr, sqlCon);
                sqlCmd.ExecuteNonQuery();           // 执行修改数据
                Console.WriteLine("基本情况数据表修改成功！");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex+"数据修改不成功！");                           // 错误信息
            } 
            sqlCon.Close();                                 // 关闭连接
            Console.WriteLine("数据库正常关闭！");
            Console.Read();
        }
    }
}
