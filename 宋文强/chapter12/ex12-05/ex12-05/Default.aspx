<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ex12_05._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>通过表单向数据库提交新的记录</title>
    <style type="text/css">
        .style1
        {
            width: 600px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <table align="center" class="style1">
            <tr>
                <td>
                    学号：<asp:TextBox ID="myNumber" runat="server"></asp:TextBox>
                </td>
                <td>
                    性别：<asp:DropDownList ID="mySex" runat="server">
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>姓名：<asp:TextBox ID="myName" runat="server"></asp:TextBox></td>
                <td>出生年月：<asp:TextBox ID="myBirthday" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>籍贯：<asp:TextBox ID="myHome" runat="server"></asp:TextBox></td>
                <td>高考成绩：<asp:TextBox ID="myScore" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>专业：<asp:DropDownList ID="mySubject" runat="server">
                    <asp:ListItem>临床医学</asp:ListItem>
                    <asp:ListItem>医学检验</asp:ListItem>
                    <asp:ListItem>医疗设备</asp:ListItem>
                    <asp:ListItem>生物医学工程</asp:ListItem>
                    <asp:ListItem>微生物</asp:ListItem>
                    <asp:ListItem>环境保护</asp:ListItem>
                    <asp:ListItem>信息管理</asp:ListItem>
                    <asp:ListItem>市场营销</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                    </asp:DropDownList></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">照片：<asp:FileUpload ID="myPhoto" runat="server" Width="450px" /></td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Button ID="Button1" runat="server" style="text-align: center" Text="提交" 
                        Width="80px" onclick="Button1_Click" />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:StudentConnectionString %>" 
                        DeleteCommand="DELETE FROM [学生基本情况表] WHERE [学号] = ?" 
                        InsertCommand="INSERT INTO [学生基本情况表] ([学号], [姓名], [性别], [籍贯], [出生年月], [高考成绩], [专业]) VALUES (@学号, @姓名, @性别, @籍贯, @出生年月, @高考成绩, @专业)" 
                        ProviderName="<%$ ConnectionStrings:StudentConnectionString.ProviderName %>" 
                        SelectCommand="SELECT * FROM [学生基本情况表]" 
                        UpdateCommand="UPDATE [学生基本情况表] SET [姓名] = ?, [性别] = ?, [籍贯] = ?, [出生年月] = ?, [高考成绩] = ?, [专业] = ? WHERE [学号] = ?">
                        <DeleteParameters>
                            <asp:Parameter Name="学号" Type="String" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="姓名" Type="String" />
                            <asp:Parameter Name="性别" Type="String" />
                            <asp:Parameter Name="籍贯" Type="String" />
                            <asp:Parameter Name="出生年月" Type="DateTime" />
                            <asp:Parameter Name="高考成绩" Type="Int16" />
                            <asp:Parameter Name="专业" Type="String" />
                            <asp:Parameter Name="学号" Type="String" />
                        </UpdateParameters>
                        <InsertParameters>
                            <asp:FormParameter Name="学号" Type="String"  FormField="myNumber"/>
                            <asp:FormParameter Name="姓名" Type="String" FormField="myName" />
                            <asp:FormParameter Name="性别" Type="String" FormField="mySex" />
                            <asp:FormParameter Name="籍贯" Type="String" FormField="myHome" />
                            <asp:FormParameter Name="出生年月" Type="DateTime" FormField="myBirthday" />
                            <asp:FormParameter Name="高考成绩" Type="Int16" FormField="myScore" />
                            <asp:FormParameter Name="专业" Type="String" FormField="mySubject" />
                        </InsertParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>    
    </div>
    </form>
</body>
</html>
