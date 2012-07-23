<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Polos.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server" id="addToCarrito">
   
    <article>
     <asp:HiddenField ID="item" Value="" runat="server" />
			<ul id="polo-contenedor">
                <asp:Repeater ID="polosRepeater" runat="server">
                    <ItemTemplate>
                        <li class="zoom polo">
                            <figure>
                                <img src="<%# Eval("imagen") %>" />
                                <div class="detail" data-shirt="<%# Eval("id") %>">
                                    <h2 class="product-name">
                                        <%# Eval("name") %>
                                    </h2>
                                    <h3 class="product-price">
                                        S/. <%# Eval("price") %>
                                    </h3>
                                    <div class="product-time" data-expirein="<%# ((DateTime) Eval("expire_time")).ToShortDateString() %>">
                                        expira en <span class="experin"></span>
                                    </div>
                                    <div class="add">
                                        Agregar al Carrito
                                    </div>
                                </div>
                            </figure>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
			</ul>						
		</article>
        </form>
</asp:Content>

