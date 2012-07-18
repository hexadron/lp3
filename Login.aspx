<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="form_page" runat="server">
    <ul id="loginsignup">
        <li>
            <asp:panel defaultbutton="btnLogin" id="pnlLogin" runat="server">
            <div id="login" class="login">
	            <ul>
		            <li><h3>Ingresa con tu cuenta</h3></li>
		            <li>
                        <label>Correo</label>
                        <asp:TextBox ID="lemail" runat="server"></asp:TextBox>
                    <li>
		            <li>
                        <label>Contraseña</label>
                        <asp:TextBox id="lpassword" runat="server" TextMode="Password"></asp:TextBox>
                    </li>
		            <li>
                        <asp:Button ID="btnLogin" Text="ingresar" runat="server" 
                            onclick="btnLogin_Click" />
                    </li>
	            </ul>
            </div>
            </asp:panel>
        </li>
        <li id="o">
            <p>&oacute;</p>
        </li>
        <li>
            <asp:panel defaultbutton="btnSignup" id="Panel1" runat="server">
            <div id="signup" class="login">
			    <ul>
				    <li><h3>Registrate</h3></li>
				    <li>
                        <label>Correo</label>
                        <asp:TextBox ID="scorreo" runat="server"></asp:TextBox>
                    <li>
		            <li>
                        <label>Contraseña</label>
                        <asp:TextBox id="spassword" runat="server" TextMode="Password"></asp:TextBox>
                    </li>
		            <li>
                        <asp:Button ID="btnSignup" Text="registrarse" runat="server" 
                            onclick="btnSignup_Click" />
                    </li>
			    </ul>
		    </div>
            </asp:panel>
        </li>
    </ul>
</form>
</asp:Content>

