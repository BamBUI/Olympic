<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Beginning.aspx.cs" Inherits="OlympicGame.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label1" runat="server" Text="Введите кол-во вопросов"></asp:Label>
			<br />
			<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
			<br />
			<asp:Button ID="Button1" runat="server" Text="Начать игру" />
        </div>
    </form>
</body>
</html>

