<%@ Page Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Criarcontato.aspx.cs" Inherits="Agenda.Restrito.Criarcontato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="principal" runat="server">
    Nome do Contato: <br />
    <asp:TextBox ID="txtNomeContato" runat="server" />
    <br /><br />

    Email:<br />
    <asp:TextBox ID="txtEmailContato" runat="server" />
    <br /><br />

    Telefone:<br />
    <asp:TextBox ID="txtTelefoneContato" runat="server" />
    <br /><br />

    <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar Contato" OnClick="btnCadastro_Click"/>

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>

</asp:Content>



