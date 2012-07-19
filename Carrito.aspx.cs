using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<CarItem> cart = (List<CarItem>) Session["cart"];
            var cantidadTotal = 0;
            var precioTotal = 0;
            var polos = new List<tshirt>();
            foreach (CarItem c in cart)
            {
                tshirt polo = Tshirts.find(c.shirt);
                polos.Add(polo);
                cantidadTotal += 1;
                precioTotal += Convert.ToInt32(polo.price);
            }
            carritoRepeater.DataSource = polos;
            carritoRepeater.DataBind();
            precio.Text = precioTotal.ToString();
            cantidad.Text = cantidadTotal.ToString();
        }
        else
        {
        }
    }
}