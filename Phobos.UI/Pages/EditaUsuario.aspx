<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="EditaUsuario.aspx.cs" Inherits="Phobos.UI.Pages.EditaUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron jumbotron-fluid bg-dark">
        <div class="container bg-dark">
            <h1 class="text-light lead font-weight-light">Cadastro de Usuários</h1>
            <br />
            <asp:Label runat="server" Text="Id" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtId" CssClass="form-control" Width="15%" MaxLength="5" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-warning" onclick="btnPesquisar_Click"/>
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
            <asp:Label ID="lblTituloSumir" runat="server" Text="Tipo de Usuário" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtTipoUsuario" CssClass="form-control" Width="50%" runat="server"></asp:TextBox>
            <br />
            <asp:Panel ID="pnlTipoUsuario" runat="server">
                <asp:Label runat="server" Text="Selecione o tipo de usuário" CssClass="text-light lead"></asp:Label>
                <asp:RadioButtonList ID="rblTipo" CssClass="custom-radio text-light" runat="server">
                    <asp:ListItem Value="1" Text="Administrador"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Outros"></asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel>
            <br />
            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger" OnClick="btnExcluir_Click" OnClientClick="if (!confirm('Deseja realmente excluir esse registro? ')) return false;"/>
            <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-info" OnClick="btnEditar_Click"/>
            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btn btn-info" OnClick="btnConfirmar_Click"/>
            <br />
            <a class="btn btn-secondary text-light lead" href="IndexADM.aspx">Voltar</a>
            <br />
            <asp:Label ID="lblMensagem" runat="server" CssClass="text-light lead"></asp:Label>
        </div>
    </div>
</asp:Content>
