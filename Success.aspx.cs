using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            int id;
            if (int.TryParse(Request.Params["id"], out id))
            {
                var order = SellOrder.find(id);

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