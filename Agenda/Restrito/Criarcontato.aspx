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
        ForeColor="Red" />
    <br />
    <br />

    Email:<br />
    <asp:TextBox ID="txtEmailContato" runat="server" />
    <asp:RegularExpressionValidator
        ID="reqEmailContato"
        runat="server"
        ControlToValidate="txtEmailContato"
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        ErrorMessage="Email inválido" />
    <br />
    <br />

    Telefone - xx-xxxx-xxxx:<br />
    <asp:TextBox ID="txtTelefoneContato" runat="server" />
    <asp:RegularExpressionValidator 
        ID="reqTelContato"
        runat="server"
        ControlToValidate="txtTelefoneContato"
        ValidationExpression="^10|[1-9]{2}-([2-9][0-9]{3}-[0-9]{4}|[2-9][0-9]{4}-[0-9]{4})$"
        ErrorMessage="Número de telefone inválido"/>
    <br />
    <br />

    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Contato" OnClick="btnCadastro_Click" CssClass="btn btn-primary" />

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>

</asp:Content>



