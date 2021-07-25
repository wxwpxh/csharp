<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WebForm1.aspx.vb" Inherits="WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="学号,课程名" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="学号" HeaderText="学号" ReadOnly="True" SortExpression="学号" />
                <asp:BoundField DataField="课程名" HeaderText="课程名" ReadOnly="True" SortExpression="课程名" />
                <asp:BoundField DataField="分数" HeaderText="分数" SortExpression="分数" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [score] WHERE (([学号] = ?) OR ([学号] IS NULL AND ? IS NULL)) AND (([课程名] = ?) OR ([课程名] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [score] ([学号], [课程名], [分数]) VALUES (?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [学号], [课程名], [分数] FROM [score]" UpdateCommand="UPDATE [score] SET [分数] = ? WHERE (([学号] = ?) OR ([学号] IS NULL AND ? IS NULL)) AND (([课程名] = ?) OR ([课程名] IS NULL AND ? IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="学号" Type="String" />
                <asp:Parameter Name="课程名" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="学号" Type="String" />
                <asp:Parameter Name="课程名" Type="String" />
                <asp:Parameter Name="分数" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="分数" Type="Int32" />
                <asp:Parameter Name="学号" Type="String" />
                <asp:Parameter Name="课程名" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
