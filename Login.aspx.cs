using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["current_user"] != null)
        {
            Response.Redirect("Index.aspx");
        }
    }

    protected void btnSignup_Click(object sender, EventArgs e)
    {
        var cli = Client.create(scorreo.Text, spassword.Text);

        if (cli != null)
        {
            if (Request.Cookies["carrito"] != null)
            {
                Response.Redirect("Carrito.aspx");
            }
            else 
            {
                Response.Redirect("Index.aspx");
            }
           
        }

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        client authenticated = 
            Client.authenticate(lemail.Text, lpassword.Text);

        if (authenticated != null)
        {
            Session["current_user"] = authenticated;
            if (authenticated.is_admin)
            {
                Response.Redirect("admin/polos/index.aspx");
            }
            else
            {
                if (Request.Cookies["carrito"] != null)
                {
                    Response.Redirect("Carrito.aspx");
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }
            }
        }
    }
}