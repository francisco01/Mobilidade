<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="Mobilidade.Paginas.CadastroCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>

            <div class="box-titulo">
                Cadastro de usuário</div>
<div class="cadastro-cliente" style="height: 315px">
    <table style="text-align:left; font-weight: bold; width: 100%; height: 259px">
        <tr>
            <td style="width: 109px">Nome completo:</td>
            <td>
                <asp:TextBox ID="txtnome" runat="server" Width="304px" ></asp:TextBox>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 109px">Idade:</td>
            <td>
                <asp:TextBox ID="txtidade" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 109px; height: 26px">Sexo:</td>
            <td style="height: 26px">
                <asp:DropDownList ID="dplsexo" runat="server">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Masculino</asp:ListItem>
                    <asp:ListItem>Feminino</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 109px">Login:</td>
            <td>
                <asp:TextBox ID="txtlogin" runat="server" Width="303px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 109px">Senha:</td>
            <td>
                <asp:TextBox ID="txtsenha" runat="server" Width="139px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 109px; height: 26px;">CPF:</td>
            <td style="height: 26px">
                <asp:TextBox ID="txtcpf" runat="server" Width="183px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cadastrar" />
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 109px">&nbsp;</td>
            <td>
                <br />
                <asp:Label ID="lblacao" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
</div>
</>
<p>
</p>
</asp:Content>
