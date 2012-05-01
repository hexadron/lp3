<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label id="firstLabel" AssociatedControlID="firstTextBox" runat="server"></asp:Label>
        <asp:Label id="hola" AssociatedControlID="secondLabel" runat="server"></asp:Label>
        <asp:TextBox id="firstTextBox" runat="server"></asp:TextBox>
        <asp:Button id="submit" text="Enviar" runat="server" onclick="submit_Click"/>
    </form>
</body>
</html>
