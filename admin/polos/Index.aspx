<%@ Page Title="" Language="C#" MasterPageFile="~/Skeu.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="admin_polos_Index" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
Mantenimiento de polos
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form class="content" id="form1" runat="server">
    <ul class="fields">
        <li>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </li>  
    </ul>
</form>
</asp:Content>

