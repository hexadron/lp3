<%@ Page Title="" Language="C#" MasterPageFile="~/Skeu.master" AutoEventWireup="true" CodeFile="Editar.aspx.cs" Inherits="admin_polos_Editar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form class="content" id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <ul class="fields">
        <li>
            <label for"expire_time">Tiempo de expiraci&oacute;n</label>
            <asp:TextBox ID="TxtTiempoExpiracion" runat="server"></asp:TextBox>
        </li>
        <li>
            <label for"name">Nombre</label>
            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
        </li>
        <li>
            <label for"description">Descripci&oacute;n</label>
            <asp:TextBox ID="TxtDescripcion" runat="server"></asp:TextBox>
        </li>
        <li>
            <label for"price">Precio</label>
            <asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox>
        </li>
    </ul>
    <ul class="buttons">
        <li>
            <input class="main" type="submit" value="Guardar" />
        </li>
    </ul>
</form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
Editar polo
</asp:Content>

