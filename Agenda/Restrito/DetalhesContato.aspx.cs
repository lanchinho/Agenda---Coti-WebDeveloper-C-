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

                        Contato c = contDal.obterContatoPorId(idContato);

                        txtNomeContato.Text = c.NomeContato;
                        txtEmailContato.Text = c.EmailContato;
                        txtTelefone.Text = c.Telefone;
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
                    Contato c = contDal.obterContatoPorId(idContato);

                    contDal.excluirContato(c);

                    lblMensagem.Text = "Contato " + c.NomeContato + ", excluido com sucesso.";

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
                Contato c = new Contato();

                c.IdContato = Convert.ToInt32(Request.QueryString["id"]);
                c.NomeContato = txtNomeContato.Text;
                c.EmailContato = txtEmailContato.Text;
                c.Telefone = txtTelefone.Text;

                using(ContatoDal contDal = new ContatoDal())
                {
                    contDal.atualizarContato(c);
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