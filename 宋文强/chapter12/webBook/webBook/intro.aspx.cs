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
    public partial class intro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string pathname = "";  //待上传文件完整路径
            string myfileExt = "";   //上传文件的后缀名
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
            string savefile="";  //保存在服务器上的图片文件名
            if (File1.PostedFile.ContentLength > 0)
            {
                Random rnd = new Random();
                string temp = rnd.Next(100, 1000).ToString();   	//生成一个文件名
                savefile = String.Format("{0:yyyyMMhhmmss}", DateTime.Now) + temp + myfileExt;
                string savename = Server.MapPath("uploads") + "\\" + savefile.Trim();
                File1.PostedFile.SaveAs(savename);
            }

            string sql = "insert into 书籍(书籍名称,简介,作者,出版社,出版日期,版本,单价,库存,图片) values('" + nameTXT.Text.Trim() + "','" + introTXT.Text.Trim() + "','" + authorTXT.Text.Trim() + "','"+chubansheTXT.Text.Trim()+"','"+chubanriqiTXT.Text.Trim()+"','" + versionTXT.Text.Trim() + "'," + priceTXT.Text.Trim() + "," + numTXT.Text.Trim() + ",'" + savefile.Trim() + "')";
            bool chenggong=ExcuteSql(sql);
            if (chenggong == true)
                WebHelper.AlertAndRedirect("添加成功","bookManage.aspx");
            else
                WebHelper.Alert("添加失败");
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
                Response.Write("执行失败");//ex.ToString());
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
