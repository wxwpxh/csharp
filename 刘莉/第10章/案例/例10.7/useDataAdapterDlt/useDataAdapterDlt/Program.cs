using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace useDataAdapterDlt
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
                string sltStr = @"Select No, Name, Grade from JBQK";  // 查询数据表中的记录
                SqlCommand sqlCmd = new SqlCommand(sltStr, sqlCon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);                       // 填充数据集，实质是填充ds中的第0个表
                // 以sda为参数来初始化SqlCommandBuilder实例
                SqlCommandBuilder scb = new SqlCommandBuilder(sda);
                ds.Tables[0].Rows[0].Delete();  // 删除DataSet中数据表JBQK中第一行数据
                // 调用Update方法，以DataSet中的数据更新数据库
                sda.Update(ds, ds.Tables[0].ToString ());
                ds.Tables[0].AcceptChanges();
                string sltResult = "";          // 查询结果字符串
                DataTable dt = ds.Tables[0];
                Console.WriteLine("基本情况数据表查询结果如下：");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // 逐行读取，每行通过字段名字或者索引来访问
                    sltResult += "第" + (i + 1) + "条记录：" + dt.Rows[i][0].ToString() + "\t" +
                        dt.Rows[i]["Name"].ToString() + dt.Rows[i][2].ToString() + "\n";
                }
                Console.WriteLine(sltResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);                           // 错误信息
            }
            Console.WriteLine("数据库读取完毕！");
            Console.Read();
        }
    }
}
