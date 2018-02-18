<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Problema.aspx.cs" Inherits="Mobilidade.Paginas.ConsultaLocacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
</p>
<div style="height: 232px">
    <table style="text-align:left; font-weight: bold; color: brown; font-size: large; width: 100%">
        <tr>
            <td style="width: 190px; height: 44px;">Selecione o tipo de serviço:</td>
            <td style="width: 358px; height: 44px;">
                <asp:DropDownList ID="DropDowntipo" runat="server" OnSelectedIndexChanged="dpltipo_SelectedIndexChanged" AutoPostBack="True">
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
                </td>
            <td style="width: 156px; height: 44px;">
                Selecione o nome:</td>
            <td style="height: 44px">
                <asp:DropDownList ID="DropDownnome" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td style="width: 358px">
                &nbsp;</td>
            <td style="width: 156px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 190px; height: 24px;">Informe a data:</td>
            <td style="width: 358px; height: 24px">
                <asp:TextBox ID="txtdata" runat="server"></asp:TextBox>
            </td>
            <td style="width: 156px; height: 24px">
                Selecione o tipo de problema:</td>
            <td style="height: 24px">
                <asp:DropDownList ID="DropDownprobl" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 190px">&nbsp;</td>
            <td style="width: 358px">
                &nbsp;</td>
            <td style="width: 156px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 190px">Relatar Problema:</td>
            <td style="width: 358px">
                <asp:TextBox ID="txtcomnt" runat="server" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td style="width: 156px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 190px">
                <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
            </td>
            <td style="width: 358px">
                &nbsp;</td>
            <td style="width: 156px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <br />
                <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="width: 156px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</div>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
