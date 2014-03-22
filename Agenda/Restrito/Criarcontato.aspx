<%@ Page Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Criarcontato.aspx.cs" Inherits="Agenda.Restrito.Criarcontato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="principal" runat="server">
    Nome do Contato:
    <br />
    <asp:TextBox ID="txtNomeContato" runat="server" />
    <asp:RequiredFieldValidator
        ID="reqNomeContato"
        runat="server"
        ControlToValidate="txtNomeContato"
        ErrorMessage="Por favor, informe o nome."
        ForeColor="Red"/>
    <br />
    <br />

    Email:<br />
    <asp:TextBox ID="txtEmailContato" runat="server" />
    <asp:RegularExpressionValidator
        ID="reqEmailContato"
        runat="server"
        ControlToValidate="txtEmailContato"
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        ErrorMessage="Email Inválido" />
    <br />
    <br />

    Telefone:<br />
    <asp:TextBox ID="txtTelefoneContato" runat="server" />
    <asp:RegularExpressionValidator
        ID="reqTelContato"
        runat="server"
        ControlToValidate="txtTelefoneContato"
        ValidationExpression="\(\d{2}\)\d{3}-\d{4}|\d{4}-\d{4}"
        ErrorMessage="Número de Telefone Inválido" />
    <br />
    <br />

    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Contato" OnClick="btnCadastro_Click" CssClass="btn btn-primary" />

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>

</asp:Content>



