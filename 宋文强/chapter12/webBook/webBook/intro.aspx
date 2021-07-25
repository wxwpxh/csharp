<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="intro.aspx.cs" Inherits="webBook.intro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
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
 p.MsoNormal
	{margin:0cm;
	margin-bottom:.0001pt;
	text-align:justify;
	text-justify:inter-ideograph;
	font-size:10.5pt;
	font-family:"Times New Roman";}
 -->
</style>

</head>
<body>
    <form id="form1" runat="server">
    <div style="position: absolute; width: 256px; height: 39px; z-index: 1; left: 435px; top: 69px" 
        border=0>
        <p align="center" class="MsoNormal">
            <b><span style="font-size: 20pt; font-family: 楷体_GB2312; color: #FFFFFF">新增书籍</span></b></p>
    </div>
    <div>
        
    <table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#E1E1E1">
  <tr>
    <td><img src="images/top_1.gif" width="1000" height="133" /></td>
  </tr>
  <tr>
    <td><table width="905" border="0" align="center" cellpadding="10" cellspacing="0" bgcolor="#FFFFFF">
      <tr>
        <td width="187" valign="top">
                <asp:Image ID="Image1" runat="server" Height="205px" Width="187px" 
                    ImageUrl="uploads/wu.jpg" />
                <label>封面：<input id="File1" type="file" onpropertychange="document.getElementById('Image1').src=this.value"  runat=server /></label><br />
                                </td>
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
                    &nbsp;&nbsp;&nbsp;&nbsp;
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
