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
using System.Data.OleDb;
using System.Text;


namespace webBook
{
    public partial class _Default : System.Web.UI.Page
    {
        OleDbDataAdapter adapter;					//在事件过程之前创建DataAdapter的实例
        DataTable table = new DataTable();			//创建DataTable的实例
        protected void Page_Load(object sender, EventArgs e)
        {
            SetBind();
            BuyBtn.Attributes.Add("onclick", "javascript:return confirm('您确定要将购物车内的书籍买下？\\n\\n不能取消')");

            if (!IsPostBack)                                    //第一次进入时，先清空正式购物单中的数据
            {
                string sql = "delete from 正式购物单 where IPAdr='" + GetIP().Trim() + "'";//删除正式购物单中的所有数据
                ExcuteSql(sql);
            }
        }

        //将数据库中的书籍信息、购物车、正式购物单数据分别绑定到GridView1,GridView2,GridView3控件上
        private void SetBind()
        {
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~") + "\\book.mdb";
            
            table = new DataTable();                 			//清除table,准备接收新的数据集
            string sql = "select * from 书籍 order by 商品编号";
            adapter = new OleDbDataAdapter(sql, str);           //把“书籍”表中的内容读到DataAdapter对象中
            adapter.Fill(table);		                        //把数据集填充到table，然后断开与数据源的连接
            this.GridView1.DataSource = table;			        //在dataGridView1中显示数据集的内容
            GridView1.DataBind();


            //临时购物车
            table = new DataTable();
            sql = "select a.商品编号,b.书籍名称,a.数量,b.单价 from 临时购物车 a inner join 书籍 b on a.商品编号=b.商品编号 where a.IPAdr='" + GetIP().Trim() + "' order by a.商品编号";
            adapter = new OleDbDataAdapter(sql, str);
            adapter.Fill(table);		                        //把数据集填充到table，然后断开与数据源的连接
            this.GridView2.DataSource = table;			        //在dataGridView1中显示数据集的内容
            GridView2.DataBind();
            double jiage = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                jiage += Convert.ToDouble(table.Rows[i]["数量"].ToString()) * Convert.ToDouble(table.Rows[i]["单价"].ToString());
            }
            Label2.Text = "总计：" + jiage.ToString() + "元";

            //正式购物单
            table = new DataTable();
            sql = "select a.商品编号,b.书籍名称,a.数量,b.单价 from 正式购物单 a inner join 书籍 b on a.商品编号=b.商品编号 where a.IPAdr='" + GetIP().Trim() + "' order by a.商品编号";
            adapter = new OleDbDataAdapter(sql, str);
            adapter.Fill(table);		                        //把数据集填充到table，然后断开与数据源的连接
            GridView3.DataSource = table;			            //在dataGridView1中显示数据集的内容
            GridView3.DataBind();
            jiage = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                jiage += Convert.ToDouble(table.Rows[i]["数量"].ToString()) * Convert.ToDouble(table.Rows[i]["单价"].ToString());
            }
            Label3.Text = "总计：" + jiage.ToString() + "元";
        }


        protected void BuyBtn_Click(object sender, EventArgs e)
        {
            //得到临时购物车中的所有数据
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~") + "\\book.mdb";
            table = new DataTable();
            string sql = "select a.商品编号,b.书籍名称,a.数量 from 临时购物车 a inner join 书籍 b on a.商品编号=b.商品编号  where a.IPAdr='" + GetIP().Trim() + "' order by a.商品编号";
            adapter = new OleDbDataAdapter(sql, str);
            adapter.Fill(table);		                        //把数据集填充到table，然后断开与数据源的连接

            sql = "delete from 正式购物单 where IPAdr='" + GetIP().Trim() + "'";//删除正式购物单中的所有数据
            ExcuteSql(sql);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                sql = "insert into 正式购物单(商品编号,数量,IPAdr) values(" + table.Rows[i]["商品编号"].ToString() + "," + table.Rows[i]["数量"].ToString() + ",'" + GetIP().Trim() + "')";
                ExcuteSql(sql);
            }
            sql = "delete from 临时购物车 where IPAdr='" + GetIP().Trim() + "'";
            ExcuteSql(sql);
            SetBind();
        }

        protected void ClearBtn_Click(object sender, EventArgs e)
        {
            //得到临时购物车中的所有数据
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~") + "\\book.mdb";
            table = new DataTable();
            string sql = "select a.商品编号,b.书籍名称,a.数量 from 临时购物车 a inner join 书籍 b on a.商品编号=b.商品编号 where a.IPAdr='" + GetIP().Trim() + "' order by a.商品编号";
            adapter = new OleDbDataAdapter(sql, str);
            adapter.Fill(table);		                        //把数据集填充到table，然后断开与数据源的连接

            for (int i = 0; i < table.Rows.Count; i++)
            {
                sql = "update 书籍 set 库存=库存+" + table.Rows[i]["数量"].ToString() + " where 商品编号=" + table.Rows[i]["商品编号"].ToString().Trim();
                ExcuteSql(sql);
            }
            sql = "delete from 临时购物车 where IPAdr='" + GetIP().Trim() + "'";
            ExcuteSql(sql);
            SetBind();
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

        //判断临时购物车中，是否已经有此商品
        public bool existBook(string bookid)
        {
            string str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~") + "\\book.mdb";
            table.Clear();                  			    //清除table,准备接收新的数据集
            string sql = "select * from 临时购物车  where 商品编号="+bookid.Trim()  +" and IPAdr='" + GetIP().Trim() + "'";

            adapter = new OleDbDataAdapter(sql, str);
            adapter.Fill(table);		                    //把数据集填充到table，然后断开与数据源的连接
            if (table.Rows.Count > 0)                       //若已经有了，则返回true
                return true;
            else
                return false;
        }

        //GridView控件（书籍列表）中“放入购物车”键的事件
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Trim() == "放入购物车")
            {
                string id = GridView1.DataKeys[Convert.ToInt32(e.CommandArgument)].Value.ToString();
                errLBL.Text = "";
                GridViewRow row = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];//选择的行
                int kucun = Convert.ToInt32(((Label)row.FindControl("kucunLBL")).Text);//商品库存
                if (kucun > 0)                              //如果还有库存
                {
                    string sql = "";
                    if (existBook(id.Trim()) == true)       //若在临时购物车中已有此商品，
                    {
                        sql = "update 临时购物车 set 数量=数量+1 where 商品编号=" + id.Trim() +" and IPAdr='" + GetIP().Trim() + "'";//则在临时购物车的该商品条目的数量字段上增加一个
                        ExcuteSql(sql);
                    }
                    else                                     //若在临时购物车中尚未有此商品
                    {
                        sql = "insert into 临时购物车(商品编号,数量,IPAdr) values(" + id.Trim() + ",1,'" + GetIP().Trim() + "')";//则在临时购物车中增加一条此商品的记录
                        ExcuteSql(sql);
                    }
                    sql = "update 书籍 set 库存=库存-1 where 商品编号 =" + id.Trim();//将书籍表中相应的商品数量减少一个
                    ExcuteSql(sql);

                    SetBind();
                }
                else                                        //如果没有库存
                {
                    errLBL.Text = "此商品已无库存";
                    
                }
            }            
        }

        //GridView控件（书籍列表）中书名列表下建立超级链接，链接地址为introShow.aspx
        protected string link(string bookid,string bookname)
        {
            string url = "introShow.aspx?bookid=" + bookid.Trim(); 
            return "<a href=" + url + " target=_blank >" + bookname.Trim() + "</a>";
        }

        //得到当前登陆者的IP地址
        private string GetIP()
        {
            string stringIP = "";
            stringIP = Page.Request.UserHostAddress;
            return stringIP;
        }
    }
}
