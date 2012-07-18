<%@ Page Title="" Language="C#" MasterPageFile="~/Skeu.master" AutoEventWireup="true" CodeFile="Nuevo.aspx.cs" Inherits="admin_polos_Nuevo" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
Registrar polo
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form class="content" id="form1" runat="server">
    <ul class="fields">
        <li>
            <label for"expire_time">Tiempo de expiraci&oacute;n</label>
            <asp:TextBox ID="TxtTiempoExpiracion" runat="server"></asp:TextBox>
            <div class="validation">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="TxtTiempoExpiracion" Display="Dynamic" 
                    ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
            </div>
        </li>
        <li>
            <label for"name">Nombre</label>
            <asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox>
            <div class="validation">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TxtNombre" Display="Dynamic" 
                    ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
            </div>
        </li>
        <li>
            <label for"description">Descripci&oacute;n</label>
            <asp:TextBox ID="TxtDescripcion" runat="server"></asp:TextBox>
            <div class="validation">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TxtDescripcion" Display="Dynamic" 
                    ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
            </div>
        </li>
        <li>
            <label for"price">Precio</label>
            <asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox>
            <div class="validation">
                
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TxtPrecio" ErrorMessage="numero esperado" 
                    ValidationExpression="^\d+(\.\d+)?$"></asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TxtPrecio" Display="Dynamic"
                    ErrorMessage="campo requerido"></asp:RequiredFieldValidator>
            </div>
            
        </li>
        <li>
            <label for="foto">Foto</label>
            <input type='file' />
            <asp:HiddenField ID="TxtFoto" runat="server" Value="" />
        </li>
    </ul>
    <ul class="buttons">
        <li>
            <input class="main" type="submit" value="Guardar" />
        </li>
    </ul>
</form>
</asp:Content>