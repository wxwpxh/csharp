using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data ;
using System.Windows.Forms;
namespace useDataBase
{
    class DBCon
    {
        // 连接字符串
        public string strCon = @"Data Source=.;  Initial Catalog = TestDB; Integrated Security = True";
        public SqlConnection sqlCon=new SqlConnection ();           // SQL Server数据库的连接
        public SqlDataAdapter sda=new SqlDataAdapter ();              // 数据适配器
        public DataSet ds=new DataSet ();                            // 数据集
        public DataTable dt=new DataTable ();                        // 内在中数据的一个表
        public SqlDataReader sdr ;                                  // SQL数据阅读器
        // 数据库连接方法
        public void dbcon()
        {
            try
            {
                // 数据库的一个打开的连接
                sqlCon = new SqlConnection(strCon);
            }
            catch (Exception e)
            {
                MessageBox .Show ("数据库连接不成功："+e.ToString ());
            }
        }
        // 填充数据集方法
        public void dbFill(string selstr)
        {
            dt.Clear();         // 清空数据表
            sda = new SqlDataAdapter(selstr, strCon);
            // 填充数据集，实质是填充ds中的第0个表
            sda.Fill(ds, "JBQK");
            dt = ds.Tables["JBQK"];
        }
        // 判断数据查询是否成功方法
        public void  dbSelect(string showInfo)
        {
            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand(showInfo , sqlCon);
            sdr = sqlcmd.ExecuteReader();
        }
        // 数据插入数据库方法
        public void dbInsert(string insertInfo)
        {
            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand(insertInfo, sqlCon);
            try
            {
                sqlcmd.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("数据插入失败"+e.ToString ());
            }
            sqlCon.Close();
        }
        // 数据集的更新与数据库关联方法
        public void dbGridViewUpd()
        {
            // 将DataSet所做的更改与关联的SQL Server数据库的更改相协调
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DialogResult result;        // 信息框的返回值
            result = MessageBox.Show("确定保存修改过的数据吗？",
                "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                dt = ds.Tables["JBQK"];
                sda.Update(dt);         // 更新数据库
                dt.AcceptChanges();     // 接受更新
            }
        }
        // 数据修改方法
        public void dbUpdate(string updStr)
        {
            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand(updStr, sqlCon);
            try
            {
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("数据修改成功!");
            }
            catch (Exception e)
            {
                MessageBox.Show("数据修改失败"+e.ToString ());
            }
            sqlCon.Close();
        }
        // 数据删除方法
        public void dbDelete(string delStr)
        {
            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand(delStr , sqlCon);
            try
            {
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("数据删除成功!");
            }
            catch (Exception e)
            {
                MessageBox.Show("数据删除失败" + e.ToString());
            }
            sqlCon.Close();
        }
    }
}
