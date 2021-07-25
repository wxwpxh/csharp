using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// WebHelper 的摘要说明
/// </summary>
public class WebHelper
{
	public WebHelper()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static void Alert(string sMessage)
    {
        HttpContext.Current.Response.Write("<script>alert('" + sMessage + "');</script>");
    }

    public static void AlertAndRefresh(string sMessage)
    {
        HttpContext.Current.Response.Write("<script>alert('" + sMessage + "');location.href=location.href</script>");
    }

    public static void Refresh()
    {
        HttpContext.Current.Response.Write("<script>location.href=location.href</script>");
    }

    public static void AlertAndRedirect(string sMessage, string sURL)
    {
        HttpContext.Current.Response.Write("<script>alert('" + sMessage + "');location.href='" + sURL + "'</script>");
    }

    public static void AlertAndClose(string sMessage)
    {
        HttpContext.Current.Response.Write("<script>alert('" + sMessage + "');window.opener=null;window.close()</script>");
    }

    public static void Close()
    {
        HttpContext.Current.Response.Write("<script>window.opener=null;window.close()</script>");
    }

    public static void ExecJS(string sMessage)
    {
        HttpContext.Current.Response.Write("<script>" + sMessage + "</script>");
    }

    public static void OpenNewIE(string sMessage)
    {
        HttpContext.Current.Response.Write("<script>window.open('1234.aspx','Detail','Scrollbars=no,Toolbar=no,Location=no,Direction=no,Resizeable=no,Width=400 ,Height=200,top=0,left=400');</script>");
    }

    public static string GetPcAccount()
    {
        return HttpContext.Current.User.Identity.Name;
    }

    public static string GetCurrentUser()
    {
        string strUserId = HttpContext.Current.Session["UserId"] == null ? "" : HttpContext.Current.Session["UserId"].ToString();
        if (0 == strUserId.Length)
        {
            strUserId = HttpContext.Current.Request.QueryString["UserId"] == null ? "" : HttpContext.Current.Request.QueryString["UserId"];

        }
        return strUserId;
    }

    public static string Encode(string sData)
    {
        string s = sData;
        s = s.Replace("<", "&lt;");
        s = s.Replace(">", "&gt;");
        s = s.Replace(" ", "&nbsp;");
        s = s.Replace("\r\n", "<br>");
        return s;
    }

   
    
}
