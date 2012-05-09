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
        Func<int, int> hola = x => x * x;
    }

    public void ingreso(string usuario)
    {
        if (usuario.Trim().Length == 0)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            // mostrar usuario
        }
    }
}
