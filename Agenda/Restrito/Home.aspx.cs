using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Entities;

namespace Agenda.Restrito
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Usuario u = Session["usuario"] as Usuario;
                lblNomeUsuario.Text = u.Login;
            }
        }
    }
}