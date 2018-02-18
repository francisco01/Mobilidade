<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="RemoverPermissaoAdmin.aspx.cs" Inherits="Mobilidade.Paginas.RemoverPermissaoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td style="width: 195px">Informe Login</td>
            <td>
                <asp:TextBox ID="txtLogin" runat="server" Width="161px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 195px">
                <asp:Button ID="btnRemover" runat="server" OnClick="btnRemover_Click" Text="Revogar" />
            </td>
            <td>
                <asp:Label ID="lblMensagem" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 195px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
