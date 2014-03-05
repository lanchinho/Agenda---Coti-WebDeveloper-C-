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
    public partial class Criarcontato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Contato c = new Contato();
                c.NomeContato = txtNomeContato.Text;
                c.EmailContato = txtEmailContato.Text;
                c.Telefone = txtTelefoneContato.Text;

                using (ContatoDal cDal = new ContatoDal())
                {
                    cDal.salvarContato(c);
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