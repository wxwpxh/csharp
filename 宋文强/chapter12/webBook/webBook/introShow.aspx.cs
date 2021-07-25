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

namespace webBook
{
    public partial class introShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string bookid = Request.QueryString["bookid"].Trim();       //接收调用网页传递过来的“商品编号”

            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~") + "\\book.mdb";
            DataTable table = new DataTable();                 			//准备接收新的数据集
            string sql = "select * from 书籍 where 商品编号=" + bookid.Trim();

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, str);  //按指定的商品编号查询，获得数据集
            adapter.Fill(table);		                                //把数据集填充到table，然后断开与数据源的连接

            if (table.Rows.Count == 0)                                  //如果没有找到bookid下的书籍信息
            {
                WebHelper.AlertAndRedirect("未找到您要浏览的书籍信息","default.aspx");
                return;
            }
            if (table.Rows[0]["图片"].ToString().Trim()!="")            //如果有封面图片文件，则显示
                Image1.ImageUrl = "uploads/" + table.Rows[0]["图片"].ToString();
            nameTXT.Text = table.Rows[0]["书籍名称"].ToString().Trim();
            authorTXT.Text = table.Rows[0]["作者"].ToString().Trim();
            introTXT.Text = table.Rows[0]["简介"].ToString().Trim();
            chubansheTXT.Text = table.Rows[0]["出版社"].ToString().Trim();
            chubanriqiTXT.Text = table.Rows[0]["出版日期"].ToString().Trim();
            versionTXT.Text = table.Rows[0]["版本"].ToString().Trim();
            priceTXT.Text = table.Rows[0]["单价"].ToString().Trim();
            numTXT.Text = table.Rows[0]["库存"].ToString().Trim();
        }

        protected void closeBtn_Click(object sender, EventArgs e)
        {
            WebHelper.Close();
        }
    }
}
