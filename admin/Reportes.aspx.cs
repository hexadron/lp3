using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

public partial class admin_Reportes : System.Web.UI.Page
{
    SellOrder order = new SellOrder();   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) {
            ReportDocument rd = new ReportDocument();
            rd.Load(Server.MapPath("CrystalReport.rpt"));
            if (order.listarOrdenes()!= null) {
                rd.SetDataSource(order.listarOrdenes());
                
            }
            
            CrystalReportViewer1.ReportSource = rd;
            CrystalReportViewer1.DataBind();
        }
    }
    protected void CrystalReportViewer1_Init(object sender, EventArgs e)
    {
        
    }
}