<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Carrito.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="updateCarrito" runat="server">
    <article>
			<div class="carrito">
				<h1>Carrito<img src="img/carrito.png" alt="carrito" width="30"/></h1>
				<table width="700">
				    <tr>
					    <td></td>
						    <td>Nombre</td>
						    <td>Precio</td>
                            <td>Cantidad</td>
                            <td>Monto</td>
					    </tr>
                     
                <asp:Repeater ID="carritoRepeater" runat="server">
                       <ItemTemplate>
					        <tr id="<%# Eval("shirt.id") %>">
						        <td><img src="<%# Eval("shirt.imagen") %>" alt="foto1" width="70"/></td>
						        <td><%# Eval("shirt.name") %></td>
						        <td>S/. <%# Eval("shirt.price") %></td>
                                <td class="qtybox">
                                    <input type="hidden" value="<%# Eval("qty") %>" class="qtyhidden" />
                                    <asp:HiddenField ID="itemShirt" runat="server" />
                                    <asp:TextBox CssClass="qtext" id="qty" runat="server"></asp:TextBox>
                                </td>
                                <td>S/. <%# decimal.Parse(Eval("shirt.price").ToString()) *
                                    decimal.Parse(Eval("qty").ToString()) %></td>
					        </tr>
                        </ItemTemplate>
                </asp:Repeater>
                    <tr>
                        <td></td>
                        <td></td>
                        <td></td>
                        <td>Total:</td>
                        <td>
                        S/.<asp:Label ID="total" runat="server">
                            
                        </asp:Label>
                        </td>
                    </tr>
                </table>

                <asp:Button id="updateCart" runat="server" Text="Actualizar Monto" 
                    onclick="updateCart_Click" />

                <asp:Panel ID="logPanel" runat="server">
				    <asp:Button id="logueo" runat="server" Text="Logueate para continuar >>" 
                        onclick="logueo_Click" />
                </asp:Panel>
              
                <asp:Panel ID="Pasarela" runat="server">
				<div class="pasarela">
					<h3>Modo de Pago</h3>
					<div>Cantidad: <asp:Label ID="cantidad" runat="server" Text="0"></asp:Label></div>
					<div>Total: S/.<asp:Label ID="precio" runat="server" Text="0"></asp:Label></div>
					<a href="Checkout.aspx"><input type="image" src="https://www.paypal.com/en_US/i/btn/btn_paynowCC_LG.gif" /></a>
				</div>
                </asp:Panel>
			</div>
			
		</article>
    </form>
</asp:Content>

