<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
        Display="Dynamic" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
</asp:Content>

