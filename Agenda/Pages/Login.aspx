<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Agenda.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../Content/css/lavish-bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="/Pages/Login.aspx">Agenda Virtual</a>
                </div>
            </div>
        </div>

        <div class="container">
            <asp:Login
                ID="formLogin"
                runat="server"
                OnAuthenticate="AutenticarUsuario"
                TitleText=""
                TextLayout="TextOnTop"
                UserNameLabelText="Usuário"
                PasswordLabelText="Senha"
                LabelStyle-Font-Size="Large"
                LoginButtonText="Entrar"
                DisplayRememberMe="false"
                FailureText="Acesso Negado, usuário ou senha inexistente. Tente novamente."
                DestinationPageUrl="/Restrito/Home.aspx"
                LoginButtonStyle-CssClass="btn btn-primary btn-block"
                TextBoxStyle-CssClass="form-control"
                CreateUserUrl="~/Pages/Cadastro.aspx"
                CreateUserText="Criar Conta de Acesso"
                />
            <br /><br />

            <footer>
                <p>&copy; Guilherme "Lanchinho" 2014</p>
            </footer>
        </div>

        <script src="../Scripts/jquery-2.1.0.min.js"></script>
        <script src="../Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>
