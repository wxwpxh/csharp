<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="introChg.aspx.cs" Inherits="webBook.introChg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在线购书网</title>
    <style type="text/css">
<!--
body {
	margin-top: 0px;
}
label {
	font-family: "新宋体";
	font-size: 14px;
	display: block;
	margin-top: 15px;
}
-->
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div border="0" 
            style="position: absolute; width: 256px; height: 39px; z-index: 1; left: 435px; top: 69px">
        <p align="center" class="MsoNormal">
            <b><span style="font-size: 20pt; font-family: 楷体_GB2312; color: #FFFFFF">修改书籍信息</span></b></p>
        </div>
    <div>
    <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#E1E1E1">
  <tr>
    <td><img src="images/top_1.gif" width="1000" height="133" />
      </td>
  </tr>
  <tr>
    <td><table width="905" border="0" align="center" cellpadding="10" cellspacing="0" bgcolor="#FFFFFF">
      <tr>
        <td width="187" valign="top">
                <asp:Image ID="Image1" runat="server" Height="205px" Width="187px" 
                    ImageUrl="uploads/wu.jpg" />
                <br />
                <label>封面：</label><input id="File1" type="file" onpropertychange="document.getElementById('Image1').src=this.value"  runat=server /></td>
        <td><label>书籍名称：
            <asp:TextBox ID="nameTXT" runat="server" Width="165px"></asp:TextBox>
            &nbsp;</label><label>作&nbsp;&nbsp;&nbsp;&nbsp;者：
           
            <asp:TextBox ID="authorTXT" 
                            runat="server" Width="165px"></asp:TextBox>
            &nbsp;</label><label>简&nbsp;&nbsp;&nbsp;  介：
                        <asp:TextBox ID="introTXT" 
                    runat="server" Height="101px" TextMode="MultiLine" Width="404px"></asp:TextBox>
            </label>&nbsp;<label>出 版 社：
                        <asp:TextBox ID="chubansheTXT" 
                    runat="server" Width="214px"></asp:TextBox>
            <br />
            <br />
            出版日期：
                        <asp:TextBox ID="chubanriqiTXT" 
                    runat="server" Width="214px"></asp:TextBox>
            <br />
            <br />
            版&nbsp;&nbsp;&nbsp; 本：
                        <asp:TextBox ID="versionTXT" 
                    runat="server" Width="214px"></asp:TextBox>
            &nbsp;</label><label>单&nbsp;&nbsp;&nbsp; 价：
                        <asp:TextBox ID="priceTXT" 
                    runat="server" Width="74px"></asp:TextBox>
            &nbsp;</label><label>库&nbsp;&nbsp;&nbsp; 存：
                        <asp:TextBox ID="numTXT" 
                    runat="server" Width="74px"></asp:TextBox>
            &nbsp;</label></td>
      </tr>
      <tr>
        <td colspan="2">
                        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="保存" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="backBtn" runat="server" onclick="backBtn_Click" Text="返回" />
                    </td>
      </tr>
      <tr>
        <td colspan="2">&nbsp;</td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td align="center" valign="top"><img src="images/bottom.gif" width="905" height="44" /></td>
  </tr>
</table>
    </div>
    </form>
</body>
</html>
