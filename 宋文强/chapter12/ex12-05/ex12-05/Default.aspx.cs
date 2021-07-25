using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
//将表单内容提交到服务器，作为一条新的学生记录添加到数据库student.mdb的学生基本情况表中，同时将这位学生的照片添加到网站images文件夹内。
namespace ex12_05
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string savefile = myNumber.Text.Trim() + ".jpg";
                SqlDataSource1.Insert();
                myNumber.Text = "";
                myName.Text = "";
                myHome.Text = "";
                myScore.Text = "";
                mySex.Text = "";
                mySubject.Text = "";
                Label1.Text = "新记录添加成功！";
                myPhoto.SaveAs(Server.MapPath("~/images/" + savefile));
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
        }
    }
}
