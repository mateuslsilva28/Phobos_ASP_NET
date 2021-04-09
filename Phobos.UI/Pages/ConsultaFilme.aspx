<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ConsultaFilme.aspx.cs" Inherits="Phobos.UI.Pages.ConsultaFilme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvUsuario" GridLines="None" AutoGenerateColumns="false" CssClass="table table-hover table-striped text-center" BackColor="Silver" runat="server">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id Usuário" />

            <asp:BoundField DataField="Titulo" HeaderText="Título" />
            <asp:BoundField DataField="Genero" HeaderText="Gênero" />
            <asp:BoundField DataField="Produtora" HeaderText="Produtora" />
            <asp:ImageField DataImageUrlField="UrlImg" HeaderText="Imagem" ControlStyle-Width="100" ControlStyle-Height="100" />
        </Columns>
    </asp:GridView>

    <p>
        <a href="IndexADM.aspx" class="btn btn-default">Voltar</a>
        <br /><br />
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </p>
</asp:Content>
