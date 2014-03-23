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
            if (!IsPostBack)
            {
                try
                {
                    if (Session != null)
                    {
                        Usuario u = Session["usuario"] as Usuario;

                        using (ContatoDal contDal = new ContatoDal())
                        {
                            gridContatos.DataSource = contDal.listarTodosDoUsuario(u.IdUsuario);
                            gridContatos.DataBind();
                        }
                    }

                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }

        }
    }
}