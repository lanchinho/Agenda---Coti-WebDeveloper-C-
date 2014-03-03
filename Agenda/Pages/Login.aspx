<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Agenda.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Login</h1>
        <asp:Login
              ID="formLogin"
              runat="server"
              OnAuthenticate="AutenticarUsuario"
              TitleText="Formulário de Login"
              UserNameLabelText="Login de Acesso:"
              PasswordLabelText="Acessar Sistema"
              LoginButtonText="Entrar"
              DisplayRememberMe="false"
              FailureText="Acesso Negado, usuário ou senha inexistente. Tente novamente."
              DestinationPageUrl="/Restrito/Home.aspx" 
         />
         <hr />
         <a href="Cadastro.aspx">Criar Conta de Acesso</a>
       
    </div>
    </form>
</body>
</html>
