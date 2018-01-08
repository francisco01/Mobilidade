<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AvaliaRelatorio.aspx.cs" Inherits="Mobilidade.Paginas.AvaliaRelatorio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    </div>
    <table style="width: 100%; height: 102px;">
        <tr>
            <td style="height: 23px; width: 193px; color: #FF0000;">Selecione o tipo de serviço:</td>
            <td style="height: 23px; width: 167px;">
                <asp:DropDownList ID="DropDowntipo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDowntipo_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td style="height: 23px">&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 193px; color: #FF0000; font-family: Verdana, Geneva, Tahoma, sans-serif;">&nbsp;</td>
            <td style="width: 167px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 23px" colspan="3">
                <asp:GridView ID="GridViewavalia" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
    <p>

        &nbsp;</p>
</asp:Content>
