<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Carrito.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <article>
			<div class="carrito">
				<h1>Carrito<img src="img/carrito.png" alt="carrito" width="30"/></h1>
				<table width="700">
				    <tr>
					    <td></td>
						    <td>Nombre</td>
						    <td>Precio</td>
					    </tr>
                     
                <asp:Repeater ID="carritoRepeater" runat="server">
                       <ItemTemplate>
					        <tr>
						        <td><img src="<%# Eval("imagen") %>" alt="foto1" width="70"/></td>
						        <td><%# Eval("name")%></td>
						        <td>S/. <%# Eval("price")%></td>
					        </tr>    
                        </ItemTemplate>
                </asp:Repeater>
                </table>
				<div class="login">
					<ul>
						<li><h3>¿Aún no tienes una cuenta?</h3></li>
						<li><label>Nombre</label><input type="text" required="required" name="txtNombre"/></li>
						<li><label>Correo</label><input type="email" required="required" name="txtEmail"/><li>
						<li><label>Contraseña</label><input type="password" required="required" name="txtPassword"/></li>
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
						<li><h3>¿Olvidastes tu contraseña?</h3></li>
						<li><label>Correo</label><input type="email"/><li>
						<li><input type="button" value="recuperar"/></li>
						<li><img width="100" src="img/candado.png" alt="recuperar" title="recueprar"></li>
					</ul>
				</div>
				<div class="pasarela">
					<h3>Modo de Pago</h3>
					<div>Cantidad: <asp:Label ID="cantidad" runat="server" Text="0"></asp:Label></div>
					<div>Total: S/.<asp:Label ID="precio" runat="server" Text="0"></asp:Label></div>
					<input type="image" src="https://www.paypal.com/en_US/i/btn/btn_paynowCC_LG.gif" />
				</div>
			</div>
			
		</article>
</asp:Content>

