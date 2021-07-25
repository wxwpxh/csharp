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
    public partial class introChg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["bookid"] = Request.QueryString["bookid"].Trim();
            if (!IsPostBack)
            {
                string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~") + "\\book.mdb";
                DataTable table = new DataTable();                 			//准备接收新的数据集
                string sql = "select * from 书籍 where 商品编号=" + ViewState["bookid"].ToString().Trim();

                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, str);
                adapter.Fill(table);		                                //把数据集填充到table，然后断开与数据源的连接

                if (table.Rows.Count == 0)                                  //如果没有找到bookid下的书籍信息
                {
                    WebHelper.AlertAndRedirect("未找到您要浏览的书籍信息", "bookManage.aspx");
                    return;
                }
                if (table.Rows[0]["图片"].ToString().Trim() != "")
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pathname = "";           //待上传文件完整路径
            string myfileExt = "";          //上传文件的后缀名
            if (File1.PostedFile.ContentLength > 0)
            {
                pathname = File1.PostedFile.FileName.Trim();
                myfileExt=pathname.Substring(pathname.Length - 4, 4);
                if (myfileExt.ToLower() == ".bmp" || myfileExt.ToLower() == ".jpg" || myfileExt.ToLower() == "jpeg")
                { }
                else
                {
                    WebHelper.Alert("请确保上传的图片是jpg或bmp格式");
                    return;
                }
            }
            if (nameTXT.Text.Trim() == "")
            {
                WebHelper.Alert("请输入书籍的名称");
                return;
            }
            if (authorTXT.Text.Trim() == "")
            {
                WebHelper.Alert("请输入作者");
                return;
            }
            if (isDoubleNum(priceTXT.Text) == false)
            {
                WebHelper.Alert("请确保单价为数字型，可以有小数");
                return;
            }
            if (isIntNum(numTXT.Text) == false)
            {
                WebHelper.Alert("请确保库存为数字型，必须为整数");
                return;
            }
            string savefile="";                                     //保存在服务器上的图片文件名
            if (File1.PostedFile.ContentLength > 0)
            {
                Random rnd = new Random();
                string temp = rnd.Next(100, 1000).ToString();   	//生成一个文件名
                savefile = String.Format("{0:yyyyMMhhmmss}", DateTime.Now) + temp + myfileExt;
                string savename = Server.MapPath("uploads") + "\\" + savefile.Trim();
                File1.PostedFile.SaveAs(savename);
            }
            

            string sql = "update  书籍 set 书籍名称='"+nameTXT.Text.Trim()+"',简介='"+introTXT.Text.Trim()+"',作者='"+authorTXT.Text.Trim()+"',出版社='"+chubansheTXT.Text.Trim()+"',出版日期='"+chubanriqiTXT.Text.Trim()+"',版本='"+versionTXT.Text.Trim()+"',单价="+priceTXT.Text.Trim()+",库存="+numTXT.Text.Trim();
            if (savefile.Trim() != "")                              //如果修改时更改了图片
                sql += ",图片='" + savefile.Trim() + "'";
            sql += " where 商品编号=" + ViewState["bookid"].ToString().Trim();
            bool chenggong=ExcuteSql(sql);
            if (chenggong == true)
                WebHelper.AlertAndRedirect("修改成功", "bookManage.aspx");
            else
                WebHelper.Alert("修改失败");
        }

        private bool isDoubleNum(string num)
        {
            try
            {
                Convert.ToDouble(num);
                return true;
            }
            catch {
                return false;
            }
        }
        private bool isIntNum(string num)
        {
            try
            {
                Convert.ToInt32(num);
                return true;
            }
            catch
            {
                return false;
            }
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
                Response.Write("执行失败");                         //ex.ToString());
            }
            conn.Close();
            return chenggong;
        }

        protected void backBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("bookManage.aspx");
        }

    }
}
