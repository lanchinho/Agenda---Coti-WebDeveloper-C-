<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Agenda.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
            <h1>Cadastro de Usuário</h1>

            Nome:
            <br />
            <asp:TextBox ID="txtNome" runat="server" />
            <asp:RequiredFieldValidator
                ID="reqNome"
                runat="server"
                ControlToValidate="txtNome"
                ErrorMessage="Por favor, informe o nome."
                ForeColor="Red" />
            <br />
            <br />

            Login:<br />
            <asp:TextBox ID="txtLogin" runat="server" />
            <asp:RequiredFieldValidator
                ID="reqLogin"
                runat="server"
                ControlToValidate="txtLogin"
                ErrorMessage="Por favor, informe o login."
                ForeColor="Red" />
            <br />
            <br />

            Email:<br />
            <asp:TextBox ID="txtEmail" runat="server" />
            <asp:RegularExpressionValidator
                ID="reqEmail"
                runat="server"
                ControlToValidate="txtEmail"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                ErrorMessage="Email inválido" />
            <br />
            <br />

            Senha:<br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator
                ID="reqSenha"
                runat="server"
                ControlToValidate="txtSenha"
                ErrorMessage="Informe a senha de acesso."
                ForeColor="Red" />
            <br />
            <br />

            Confirme sua senha:
            <br />
            <asp:TextBox ID="txtSenhaConfirmada" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator
                ID="reqSenhaConfirmada"
                runat="server"
                ControlToValidate="txtSenhaConfirmada"
                ErrorMessage="Por favor, confirme sua senha."
                ForeColor="Red" />
            <br />
            <br />

            <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Usuário" OnClick="btnCadastro_Click" CssClass="btn btn-primary"/>

            <p>
                <asp:Label ID="lblMensagem" runat="server" />
            </p>

            <footer>
                <p>&copy; Guilherme "Lanchinho" 2014</p>
            </footer>

        </div>

        <script src="../Scripts/jquery-2.1.0.min.js"></script>
        <script src="../Scripts/bootstrap.min.js"></script>
    </form>
</body>
</html>

