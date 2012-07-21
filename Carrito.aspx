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
                </table>

                <asp:Button id="updateCart" runat="server" Text="Actualizar Monto" />

                
                <asp:Panel ID="Pasarela" runat="server">
				<div class="pasarela">
					<h3>Modo de Pago</h3>
					<div>Cantidad: <asp:Label ID="cantidad" runat="server" Text="0"></asp:Label></div>
					<div>Total: S/.<asp:Label ID="precio" runat="server" Text="0"></asp:Label></div>
					<input type="image" src="https://www.paypal.com/en_US/i/btn/btn_paynowCC_LG.gif" />
				</div>
                </asp:Panel>

                <asp:Panel ID="logPanel" runat="server">
				<div class="login">
					<ul>
						<li><h3>¿Aún no tienes una cuenta?</h3></li>
						<li><label>Nombre</label><input type="text" name="txtNombre"/></li>
						<li><label>Correo</label><input type="email" name="txtEmail"/><li>
						<li><label>Contraseña</label><input type="password" name="txtPassword"/></li>
						<li><input type="button" value="registrar"/></li>
					</ul>
				</div>
				<div class="login">
					<ul>
						<li><h3>Ingresa con tu cuenta</h3></li>
						<li><label>Correo</label><input type="email"/><li>
						<li><label>Contraseña</label><input type="password"/></li>
						<li><input type="button" value="ingresar"/></li>
					</ul>
				</div>
				<div class="login">
					<ul>
						<li><h3>¿Olvidaste tu contraseña?</h3></li>
						<li><label>Correo</label><input type="email"/><li>
						<li><input type="button" value="recuperar"/></li>
						<li><img width="100" src="img/candado.png" alt="recuperar" title="recueprar"></li>
					</ul>
				</div>
                </asp:Panel>
			</div>
			
		</article>
    </form>
</asp:Content>

