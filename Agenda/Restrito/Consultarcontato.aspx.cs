using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entities;
using DAL.Persistence;

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
    }
}