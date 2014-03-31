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
    public partial class DetalhesCompromisso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    using (CompromissoDal compDal = new CompromissoDal())
                    {
                        int idCompromisso = Convert.ToInt32(Request.QueryString["id"]);

                        Compromisso compromisso = compDal.obterCompromissoPeloId(idCompromisso);

                        txtTituloEdicao.Text = compromisso.Titulo;
                        txtDescricaoEdicao.Text = compromisso.Descricao;
                        Calendar1.SelectedDate = compromisso.Data;
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = ex.Message;
                }
            }
        }

        protected void btnAtualizarCompromisso_Click(object sender, EventArgs e)
        {
            try
            {
                Compromisso compromisso = new Compromisso();

                compromisso.IdCompromisso = Convert.ToInt32(Request.QueryString["id"]);
                compromisso.Titulo = txtTituloEdicao.Text;
                compromisso.Descricao = txtDescricaoEdicao.Text;
                compromisso.Data = Calendar1.SelectedDate;

                using(CompromissoDal compDal = new CompromissoDal())
                {
                    compDal.atualizarCompromisso(compromisso);
                    lblMensagem.Text = "Informações do Compromisso foram atualizadas com sucesso."; 
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluirContato_Click(object sender, EventArgs e)
        {
            try
            {
                using (CompromissoDal compDal = new CompromissoDal())
                {
                    int idCompromisso = Convert.ToInt32(Request.QueryString["id"]);
                    Compromisso compromisso = compDal.obterCompromissoPeloId(idCompromisso);

                    compDal.excluirCompromisso(compromisso);

                    lblMensagem.Text = "Compromisso" + compromisso.Titulo + ", excluido com sucesso.";

                    txtTituloEdicao.Text = string.Empty;
                    txtDescricaoEdicao.Text = string.Empty;
                    Calendar1.SelectedDate = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}