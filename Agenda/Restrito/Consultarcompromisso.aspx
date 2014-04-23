<%@ Page Language="C#" MasterPageFile="~/Shared/Layout.Master" AutoEventWireup="true" CodeBehind="Consultarcompromisso.aspx.cs" Inherits="Agenda.Restrito.Consultarcompromisso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="principal" runat="server">
    <h1>Lista de Compromissos</h1>

     <p>
         <asp:Label ID="lblMensagem" runat="server" />
     </p>

    <asp:GridView ID="gridCompromissos" runat="server" Width="100%" CssClass="table table-hover table-bordered" OnRowDataBound="gridCompromissos_RowDataBound">
        <EmptyDataTemplate>
            Sua agemda esta vazia ! Nenhum compromisso cadastrado
        </EmptyDataTemplate>

        <Columns>
            <asp:HyperLinkField
                Text="Editar Compromisso"
                DataNavigateUrlFields="IdCompromisso"
                DataNavigateUrlFormatString="/Restrito/DetalhesCompromisso.aspx?id={0}" />
        </Columns>
    </asp:GridView>

    <asp:Button ID="btnRelatorioCompromisso" runat="server" Text="Gerar Relatório" CssClass="btn btn-success" OnClick="btnRelatorioCompromisso_Click" />

</asp:Content>