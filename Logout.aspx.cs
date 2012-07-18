using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["current_user"] != null)
        {
            Session["current_user"] = null;
            Session.Clear();
            Response.Redirect("/lp3/Index.aspx");
        }
        else
        {
            Response.Redirect("/lp3/Index.aspx");
        }
    }
}