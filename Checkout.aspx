<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Checkout.aspx.cs" Inherits="Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<article>
<form runat="server">
    <div class="carrito">
	    <h1>Checkout</h1>
        <ol>
        <li>
            <h1>1. Pedido</h1>
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
                            <td><%# Eval("qty") %></td>
                            <td>S/. <%# decimal.Parse(Eval("shirt.price").ToString()) *
                                decimal.Parse(Eval("qty").ToString()) %></td>
				        </tr>
                    </ItemTemplate>
            </asp:Repeater>
                <tr>
                    <td></td>
                    <td></td>
                    <td>Total:</td>
                    <td>
                        <asp:Label ID="cantidad" runat="server">                            
                         </asp:Label>
                    </td>
                    <td>
                    S/.<asp:Label ID="total" runat="server">
                            
                    </asp:Label>
                    </td>
                </tr>
            </table>
        </li>
        <li>
            <h1>2. Direccion de Envio</h1>
            <p><span class="b">Nota:</span> <span>Solo en Lima. No hay costo adicional por envio.</span></p>
            <asp:TextBox placeholder="Av/Jr/Calle - Nombre de Calle - Nro - Distrito" ID="shipping_address" runat="server" CssClass="bigbox"></asp:TextBox>
        </li>
        <li>
            <h1>3. Direccion de Facturacion</h1>
            <asp:TextBox placeholder="Av/Jr/Calle - Nombre de Calle - Nro - Distrito" ID="billing_address" runat="server" CssClass="bigbox"></asp:TextBox>
        </li>
        <li>
            <h1>4. Realizar Pago</h1>
            <p>
                <span class="b">Nota:</span> <span>Ser&aacute;s redirigido a Paypal para completar el pago:</span>
                <asp:Button Text="Realizar Pago" ID="checkout" runat="server" 
                    onclick="checkout_Click" />    
            </p>
        </li>
        </ol>
    </div>
</form>
</article>

</asp:Content>