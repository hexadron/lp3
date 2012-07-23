using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class admin_polos_Nuevo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            DateTime date;

            bool result = (DateTime.TryParseExact(TxtTiempoExpiracion.Text,
                "MM/dd/yyyy", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out date));

            if (result)
            {
                tshirt shirt = Tshirts.create(TxtNombre.Text,
                    TxtDescripcion.Text,
                    date,
                    Decimal.Parse(TxtPrecio.Text),
                    TxtFoto.Value);

                if (shirt != null)
                {
                    Response.Redirect("Index.aspx");
                }
            }
        }
    }
}