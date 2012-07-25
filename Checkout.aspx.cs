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
                cantidad.Text = cantidadTotal.ToString();
                total.Text = precioTotal.ToString();
            }
        }
    }

   
    protected void checkout_Click(object sender, EventArgs e)
    {
        double final = double.Parse(total.Text);
        final = Math.Round(final / 2.6,2);
        //Build a URL String for the redirect
        string redirecturl = "https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_xclick&business=seller_1343017358_biz@gmail.com&item_name=Payment+for+Services";

        //First name i assign static based on login details assign this value
        redirecturl += "&first_name=Jhon";

        //City i assign static based on login user detail you change this value
        redirecturl += "&city=Lima";

        //State i assign static based on login user detail you change this value
        redirecturl += "&state=Peru";

        //Product Name
        redirecturl += "&item_name=Total";

        //Product Amount
        redirecturl += "&amount="+final;

        //Business contact id
        //redirecturl += "&business=nravindranmcaatgmail.com";

        //Shipping charges if any
        //redirecturl += "&shipping=5";

        //Handling charges if any
        //redirecturl += "&handling=5";

        //Tax amount if any
        //redirecturl += "&tax=5";

        //Add quatity i added one only statically 
        //redirecturl += "&quantity="+cantidad.Text;

        //Currency code 
        //redirecturl += "¤cy=USD";

        //Success return page url
        redirecturl += "&return=http://localhost:55986/lp3/Success.aspx?direnv=" + shipping_address.Text +"@"+billing_address.Text;

        //Failed return page url
        redirecturl += "&cancel_return=http://localhost:55986/lp3/Carrito.aspx";

        Response.Redirect(redirecturl);
    }
}