<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="MantenimientoPolos.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <article> 
			<h2 class="tit_article">Mantenimiento de Polos</h2>
			<form id="form1" runat="server" class="mantenimiento">
				<ul>
					<li><label>Nombre</label><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </li>
					<li><label>Vendedor</label><asp:DropDownList ID="cboVendedor" runat="server">
                        </asp:DropDownList>
                    </li>
					<li><label>Precio</label><asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
                    </li>
					<li><label>Stock</label><asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
                    </li>
					<li><label>Tiempo Venta</label><asp:TextBox ID="txtTiempo" runat="server"></asp:TextBox>
                    </li>
					<li><label>Polo</label><asp:FileUpload ID="imgPolo" runat="server" />
                    </li>
                    <li>
                        <asp:Button ID="btnIngresar" class="boton" runat="server" Text="Ingresar" />
                        <asp:Button ID="btnActualizar" class="boton" runat="server" Text="Actualizar" />
                    </li>
				</ul>
                <asp:GridView ID="GridView1" runat="server" Width="550px">
                </asp:GridView>
			</form>
            <figure class="mantenimiento">
				<img src="img/diseno-de-polos.png" alt="diseño de polos" width="350"/>
			    
			</figure>
		</article>
</asp:Content>
