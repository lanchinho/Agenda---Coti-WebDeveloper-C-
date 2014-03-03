using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entities;
using DAL.Persistence;
using System.Web.Security;

namespace Agenda.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario u = new Usuario();
                u.Nome = txtNome.Text;
                u.Login = txtLogin.Text;
                u.Email = txtEmail.Text;
                u.Senha = FormsAuthentication.
                          HashPasswordForStoringInConfigFile(txtSenha.Text, "MD5");
                
                using(UsuarioDal userDal = new UsuarioDal())
                {
                    userDal.salvarUsuario(u);
                }

                lblMensagem.Text = "Usuário" + u.Nome + ", cadastrado com sucesso.";
                Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }
        }
    }
}