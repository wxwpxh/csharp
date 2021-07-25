<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="WebForm1" %>

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
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="学号,课程名">
            <Columns>
                <asp:BoundField DataField="学号" HeaderText="学号" SortExpression="学号" ReadOnly="True" />
                <asp:BoundField DataField="课程名" HeaderText="课程名" SortExpression="课程名" ReadOnly="True" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [学号], [课程名], [分数] FROM [score]" DeleteCommand="DELETE FROM [score] WHERE (([学号] = ?) OR ([学号] IS NULL AND ? IS NULL)) AND (([课程名] = ?) OR ([课程名] IS NULL AND ? IS NULL))" InsertCommand="INSERT INTO [score] ([学号], [课程名], [分数]) VALUES (?, ?, ?)" UpdateCommand="UPDATE [score] SET [分数] = ? WHERE (([学号] = ?) OR ([学号] IS NULL AND ? IS NULL)) AND (([课程名] = ?) OR ([课程名] IS NULL AND ? IS NULL))">
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
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="SqlDataSource1" Height="50px" Width="125px" CellPadding="4" DataKeyNames="学号,课程名" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="学号" HeaderText="学号" SortExpression="学号" ReadOnly="True" />
                <asp:BoundField DataField="课程名" HeaderText="课程名" SortExpression="课程名" ReadOnly="True" />
                <asp:BoundField DataField="分数" HeaderText="分数" SortExpression="分数" />
                <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
    </form>
</body>
</html>
