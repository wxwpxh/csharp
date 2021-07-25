<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="webBook._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>网上书店</title>
    <link href="css/css.css" type="text/css" rel="stylesheet" /> 
    <style type="text/css">
     p.MsoNormal
	    {margin:0cm;
	    margin-bottom:.0001pt;
	    text-align:justify;
	    text-justify:inter-ideograph;
	    font-size:10.5pt;
	    font-family:"Times New Roman";}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; width: 256px; height: 39px; z-index: 1; left: 435px; top: 69px" border="0">
        <p align="center" class="MsoNormal">
            <b><span style="font-size: 20pt; font-family: 楷体_GB2312; color: #FFFFFF">在线购物</span></b></p>
    </div>
    <div>        
    <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#E1E1E1">
        <tr>
            <td><img src="images/top1.gif" width="1000" height="121" alt="顶部图片" /></td>
        </tr>  
        <tr>
            <td align="center">
                <table width="100%" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td width="50" rowspan="2" valign="top"><img src="images/top4.gif" width="50" height="29" alt="顶部左下角"/></td>
                        <td width="158" rowspan="2" valign="top" bgcolor="#FFFFFF"><img src="images/top2.gif" width="158" height="90" alt="顶部图书标记"/></td>
                        <td valign="top"><img src="images/top3.gif" width="792" height="29" alt="顶部横线"/></td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <table width="745" border="0" cellspacing="0">
                                <tr>
                                    <td valign="top" bgcolor="#FFFFFF">
                                        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BorderColor="White" 
                                            CssClass="tbs1" DataKeyNames="商品编号" EditRowStyle-Width="100" OnRowCommand="GridView1_RowCommand" Width="100%">
                                        <Columns>
                                            <asp:TemplateField HeaderText="书名">
                                                <ItemTemplate>
                                                    <%#  link(Eval("商品编号").ToString(),Eval("书籍名称").ToString())%>
                                                </ItemTemplate>
                                                <ItemStyle BorderColor="#0055E5"/>
                                                <HeaderStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="出版社">
                                                <ItemTemplate>
                                                    <%# Eval("出版社").ToString().Trim()%>
                                                </ItemTemplate>
                                                <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                <HeaderStyle BorderColor="#0055E5" Height="30px" HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="出版日期">
                                                <ItemTemplate>
                                                    <%# Eval("出版日期").ToString().Trim()%>
                                                </ItemTemplate>
                                                <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                <HeaderStyle BorderColor="#0055E5" Height="30px" HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="作者">
                                                <ItemTemplate>
                                                    <%#   Eval("作者").ToString()%>
                                                </ItemTemplate>
                                                <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                <HeaderStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="版本">
                                                <ItemTemplate>
                                                    <%#   Eval("版本").ToString()%>
                                                </ItemTemplate>
                                                <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                <HeaderStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                </asp:TemplateField>                            
                                            <asp:TemplateField HeaderText="单价">
                                                <ItemTemplate>
                                                    <%#   Eval("单价").ToString()%>
                                                </ItemTemplate>
                                                <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                <HeaderStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="库存">
                                                <ItemTemplate>
                                                    <asp:Label ID="kucunLBL" runat=server Text='<%#   Eval("库存").ToString()%>'></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                <HeaderStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                                </asp:TemplateField>                        
                                            <asp:ButtonField CommandName="放入购物车" HeaderText="放入购物车" Text="放入购物车">
                                                <HeaderStyle BorderColor="#0055E5" Width="85px" />
                                                <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                                            </asp:ButtonField>                        
                                        </Columns>
                                        <RowStyle CssClass="td2" />
                                        <EditRowStyle Width="100px" />
                                    </asp:GridView><br />
                                    <asp:Button ID="ClearBtn" runat="server" Text="清空购物车" onclick="ClearBtn_Click" />
                                    <asp:Label ID="errLBL" runat="server" ForeColor="Red" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td rowspan="2" valign="top">&nbsp;</td>
                    <td rowspan="2" valign="top" bgcolor="#FFFFFF"><img src="images/midlle1.gif" width="158" height="85" /></td>
                    <td valign="top"><img src="images/midlle2.gif" width="745" height="39" /></td>
                </tr>
                <tr>
                    <td valign="top">
                        <table width="745" border="0" cellspacing="0">
                            <tr>
                                <td height="300" width="340" valign="top" bgcolor="#FFFFFF" align="left">购物车：
                                    <asp:GridView ID="GridView2" CssClass="tbs1"  runat="server" Width="323px" />
                                    <asp:Label ID="Label2" runat="server" Text="" />
                                </td>
                                <td width="100" valign="top" bgcolor="#FFFFFF">
                                    <label>=》 <br />
                                        <asp:Button ID="BuyBtn" runat="server" Text="购买" onclick="BuyBtn_Click" />
                                    </label>
                                </td>
                                <td valign="top" width="320" bgcolor="#FFFFFF" align="left">正式购物清单：
                                    <asp:GridView ID="GridView3" runat="server" CssClass="tbs1"  Width="315px"></asp:GridView>
                                    <asp:Label ID="Label3" runat="server" Text="" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            </td>
        </tr>  
        <tr>
            <td align="center"><img src="images/bottom.gif" width="905" height="44" alt="底部装饰"/></td>
        </tr>
    </table>
    </div>
</form>
</body>
</html>
