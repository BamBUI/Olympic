<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="OlympicGame.Game" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
			<br />
			<asp:Button ID="Button1" runat="server" Text="Button" />
			<asp:Button ID="Button2" runat="server" Text="Button" />
			<br />
			<asp:Button ID="Button3" runat="server" Text="Button" />
			<asp:Button ID="Button4" runat="server" Text="Button" />
			<br />
			<asp:Button ID="Button5" runat="server" Text="Следующий вопрос" />
        </div>
    </form>
</body>
</html>
