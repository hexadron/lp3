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
            int id;
            if (int.TryParse(Request.Params["id"], out id))
            {
                var polo = Tshirts.find(id);

                if (polo != null)
                {
                    item.Value = polo.id.ToString();
                    foto.ImageUrl = polo.imagen;
                    nombre.Text = polo.name;
                    precio.Text = polo.price.ToString();
                    descripcion.Text = polo.description;
                    expirein.Value = ((DateTime)polo.expire_time).ToShortDateString();
                }
            }

        }
        else
        {
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