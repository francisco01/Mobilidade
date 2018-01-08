<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Avaliar.aspx.cs" Inherits="Mobilidade.Paginas.ConsultaClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
</p>
<p>
</p>
    <div style="height: 500px">
    <br />
    <table style="text-align:left; font-weight: bold; color: brown; font-size: large; width: 100%">
        <tr>
            <td style="width: 109px">Tipo Serviço:</td>
            <td style="width: 432px">
                <asp:DropDownList ID="DropDowntipo" runat="server" OnSelectedIndexChanged="DropDowntipo_SelectedIndexChanged" AutoPostBack="True">
                    <asp:ListItem>Escolher</asp:ListItem>
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;
            </td>
            <td style="width: 78px">Nome:&nbsp;&nbsp; </td>
            <td>
                <asp:DropDownList ID="DropDownnome" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 109px">&nbsp;</td>
            <td style="width: 432px">
                &nbsp;</td>
            <td style="width: 78px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 109px; height: 26px;">Nota:</td>
            <td style="width: 432px; height: 26px;">
                <asp:TextBox ID="txtnota" runat="server" TextMode="Number" Width="109px" Enabled="False" MaxLength="2" ToolTip="Digite Nota de 0 a 10"></asp:TextBox>
            </td>
            <td style="width: 78px; height: 26px"></td>
            <td style="height: 26px"></td>
        </tr>
        <tr>
            <td style="width: 109px">Comentario:</td>
            <td style="width: 432px">
                <asp:TextBox ID="txtcoment" runat="server" TextMode="MultiLine" Width="314px" Enabled="False"></asp:TextBox>
            </td>
            <td style="width: 78px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 109px">&nbsp;</td>
            <td style="width: 432px">
                <br />
                <asp:Label ID="lblacao" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="width: 78px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 109px">
                &nbsp;</td>
            <td style="width: 432px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btngravar" runat="server" OnClick="btngravar_Click" Text="Salvar" Enabled="False" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            <td style="width: 78px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
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
</asp:Content>
