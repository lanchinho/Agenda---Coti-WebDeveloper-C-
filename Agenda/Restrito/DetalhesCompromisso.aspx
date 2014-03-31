<%@ Page Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="DetalhesCompromisso.aspx.cs" Inherits="Agenda.Restrito.DetalhesCompromisso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="principal" runat="server">

    <h1>Detalhes do Contato</h1>

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>

    Título<br />
    <asp:TextBox ID="txtTituloEdicao" runat="server" />
    <br /><br />

    Descrição<br />
    <asp:TextBox ID="txtDescricaoEdicao" runat="server" TextMode="MultiLine" Height="200px" />
    <br /><br />
     
    Data:
    <br />
    <asp:Calendar ID="Calendar1" runat="server" />
    <br />
    <br />

    <asp:Button ID="btnAtualizarCompromisso" runat="server" Text="Atualizar Compromisso" OnClick="btnAtualizarCompromisso_Click" CssClass="btn btn-primary" /> &nbsp; &nbsp;
    <asp:Button ID="btnExcluirContato" runat="server" Text="Excluir Compromisso" OnClick="btnExcluirContato_Click" CssClass="btn btn-primary" />

</asp:Content>