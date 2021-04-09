<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CadastraUsuario.aspx.cs" Inherits="Phobos.UI.Pages.CadastraUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron jumbotron-fluid bg-dark">
        <div class="container bg-dark">
            <h1 class="text-light lead font-weight-light">Cadastro de Usuários</h1>
            <br />
            <asp:Label runat="server" Text="Nome" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtNome" CssClass="form-control" Width="50%" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="CPF" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtCpf" CssClass="cpf form-control" Width="50%" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Senha" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtSenha" CssClass="form-control" Width="50%" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Data de Nascimento" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtDataNasc" CssClass="date form-control" Width="50%" runat="server"></asp:TextBox>
            <br />

            <asp:Label runat="server" Text="Selecione o tipo do usuário" CssClass="text-light lead"></asp:Label>
            <asp:RadioButtonList ID="rblTipo" CssClass="form-control-range text-light lead" runat="server">
                <asp:ListItem Value="1" Text="Administrador"></asp:ListItem>
                <asp:ListItem Value="2" Text="Outros"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" CssClass="btn btn-secondary" OnClick="btnCadastrar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary" />
            <br />
            <a class="btn btn-secondary text-light lead" href="IndexADM.aspx">Voltar</a>
            <br />
            <asp:Label ID="lblMensagem" runat="server" CssClass="text-light lead"></asp:Label>
        </div>
    </div>
</asp:Content>
