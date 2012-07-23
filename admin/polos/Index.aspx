<%@ Page Title="" Language="C#" MasterPageFile="~/Skeu.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="admin_polos_Index" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
Mantenimiento de polos
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form class="content" id="form1" runat="server">
    <ul class="fields">
        <li>
            <asp:GridView ID="GridView1"  runat="server" BackColor="White"
                BorderColor="#666" BorderStyle="None" BorderWidth="4px" 
                ForeColor="Black" GridLines="Horizontal" Width="100%">
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7"/>
                <SortedAscendingHeaderStyle BackColor="#4B4B4B"  />
                <SortedDescendingCellStyle BackColor="#E5E5E5"  />
            </asp:GridView>
        </li>  
    </ul>
</form>
</asp:Content>

