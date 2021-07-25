//csc /r:MySql.Data.dll mysql1.cs

using System;
using MySql.Data.MySqlClient;   //导入引用，并且添加命名空间

namespace CSharpContextMysql_1
{
    class Program
    {       
        static void Main(string[] args)
        {

            ReadSQL();
            //InsertSQL();
            //UpdateSQL();
            //DeleteSQL();
 
            Console.ReadKey();
        }

        /// <summary>
        /// 读取数据库中的数据
        /// </summary>
        static void ReadSQL()
        {
          string connectStr = "server=127.0.0.1;port=3306;database=mymotif;user=mymotif;password=wxwpxh;";
          //并没有建立数据库连接
          MySqlConnection conn = new MySqlConnection(connectStr);
            try
            {
                conn.Open();    //建立连接，打开数据库
                Console.WriteLine("打开数据库成功");

                string sqlstr = "select * from STUDENT";   //SQL语句
                MySqlCommand cmd = new MySqlCommand(sqlstr, conn);
                /* cmd.ExecuteReader();     //执行一些查询
                   cmd.ExecuteScalar();     //执行一些查询，返回一个单个的值
                   cmd.ExecuteNonQuery();   //插入删除   */

                //相当于数据读出流  理解为一个学生
                MySqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();  //读取下一页数据 ，读取成功，返回true，下一页没有数据则返回false表示到了最后一页

                while (reader.Read())   //遍历表中数据
                {
                    //读取并打印数据
                    reader.Read();
                    //索引是一行有几个数据
                    Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString() + reader[3].ToString());
                    //还可以使用Getxxx方式去写 参数（索引）
                    Console.WriteLine(reader.GetString(0) + reader.GetString(1) + reader.GetString(2));
                    //Getxxx方法的重载  参数(列名)
                    Console.WriteLine(reader.GetString("SNO") + reader.GetString("SNAME") + reader.GetString("SEX"));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();   //关闭连接
            }
        }
    }

}