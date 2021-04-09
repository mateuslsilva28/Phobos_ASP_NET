<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CadastraFilme.aspx.cs" Inherits="Phobos.UI.Pages.CadastraFilme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron jumbotron-fluid bg-dark">
        <div class="container bg-dark">
            <h1 style="font-size: 60px" class="text-light lead font-weight-light">Cadastro de Filmes</h1>
            <br />
            <asp:Label runat="server" Text="Titulo" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtTitulo" CssClass="form-control" Width="50%" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredTitulo" runat="server" ErrorMessage="Título do filme é obrigatório" ForeColor="Red" ControlToValidate="txtTitulo"></asp:RequiredFieldValidator>
            <br />
            <asp:Label runat="server" Text="Genero" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtGenero" CssClass="form-control" Width="50%" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredGenero" runat="server" ErrorMessage="Gênero do filme é obrigatório" ForeColor="Red" ControlToValidate="txtGenero"></asp:RequiredFieldValidator>
            <br />
            <asp:Label runat="server" Text="Proddutora" CssClass="text-light lead"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtProdutora" CssClass="form-control" Width="50%" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredProdutora" runat="server" ErrorMessage="Produtora do filme é obrigatório" ForeColor="Red" ControlToValidate="txtProdutora"></asp:RequiredFieldValidator>
            <br />
            <asp:Label runat="server" Text="Selecione a categoria do filme" CssClass="text-light lead"></asp:Label>
            <asp:RadioButtonList ID="rblClassificacao" CssClass="form-control-range text-light lead" runat="server">
                <asp:ListItem Value="1" Text="Livre"></asp:ListItem>
                <asp:ListItem Value="2" Text="+18"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:FileUpload ID="flp1" Text="Selecione a imagem" CssClass="btn btn-secondary" runat="server" />
            <asp:Button runat="server" ID="btnCadastrar" Text="Cadastrar" CssClass="btn btn-secondary" OnClick="btnCadastrar_Click"/>
            <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" CssClass="btn btn-secondary"/>
            <br />
            <a class="btn btn-secondary text-light lead" href="IndexADM.aspx">Voltar</a>
            <br />
            <asp:Label ID="lblMensagem" runat="server" CssClass="text-light lead"></asp:Label>
        </div>
    </div>
</asp:Content>
