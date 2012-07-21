using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Layout : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["current_user"] == null)
        {
            linkingreso.Text = "Ingresar<span class='img-ingresar'></span>";
            linkingreso.NavigateUrl = "/lp3/Login.aspx";
        }
        else
        {
            linkingreso.Text = "Salir<span class='img-ingresar'></span>";
            linkingreso.NavigateUrl = "/lp3/Logout.aspx";
        }
    }

}
