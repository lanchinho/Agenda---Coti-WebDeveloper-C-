<%@ Page Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Criarcompromisso.aspx.cs" Inherits="Agenda.Restrito.Criarcompromisso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="principal" runat="server">
    Título do Compromisso: <br />
    <asp:TextBox ID="txtTituloCompromisso" runat="server" />
    <br /><br />

    Descrição: <br />
    <asp:TextBox ID="txtDescricao" runat="server" Height="200px" TextMode="MultiLine" />
    <br /><br />

    Data: <br />
    <asp:Calendar ID="Calendar1" runat="server"/>
    <br /><br />

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>

    <asp:Button ID="btnCadastraCompromisso" runat="server" OnClick="btnCadastraCompromisso_Click" CssClass="btn btn-primary" Text="Cadastrar Compromisso" />

</asp:Content>
