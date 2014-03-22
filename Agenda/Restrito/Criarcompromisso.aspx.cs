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
    public partial class Criarcompromisso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastraCompromisso_Click(object sender, EventArgs e)
        {
            try
            {
                Compromisso comp = new Compromisso();
                comp.Titulo = txtTituloCompromisso.Text;
                comp.Descricao = txtDescricao.Text;
                comp.Data = Calendar1.SelectedDate;

                if (Session != null)
                {
                    Usuario u = Session["usuario"] as Usuario;

                    using (CompromissoDal compDal = new CompromissoDal())
                    {
                        comp.IdUsuario = u.IdUsuario;
                        compDal.salvarCompromisso(comp);
                    }
                }

                Response.Redirect("Home.aspx");
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}
