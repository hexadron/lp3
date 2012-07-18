using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Skeu : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["current_user"] == null
            || !((client)Session["current_user"]).is_admin)
        {
            Response.Redirect("/lp3/Login.aspx");
        }
        
    }

   
}
