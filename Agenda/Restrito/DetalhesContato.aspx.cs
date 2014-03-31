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
    public partial class DetalhesContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    using (ContatoDal contDal = new ContatoDal())
                    {
                        int idContato = Convert.ToInt32(Request.QueryString["id"]);

                        Contato contato = contDal.obterContatoPorId(idContato);

                        txtNomeContato.Text  = contato.NomeContato;
                        txtEmailContato.Text = contato.EmailContato;
                        txtTelefone.Text     = contato.Telefone;
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }

        }

        protected void btnExcluirContato_Click(object sender, EventArgs e)
        {
            try
            {
                using (ContatoDal contDal = new ContatoDal())
                {
                    int idContato = Convert.ToInt32(Request.QueryString["id"]);
                    Contato contato = contDal.obterContatoPorId(idContato);

                    contDal.excluirContato(contato);

                    lblMensagem.Text = "Contato " + contato.NomeContato + ", excluido com sucesso.";

                    txtNomeContato.Text = string.Empty;
                    txtEmailContato.Text = string.Empty;
                    txtTelefone.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {  
                lblMensagem.Text = ex.Message;
            }

        }

        protected void btnAtualizarContato_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();

                contato.IdContato = Convert.ToInt32(Request.QueryString["id"]);
                contato.NomeContato = txtNomeContato.Text;
                contato.EmailContato = txtEmailContato.Text;
                contato.Telefone = txtTelefone.Text;

                using(ContatoDal contDal = new ContatoDal())
                {
                    contDal.atualizarContato(contato);
                    lblMensagem.Text = "Dados atualizados com sucesso.";
                }

            }
            catch (Exception ex)
            {
                
                lblMensagem.Text = ex.Message;
            }
        }
    }
}