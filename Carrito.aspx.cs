using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        if (Session["current_user"] != null)
        {
            logPanel.Visible = false;
            Pasarela.Visible = true;
        }
        else
        {
            logPanel.Visible = true;
            Pasarela.Visible = false;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<CarItem> cart = (List<CarItem>) Session["cart"];
            var cantidadTotal = 0;
            decimal precioTotal = 0;
            foreach (CarItem c in cart)
            {
                cantidadTotal += c.qty;
                precioTotal += (decimal)c.shirt.price * (decimal)c.qty;
            }
            carritoRepeater.DataSource = cart;
            carritoRepeater.DataBind();
            precio.Text = precioTotal.ToString();
            cantidad.Text = cantidadTotal.ToString();
        }
        else
        {
            var cart = (List<CarItem>)Session["cart"];
            var forDelete = new List<CarItem>();

            foreach (RepeaterItem r in carritoRepeater.Items)
            {

                int qty;
                var value = (r.FindControl("qty") as TextBox).Text;
                Int32.TryParse(value, out qty);
                if (qty > 0) {
                    var id = int.Parse((r.FindControl("itemShirt") as HiddenField).Value);

                    var item = cart.Find(cItem => cItem.shirt.id == id);

                    item.qty = qty;

                    if (item.qty == 0)
                    {
                        forDelete.Add(item);
                    }
                }         

                
            }

            foreach (var sentenced in forDelete)
            {
                cart.Remove(sentenced);
            }

            cart = (List<CarItem>)Session["cart"];
            var cantidadTotal = 0;
            decimal precioTotal = 0;
            foreach (CarItem c in cart)
            {
                cantidadTotal += c.qty;
                precioTotal += (decimal)c.shirt.price * (decimal)c.qty;
            }
            carritoRepeater.DataSource = cart;
            carritoRepeater.DataBind();
            precio.Text = precioTotal.ToString();
            cantidad.Text = cantidadTotal.ToString();
        }
    }
    protected void logueo_Click(object sender, EventArgs e)
    {
        HttpCookie page = new HttpCookie("carrito");
        page.Values["value"] = "Carrito.aspx";
        Response.Cookies.Add(page);
        Response.Redirect("Login.aspx");
    }
    protected void updateCart_Click(object sender, EventArgs e)
    {

    }
}