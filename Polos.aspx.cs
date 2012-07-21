using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            var shirts = Tshirts.not_expired();
            polosRepeater.DataSource = shirts;
            polosRepeater.DataBind();
        }
        else
        {
            // Se agrega al carrito
            int idShirt = int.Parse(item.Value);
            CarItem it = new CarItem(idShirt);

            if (Session["cart"] != null)
            {
                List<CarItem> cart = (List<CarItem>)Session["cart"];

                var repeated = cart.FindAll(i =>
                    i.shirt.id == idShirt);

                if (repeated.Count > 0)
                {
                    repeated.First().add(1);
                }
                else
                {
                    cart.Add(it);
                }
                Response.Redirect("Carrito.aspx");
            }
        }
    }
}