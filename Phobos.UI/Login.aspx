<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Phobos.UI.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.css" />
    <script src="Scripts/jquery-3.5.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery.mask.min.js"></script>
    <title></title>
</head>
<body class="bg-dark">
    <form id="form1" runat="server">
        <div class="container bg-dark">
            <br />
            <h1 class="text-light font-weight-light">Phobos Anomaly</h1>
            <br />
            <asp:Label runat="server" CssClass="text-light lead" Text="Usuário"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtUsuario" CssClass="form-control" MaxLength="50" Width="50%" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredNome" runat="server" ErrorMessage="Digite o nome do usuário" ForeColor="Red" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
            <br />
            <asp:Label runat="server" CssClass="text-light lead" Text="Senha"></asp:Label>
            <asp:TextBox AutoCompleteType="Disabled" ID="txtSenha" CssClass="form-control" MaxLength="6" Width="50%" TextMode="Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredSenha" runat="server" ErrorMessage="Digite a senha do usuário" ForeColor="Red" ControlToValidate="txtSenha"></asp:RequiredFieldValidator>
            <br />
            <asp:Button ID="btnEntrar" runat="server" Text="Entrar" CssClass="btn btn-secondary" OnClick="btnEntrar_Click" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-secondary"/>
            <br />
            <asp:Label runat="server" ID="lblMensagem" CssClass="text-light lead"></asp:Label>
            
        </div>
    </form>
</body>
</html>
