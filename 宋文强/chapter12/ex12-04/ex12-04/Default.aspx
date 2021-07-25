<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ex12_04._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>数据库内容浏览</title>
    <style type="text/css">
        .style1
        {
            width: 800px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1">
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" 
                        ProviderName="<%$ ConnectionStrings:StudentConnectionString.ProviderName %>" 
                        SelectCommand="SELECT * FROM [学生基本情况表]"></asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" DataKeyNames="学号" DataSourceID="SqlDataSource1" 
                        onrowcommand="GridView1_RowCommand" PageSize="7">
                        <Columns>
                            <asp:BoundField DataField="学号" HeaderText="学号" ReadOnly="True" 
                                SortExpression="学号">
                                <HeaderStyle Width="80px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名">
                                <HeaderStyle Width="60px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="性别" HeaderText="性别" SortExpression="性别">
                                <HeaderStyle Width="40px" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="籍贯" HeaderText="籍贯" SortExpression="籍贯">
                                <HeaderStyle Width="60px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="出生年月" DataFormatString="{0:yyyy-MM}" 
                                HeaderText="出生年月" SortExpression="出生年月">
                                <HeaderStyle Width="90px" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="高考成绩" HeaderText="高考成绩" SortExpression="高考成绩">
                                <HeaderStyle Width="90px" />
                                <ItemStyle HorizontalAlign="Center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="专业" HeaderText="专业" SortExpression="专业">
                                <HeaderStyle Width="100px" />
                            </asp:BoundField>
                            <asp:ButtonField ButtonType="Button" CommandName="showPicture" Text="查看照片" />
                        </Columns>
                    </asp:GridView>
                </td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="240px" Width="180px" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
