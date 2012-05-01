using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            ViewState["precio"] = 0;
            ViewState["cantidad"] = 0;
            ViewState["descuento"] = 10;
        }
    }

    protected void calculo(int precio, int q)
    {
        if (precio == 0 || q == 0)
            return;

        decimal monto, dscto, neto;
        monto = precio * q;
        if (monto <= 1000)
            dscto = 0;
        else
            dscto = monto * decimal.Parse(ViewState["descuento"].ToString()) / 100;

        neto = monto - dscto;

        lblMonto.Text = monto.ToString();
        lblDescuento.Text = dscto.ToString();
        lblNeto.Text = neto.ToString();
    }

    protected void cboAccesorio_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewState["precio"] = cboAccesorio.SelectedValue;
        lblPrecio.Text = ViewState["precio"].ToString();
        calculo(Int16.Parse(ViewState["precio"].ToString()),
                Int16.Parse(ViewState["cantidad"].ToString()));
    }

    protected void calcular_Click(object sender, EventArgs e)
    {
        ViewState["cantidad"] = cantidad.Text;
        calculo(Int16.Parse(ViewState["precio"].ToString()),
                Int16.Parse(ViewState["cantidad"].ToString()));
    }

    protected void enviar_Click(object sender, EventArgs e)
    {
        var cookie = new HttpCookie("cookie");
        cookie.Values["cantidad"] = "10";
        Response.Cookies.Add(cookie);
        Response.Redirect("");
    }
}
