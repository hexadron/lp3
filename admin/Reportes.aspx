<%@ Page Title="" Language="C#" MasterPageFile="~/Skeu.master" AutoEventWireup="true" CodeFile="Reportes.aspx.cs" Inherits="admin_Reportes" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    Reporte de Ventas
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form class="content" id="form1" runat="server">
    <ul class="fields">
        <li>
            
            <CR:CrystalReportViewer ID="report" runat="server" 
                AutoDataBind="True" EnableDatabaseLogonPrompt="False"
                EnableParameterPrompt="False" GroupTreeImagesFolderUrl="" Height="50px" 
                ReportSourceID="VentasPorMes" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" 
                Width="350px" />
            
            <CR:CrystalReportSource ID="VentasPorMes" runat="server">
                <Report FileName="VentasPorMes.rpt">
                </Report>
            </CR:CrystalReportSource>
            
        </li>  
    </ul>
</form>
</asp:Content>


