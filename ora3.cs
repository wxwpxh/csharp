//csc  /r:Oracle.DataAccess.dll ora3.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
namespace TestOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            String conn = @"Data Source=ORCL;Persist Security Info=True;User Id=mymotif;Password=wxwpxh";
            String conn1 = String.Format("Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 127.0.0.1)(PORT = 1521))) (CONNECT_DATA =(SERVICE_NAME = lottery) ) );User Id=mymotif;Password=wxwpxh;");
            OracleConnection oc = new OracleConnection(conn);
            try
            {                
                oc.Open();
                OracleCommand cmd = oc.CreateCommand();
                cmd.CommandText = "select sysdate from dual";
                OracleDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    Console.WriteLine(odr.GetDateTime(0).ToString());
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {               
                oc.Close();
            }
            Console.Read();
        }
    }
}
