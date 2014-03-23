<%@ Page Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Consultarcontato.aspx.cs" Inherits="Agenda.Restrito.Consultarcontato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="principal" runat="server">

    <h1>Lista de Contatos</h1>

    <p>
        <asp:Label ID="lblMensagem" runat="server" />
    </p>

    <asp:GridView ID="gridContatos" runat="server" Width="100%" CssClass="table table-hover table-bordered">
        <EmptyDataTemplate>
            Nenhum Contato cadastrado no sistema
        </EmptyDataTemplate>

        <Columns>
            <asp:HyperLinkField
                Text="Ir para página de edições"
                DataNavigateUrlFields="IdContato"
                DataNavigateUrlFormatString="/Restrito/DetalhesContato.aspx?id={0}" />

        </Columns>
    </asp:GridView>

</asp:Content>
