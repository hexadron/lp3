<%@ Page Language="C#" MasterPageFile="~/Layout.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    	<div id="da-slider" class="da-slider">
            <asp:Repeater ID="polosPrincipal" runat="server">
               <ItemTemplate>
				<div class="da-slide" data-shirt="<%# Eval("id") %>" >
					<h2> <%# Eval("name") %></h2>
					<p >A solo  S/. <%# Eval("price") %> el polo cerrará en <span class="experin"></span></p>
					<a href="#" class="da-link">Comprar</a>
					<div class="da-img"><img src="<%# Eval("imagen") %>" alt="image01" /></div>
				</div>
              </ItemTemplate>
              </asp:Repeater>
				<nav class="da-arrows">
					<span class="da-arrows-prev"></span>
					<span class="da-arrows-next"></span>
				</nav>
			</div>
	
		<article>
			<ul id="contenedor">
				<li id="productos">
					<ul>				
						<li class="principales">
							<h3>Nuestros Polos</h3>
                            <asp:Repeater ID="polosRepeater" runat="server">
                            <ItemTemplate>
								<figure class="thumb" data-shirt="<%# Eval("id") %>">
									<img src="<%# Eval("imagen") %>" width="170" alt="imagen"/>
									<section>
										<h2> <%# Eval("name") %></h2>
										<p>A solo  S/. <%# Eval("price") %></p>
										<a href="#" class="btn">Comprar</a>
									</section>
								</figure>
                             </ItemTemplate>
                             </asp:Repeater>
						</li>
					</ul>
				</li>
				<li id="redes">
					<ul>
						<li id="twitter">
							<h3><img src="img/tit-twitter.png" width="170" alt="twitter titulo"/></h3>
							<ul></ul>
						</li>
					</ul>
				</li>
			</ul>			
		</article>
</asp:Content>

