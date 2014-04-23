using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entities;
using DAL.Persistence;
using Agenda.Reports;
using BLL.Business;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Agenda.Restrito
{
    public partial class Consultarcontato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session != null)
            {
                try
                {

                    Usuario u = Session["usuario"] as Usuario;

                    using (ContatoDal contDal = new ContatoDal())
                    {
                        gridContatos.DataSource = contDal.listarContatosDoUsuario(u.IdUsuario);
                        gridContatos.DataBind();
                    }

                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }

        }

        protected void gridContatos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[1].Visible = false;
                e.Row.Cells[2].Text = "Nome";
                e.Row.Cells[3].Text = "Email";
                e.Row.Cells[4].Text = "Telefone";
                e.Row.Cells[5].Visible = false;
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Visible = false;
                e.Row.Cells[5].Visible = false;
            }

        }

        protected void btnRelatorioContato_Click(object sender, EventArgs e)
        {
            try
            {
                AgendaBll agenda = new AgendaBll();
                RptContato ct = new RptContato();

                ct.SetDataSource(agenda.relatorioContato());
                ct.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "relatorio");
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }

        }
    }
}