// csc /r:Npgsql.dll psql1.cs

using System;
using Npgsql;

namespace PostgreConnect
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello PostgreSQL");

            // Host info
            var connString = "Host=127.0.0.1;Port=5432;Username=mymotif;Password=wxwpxh;Database=mymotif";
			//@"PORT=5432;DATABASE=mymotif;HOST=127.0.0.1;PASSWORD=wxwpxh;User id=mymotif" ;
			NpgsqlConnection conn = new NpgsqlConnection(connString);
		    try{
					conn.Open();
					// Retrieve all rows
					using (var cmd = new NpgsqlCommand("select * from student", conn))
					using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        Console.WriteLine(reader.GetString(0));

				
			}
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();   //关闭连接
            }

        }//Main
    }
}
