<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Page1.aspx.cs" Inherits="Page1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        html
        {
            font: normal normal 1.2em/1.5em Verdana, sans-serif;
        }
        
        ul 
        {
            list-style: none;
        }
        
        label 
        {
            display: inline-block;
            width: 10em;
        }
    </style>
    <meta http-equiv="Refresh" content="5;URL=google.com" />
</head>
<body>
    <form id="form1" runat="server">
    <ul>
        <li><h1>Venta de Acessorios</h1></li>
        <li>
            <label for="cliente">Cliente</label>
            <asp:TextBox ID="cliente" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="cliente" Display="Dynamic" ErrorMessage="Ingrese el cliente" 
                ForeColor="Red"></asp:RequiredFieldValidator>
        </li>
        <li>
            <label for="accesorio">Accesorio</label>
            <asp:DropDownList ID="cboAccesorio" runat="server" 
                onselectedindexchanged="cboAccesorio_SelectedIndexChanged" style="height: 22px">
                <asp:ListItem Value="120">Memorias</asp:ListItem>
                <asp:ListItem Value="450">CPU</asp:ListItem>
                <asp:ListItem Value="20">Teclado</asp:ListItem>
                <asp:ListItem Value="25">Mouse</asp:ListItem>
                <asp:ListItem Value="55">Tarjeta de Red</asp:ListItem>
            </asp:DropDownList>
        </li>
        <li>
            <label for="precio">Precio unitario</label>
            <asp:Label ID="lblPrecio" runat="server"></asp:Label>
        </li>
        <li>
            <label for="cantidad">Cantidad</label>
            <asp:TextBox ID="cantidad" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="cantidad" Display="Dynamic" 
                ErrorMessage="Ingrese la cantidad" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToValidate="cantidad" Display="Dynamic" ErrorMessage="Minimo 1" 
                ForeColor="Red" Operator="GreaterThanEqual" Type="Integer" ValueToCompare="1"></asp:CompareValidator>
        </li>
        <li>
            <label for="monton">Monto</label>
            <asp:Label ID="lblMonto" runat="server"></asp:Label>
        </li>
        <li>
            <label for="descuento">Descuento</label>
            <asp:Label ID="lblDescuento" runat="server"></asp:Label>
        </li>
        <li>
            <label for="neto">Neto</label>
            <asp:Label ID="lblNeto" runat="server"></asp:Label>
        </li>
        <li>
            <asp:Button ID="calcular" Text="Calcular" runat="server" 
                onclick="calcular_Click" />
            <asp:Button ID="enviar" Text="Enviar" runat="server" onclick="enviar_Click"/>
        </li>
    </ul>
    <asp:Image ID="Image1" runat="server" Height="206px" Width="346px" />
    </form>
</body>
</html>
