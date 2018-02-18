<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="PermissaoAdmin.aspx.cs" Inherits="Mobilidade.Paginas.PermissaoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td style="width: 226px">Informe Login Desejado:</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="183px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 226px; height: 23px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Autorizar" Width="90px" />
        </td>
        <td style="height: 23px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
        <td style="height: 23px"></td>
    </tr>
    <tr>
        <td style="width: 226px">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
