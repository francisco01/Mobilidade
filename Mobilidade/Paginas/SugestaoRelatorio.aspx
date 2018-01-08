<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="SugestaoRelatorio.aspx.cs" Inherits="Mobilidade.Paginas.SugestaoRelatorio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td style="width: 248px; height: 26px; color: #FF0000;">Selecione o tipo de serviço:</td>
        <td style="height: 26px; width: 221px">
            <asp:DropDownList ID="DropDowntipo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDowntipo_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td style="height: 26px"></td>
    </tr>
    <tr>
        <td style="width: 248px">&nbsp;</td>
        <td style="width: 221px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="GridViewsugestao" runat="server" CellPadding="4" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
