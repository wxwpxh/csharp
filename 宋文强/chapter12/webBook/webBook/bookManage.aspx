<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bookManage.aspx.cs" Inherits="webBook.bookManange" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>网上书店</title>
    <LINK href="css/css.css" type="text/css" rel="stylesheet"> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="intro.aspx">新增图书</asp:HyperLink>
    <table><tr>
        <td>
        <asp:GridView ID="GridView1" runat="server" 
                    AllowSorting="True" AutoGenerateColumns="False" BorderColor="White" 
                    CssClass="tbs1" DataKeyNames="商品编号" EditRowStyle-Width="100" 
                    OnRowCommand="GridView1_RowCommand" Width="100%" 
                    OnRowDataBound="GridView1_RowDataBound">
                    <Columns>
                        <asp:TemplateField HeaderText="书名">
                            <ItemTemplate>
                                <%#   urlChakan(Eval("商品编号").ToString(),Eval("书籍名称").ToString())%>
                            </ItemTemplate>
                            <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
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
                        <asp:ButtonField CommandName="修改" HeaderText="修改" Text="修改">
                            <HeaderStyle BorderColor="#0055E5" Width="35px" />
                            <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                        </asp:ButtonField>
                        <asp:ButtonField CommandName="删除" HeaderText="删除" Text="删除">
                            <HeaderStyle BorderColor="#0055E5" Width="35px" />
                            <ItemStyle BorderColor="#0055E5" HorizontalAlign="Center" />
                        </asp:ButtonField>
                    </Columns>
                    <RowStyle CssClass="td2" />
                    <EditRowStyle Width="100px" />
                </asp:GridView>
        </td>
    </tr>
    </table>    
    </div>
    </form>
</body>
</html>
