<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Success.aspx.cs" Inherits="Success" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <article>
        <div class="carrito">
            <h1>Compra finalizada</h1>
            <p> Has generado el pedido nro. <asp:Label ID="nro" runat="server"></asp:Label></p>
            <ul>
                <li><span class="b">Enviado a:</span> <asp:Label ID="sent_where" runat="server"></asp:Label></li>
                <li><span class="b">E-mail:</span> <asp:Label ID="mail" runat="server"></asp:Label></li>
                <li><span class="b">Fecha:</span> <asp:Label ID="sent_at" runat="server"></asp:Label></li>
                <li><span class="b">Total de la Compra:</span> <asp:Label ID="total" runat="server"></asp:Label></li>
            </ul>
            
            <h1>Gracias.</h1>
            
        </div>
    </article>
</asp:Content>

