using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Success : System.Web.UI.Page
{
    private void RestartCart()
    {
        Session["cart"] = new List<CarItem>();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            string dir1="";
            string dir2 = "";
            var valores = Request.Params["direnv"].Split('@');
            dir1 = valores[0];
            dir2 = valores[1];
            if (dir1!="" && dir2!="")
            {
                var cart = (List<CarItem>)Session["cart"];
                var user = (client)Session["current_user"];

                sellOrder order = SellOrder.fromCart(cart);
                order.client_id = user.id;
                order.shipping_address = dir1;
                order.billing_address =dir2;

                SellOrder.save(order);

                RestartCart();

               // var order = SellOrder.find(id);

                if (order != null)
                {
                    nro.Text = order.id.ToString();
                    sent_where.Text = order.shipping_address;
                    sent_at.Text = ((DateTime)order.ordered_at).ToShortDateString();
                    mail.Text = order.client.email;
                    total.Text = "S/." + order.total.ToString();
                }
            }
        }
    }
}