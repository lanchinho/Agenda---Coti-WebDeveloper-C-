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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void AutenticarUsuario(object sender, AuthenticateEventArgs e)
        {
            try
            {
                Usuario u = new Usuario();
                u.Login = formLogin.UserName;
                u.Senha = FormsAuthentication.HashPasswordForStoringInConfigFile(formLogin.Password, "MD5");

                using (UsuarioDal uDal = new UsuarioDal())
                {
                    //Resgata o ID do usuário...
                    int idUsuario = uDal.verificaUsuario(u);

                    if (idUsuario != 0)
                    {
                        //Coloca o ID do usuário atual dentro da sessão.
                        u.IdUsuario = idUsuario;
                        Session.Add("usuario", u);
                        Session.Timeout = 2;
                        e.Authenticated = true;
                    }
                    else
                        e.Authenticated = false;
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}