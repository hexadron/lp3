<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Detalle.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form runat="server">
    <article>
			<ul id="detalle">
				<li>
                    <asp:Image ID="foto" ImageUrl="" runat="server" Width="340" AlternateText="detalle polo" />
				</li>
				<li>
					<h1>
                        <asp:Label ID="nombre" runat="server">
                        </asp:Label>
                    </h1>
                    <asp:HiddenField ID="item" runat="server" />
                    <div class="descripcion">
                        <asp:Label ID="descripcion" runat="server">
                        </asp:Label>
                    </div>
					<div class="precio">
                        S/.<asp:Label ID="precio" runat="server"></asp:Label>
                    </div>
					<div class="tiempo">
                        <asp:HiddenField ID="expirein" runat="server" />
                        <span class="t"></span>
                    </div>
					<input class="agregar" type="submit" value="Agregar"/>
				</li>
			</ul>
		</article>
        </form>
</asp:Content>

