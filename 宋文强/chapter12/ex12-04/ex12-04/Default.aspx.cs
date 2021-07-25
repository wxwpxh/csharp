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
//网页打开后，以列表形式分页显示student.mdb数据库中“学生基本情况表”的内容。
namespace ex12_04
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.Visible = false;				//网页加载时使图片框不可见
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int selIndex = Convert.ToInt32(e.CommandArgument);//获得按钮被单击的数据行号
            if (e.CommandName == "showPicture")	//“查看照片”按钮被单击
            {
                Image1.Visible = true;			//使图片框可见
                GridView1.SelectedIndex = selIndex;
                Image1.ImageUrl = "~/images/" + GridView1.SelectedRow.Cells[0].Text + ".jpg";
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int selIndex = Convert.ToInt32(e.CommandArgument);//获得按钮被单击的数据行号
            //if (e.CommandName == "showPicture")	//“查看照片”按钮被单击
            //{
            //    Image1.Visible = true;			//使图片框可见
            //    GridView1.SelectedIndex = selIndex;
            //    Image1.ImageUrl = "~/images/" + GridView1.SelectedRow.Cells[0].Text + ".jpg";
            //}

        }
    }
}
