<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Mobilidade.Paginas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="/Estilos/styloo.css" />
</head>
<body>

    <header>
	    <table>
        <tr>
            <td> <img src="../imagens/banner0.jpg" /> </td>
	        <td> <h1> Mobilidade Urbana </h1> </td>
            <td> <img src="../imagens/banner0.jpg" /> </td>
        </tr>
        </table>
    </header>

 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label runat="server" ID="lblDebug"></asp:Label>
    <form id="form1" runat="server">
    <div class="auto-style1">
        <h3>Logar no sistema</h3>
        <asp:Label runat="server" ID="lblLogin" Text="Usuário: "></asp:Label>
        <asp:TextBox runat="server" ID="txtLogin"></asp:TextBox><br /><br />
        <asp:Label runat="server" ID="lblSenha" Text="Senha: "></asp:Label>
        &nbsp;
        <asp:TextBox runat="server" ID="txtSenha" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Button runat="server" text="LOGAR" ID="btnLogar" OnClick="btnLogar_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Cadastre-se "></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cadastrar" />
        <br /><br />
    </div>
    </form>

    <footer>
        <h6> Desenvolvido pela Equipe Master </h6>
    </footer>
</body>
</html>
