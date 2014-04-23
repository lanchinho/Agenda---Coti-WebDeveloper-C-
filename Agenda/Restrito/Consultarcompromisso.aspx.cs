using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entities;
using DAL.Persistence;
using Agenda.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BLL.Business;

namespace Agenda.Restrito
{
    public partial class Consultarcompromisso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Session != null)
            {
                try
                {
                    Usuario u = Session["usuario"] as Usuario;

                    using (CompromissoDal compDal = new CompromissoDal())
                    {
                        gridCompromissos.DataSource = compDal.listaCompromissosDoUsuario(u.IdUsuario);
                        gridCompromissos.DataBind();
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }

        }

        protected void gridCompromissos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[1].Visible = false;
                e.Row.Cells[2].Text = "Título";
                e.Row.Cells[3].Text = "Descrição";
                e.Row.Cells[4].Text = "Data";
                e.Row.Cells[5].Visible = false;
      
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Visible = false;
                e.Row.Cells[5].Visible = false;
            }
        }

        protected void btnRelatorioCompromisso_Click(object sender, EventArgs e)
        {
            try
            {
                AgendaBll agenda = new AgendaBll();
                RptCompromisso cp = new RptCompromisso();

                cp.SetDataSource(agenda.relatorioCompromisso());
                cp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, true, "relatorio"); 
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}