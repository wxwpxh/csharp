using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient ;
namespace useExecuteReader
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
                sqlCon.Open();                                                                 // 打开连接
                string sltStr = @"select No, Name, Grade from JBQK";   // 查询数据表中记录
                string sltResult="";                                                            // 存储查询结果
                int i=1;                                                                               // 记录条数
                SqlCommand sqlCmd = new SqlCommand(sltStr, sqlCon);
                SqlDataReader reader=sqlCmd .ExecuteReader ();            // 获取数据
                Console.WriteLine("基本情况数据表查询结果：");
                if (reader.HasRows)                                 // 判断SqlDataReader对象中是否有数据
                {
                    while (reader.Read())
                    {
                        // 记录每一条记录
                        sltResult += "第" + i.ToString() + "条记录：" + reader["No"].ToString() +
                            reader["Name"].ToString() + reader["Grade"].ToString() + "\n";
                        i++;
                    }
                    Console.WriteLine(sltResult);
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);                   // 错误信息
            }
            sqlCon.Close();                                                                  // 关闭连接
            Console.WriteLine("数据库正常关闭！");
            Console.Read();
        }
    }
}
