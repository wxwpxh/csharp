<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WebForm3.aspx.vb" Inherits="WebForm3" %>

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
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="学号,课程名" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" PageSize="4">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="学号" HeaderText="学号" ReadOnly="True" SortExpression="学号" />
                <asp:BoundField DataField="课程名" HeaderText="课程名" ReadOnly="True" SortExpression="课程名" />
                <asp:BoundField DataField="分数" HeaderText="分数" SortExpression="分数" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" DeleteCommand="DELETE FROM [score] WHERE (([学号] = ?) OR ([学号] IS NULL AND ? IS NULL)) AND (([课程名] = ?) OR ([课程名] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [score] ([学号], [课程名], [分数]) VALUES (?, ?, ?)" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT [学号], [课程名], [分数] FROM [score]" UpdateCommand="UPDATE [score] SET [分数] = ? WHERE (([学号] = ?) OR ([学号] IS NULL AND ? IS NULL)) AND (([课程名] = ?) OR ([课程名] IS NULL AND ? IS NULL))">
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
