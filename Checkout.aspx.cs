using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Checkout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<CarItem> cart = (List<CarItem>)Session["cart"];
            var cantidadTotal = 0;
            decimal precioTotal = 0;
            if (cart != null)
            {
                foreach (CarItem c in cart)
                {
                    cantidadTotal += c.qty;
                    precioTotal += (decimal)c.shirt.price * (decimal)c.qty;
                }
                carritoRepeater.DataSource = cart;
                carritoRepeater.DataBind();

                total.Text = precioTotal.ToString();
            }
        }
        else
        {
            var cart = (List<CarItem>)Session["cart"];
            var user = (client)Session["current_user"];

            sellOrder order = SellOrder.fromCart(cart);
            order.client_id = user.id;
            order.shipping_address = shipping_address.Text;
            order.billing_address = billing_address.Text;

            SellOrder.save(order);

            RestartCart();
            Response.Redirect("Success.aspx?id=" + order.id);
        }
    }

    private void RestartCart()
    {
        Session["cart"] = new List<CarItem>();
    }
}