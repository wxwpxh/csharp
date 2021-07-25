using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;

namespace webBook
{
    public partial class bookManange : System.Web.UI.Page
    {
        OleDbDataAdapter adapter;					//在事件过程之前创建DataAdapter的实例
        DataTable table = new DataTable();			//创建DataTable的实例
        protected void Page_Load(object sender, EventArgs e)
        {
            SetBind();
        }

        //将数据库中的书籍信息绑定到GridView控件上
        private void SetBind()
        {
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~") + "\\book.mdb";
            table = new DataTable();                 			//清除table,准备接收新的数据集
            string sql = "select * from 书籍 order by 商品编号";

            adapter = new OleDbDataAdapter(sql, str);
            adapter.Fill(table);		    //把数据集填充到table，然后断开与数据源的连接
            this.GridView1.DataSource = table;			//在dataGridView1中显示数据集的内容
            GridView1.DataBind();

        }

        //GridView控件（书籍列表）中修改、删除键的事件
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Trim() == "修改")
            {
                string id = GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)].Value.ToString();
                Response.Redirect("introChg.aspx?bookid=" + id.Trim());
            }
            if (e.CommandName.Trim() == "删除")
            {
                string id = GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)].Value.ToString();
                string sql = "delete from 书籍 where 商品编号=" + id.Trim();
                ExcuteSql(sql);
                SetBind();
            }
        }

        //GridView控件（书籍列表）中书名列表下建立超级链接，链接地址为introShow.aspx
        protected string urlChakan(string bookid, string text)
        {
            string url = "introShow.aspx?bookid=" + bookid.Trim();
            return "<a href=" + url + " target=_blank >" + text.Trim() + "</a>";
        }


        //执行insert、update的sql语句
        public bool ExcuteSql(string sql)
        {
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~") + "\\book.mdb";
            OleDbConnection conn = new OleDbConnection(str);
            conn.Open();
            bool chenggong = false;
            try
            {
                OleDbCommand CMD = new OleDbCommand(sql, conn);
                CMD.ExecuteNonQuery();
                chenggong = true;
            }
            catch (Exception ex)
            {
                Response.Write("执行失败");//ex.ToString());
            }
            conn.Close();
            return chenggong;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //点击删除时，提示是否删除对话框
            if ((e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate) && e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton delBttn = (LinkButton)e.Row.Cells[8].Controls[0];
                delBttn.Attributes.Add("onclick", "javascript:return confirm('确定是否删除书名为" + DataBinder.Eval(e.Row.DataItem, "书籍名称") + "的记录?');");
            }
        }
        
    }
}
