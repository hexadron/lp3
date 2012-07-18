using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class admin_polos_Editar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GridView1.DataSource = Tshirts.all();
            GridView1.DataBind();
            // actualizar el polo
        }
        else
        {
            if (GridView1.SelectedRow != null)
            {
                Control ctrl = GetPostBackControl(Page);

                if (ctrl == null || ctrl != GridView1)
                {
                    int id = int.Parse(GridView1.SelectedRow.Cells[1].Text);

                    DateTime date;

                    bool result = (DateTime.TryParseExact(TxtTiempoExpiracion.Text,
                        "MM/dd/yyyy", CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out date));

                    if (result)
                    {
                        bool saved = Tshirts.update(id,
                            TxtNombre.Text,
                            TxtDescripcion.Text,
                            DateTime.Parse(TxtTiempoExpiracion.Text),
                            Decimal.Parse(TxtPrecio.Text));

                        if (saved)
                        {
                            Response.Redirect("Editar.aspx");
                        }
                    }

                }
            }

        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var row = GridView1.SelectedRow;

        if (row != null) {

            var id = int.Parse(row.Cells[1].Text);
            var expTime = row.Cells[2].Text.Split(' ').First().Split('/');

            DateTime date = new DateTime(
                int.Parse(expTime[2]),
                int.Parse(expTime[0]),
                int.Parse(expTime[1])
            );

            TxtTiempoExpiracion.Text = twoDigits(expTime[0]) + '/' + expTime[1] + '/' + expTime[2];
            TxtNombre.Text = row.Cells[3].Text;
            TxtDescripcion.Text = row.Cells[4].Text;
            TxtPrecio.Text = row.Cells[5].Text;
        }
    }

    public string twoDigits(string number)
    {
        if (number.Length == 1)
        {
            return "0" + number;
        }
        return number;
    }

    public static Control GetPostBackControl(Page page)
    {
        Control postbackControlInstance = null;

        string postbackControlName = page.Request.Params.Get("__EVENTTARGET");
        if (postbackControlName != null && postbackControlName != string.Empty)
        {
            postbackControlInstance = page.FindControl(postbackControlName);
        }
        else
        {
            // handle the Button control postbacks
            for (int i = 0; i < page.Request.Form.Keys.Count; i++)
            {
                postbackControlInstance = page.FindControl(page.Request.Form.Keys[i]);
                if (postbackControlInstance is System.Web.UI.WebControls.Button)
                {
                    return postbackControlInstance;
                }
            }
        }
        // handle the ImageButton postbacks
        if (postbackControlInstance == null)
        {
            for (int i = 0; i < page.Request.Form.Count; i++)
            {
                if ((page.Request.Form.Keys[i].EndsWith(".x")) || (page.Request.Form.Keys[i].EndsWith(".y")))
                {
                    postbackControlInstance = page.FindControl(page.Request.Form.Keys[i].Substring(0, page.Request.Form.Keys[i].Length - 2));
                    return postbackControlInstance;
                }
            }
        }
        return postbackControlInstance;
    }



}