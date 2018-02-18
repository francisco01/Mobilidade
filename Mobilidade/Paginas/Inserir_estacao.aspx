<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Inserir_estacao.aspx.cs" Inherits="Mobilidade.Paginas.Inserir_estacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td style="width: 219px">&nbsp;</td>
        <td style="width: 240px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Selecione o tipo de serviço:</td>
        <td style="width: 240px">
            <asp:DropDownList ID="DropDowntipo" runat="server" Height="16px" OnSelectedIndexChanged="DropDowntipo_SelectedIndexChanged" style="margin-left: 0px" Width="152px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">&nbsp;</td>
        <td style="width: 240px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Nome</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtnome" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Integra Aeroporto</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtaero" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Integra Metro</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtmetro" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Metro Superficie</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtsuprf" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Integra Onibus</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtbus" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Integra BRT</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtbrt" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Integra VLT</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtvlt" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Integra Trem</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txttrem" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Integra Teleferico</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txttelef" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Integra Barca</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtbarca" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Comprimento</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtcomprm" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Telefone</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtfone" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">Categoria</td>
        <td style="width: 240px">
            <asp:TextBox ID="Txtcategoria" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">&nbsp;</td>
        <td style="width: 240px">
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 219px">
            <asp:Button ID="Btnsalvar" runat="server" Text="Salvar" OnClick="Btnsalvar_Click" />
        </td>
        <td style="width: 240px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
