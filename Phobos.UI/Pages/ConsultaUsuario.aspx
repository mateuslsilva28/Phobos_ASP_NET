<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="Phobos.UI.Pages.ConsultaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvUsuario" GridLines="None" AutoGenerateColumns="false" CssClass="table table-hover table-striped text-center" BackColor="Silver" runat="server">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id Usuário" />

            <asp:BoundField DataField="Nome" HeaderText="Nome" />
            <asp:BoundField DataField="Cpf" HeaderText="Cpf" />
            <asp:BoundField DataField="DataNasc" HeaderText="Data de Nascimento" />
            <asp:BoundField DataField="TipoUsuario" HeaderText="Tipo de Usuário" />
        </Columns>
    </asp:GridView>
</asp:Content>
