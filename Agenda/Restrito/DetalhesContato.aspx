<%@ Page Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="DetalhesContato.aspx.cs" Inherits="Agenda.Restrito.DetalhesContato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="principal" runat="server">

    <h1>Detalhes do Contato</h1>

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>

    Nome:<br />
    <asp:TextBox ID="txtNomeContato" runat="server" />
    <br />
    <br />

    Email:<br />
    <asp:TextBox ID="txtEmailContato" runat="server" />
    <br />
    <br />

    Telefone:<br />
    <asp:TextBox ID="txtTelefone" runat="server" />
    <br /><br />

    <asp:Button ID="btnAtualizarContato" runat="server" Text="Atualizar Contato" OnClick="btnAtualizarContato_Click" CssClass="btn btn-primary" /> &nbsp; &nbsp;
    <asp:Button ID="btnExcluirContato" runat="server" Text="Excluir Contato" OnClick="btnExcluirContato_Click" CssClass="btn btn-primary" />
</asp:Content>
