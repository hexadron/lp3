<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Contacto.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <article>
			<div class="contacto">
				<h3>Contáctenos</h3>
				<form>
					<ul>
						<li><label>Nombre</label><input type="text"/></li>
						<li><label>Email</label><input type="text"/></li>
						<li><label>Telefono</label><input type="text"/></li>
						<li><label>Comentario</label><textarea></textarea></li>
						<li><input type="button" value="Enviame!"/></li>
					</ul>
				</form>
			</div>
			<div class="info">
				<h3>Nos ubicas en</h3>
				<ul>
					<li><img src="img/home.png" width="40" alt="home" title="home"/>Dirección: Av. Arenales 478</li>
					<li><img src="img/mail.png" width="40" alt="mail" title="mail"/>Correo: contacto@polet.com</li>
					<li><img src="img/telefono.png" width="40" alt="telefono" title="telefono"/>Telefonos: 255-4444</li>
				</ul>
			</div>
		</article>
</asp:Content>

