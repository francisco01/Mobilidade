<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Del_Alt_estacao.aspx.cs" Inherits="Mobilidade.Paginas.Del_Alt_estacao" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td style="width: 151px">&nbsp;</td>
        <td style="width: 197px">
            &nbsp;</td>
        <td style="width: 195px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 151px">Selecione o Serviço</td>
        <td style="width: 197px">
            <asp:DropDownList ID="DropDownServ" runat="server" Height="16px" OnSelectedIndexChanged="DropDownServ_SelectedIndexChanged" style="margin-left: 0px" Width="165px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td style="width: 195px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="height: 23px; width: 151px"></td>
        <td style="height: 23px; width: 197px"></td>
        <td style="height: 23px; width: 195px"></td>
        <td style="height: 23px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 151px">Nome</td>
        <td style="width: 197px">
            <asp:TextBox ID="Txtnom" runat="server" Enabled="False"></asp:TextBox>
        </td>
        <td style="width: 195px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 151px">&nbsp;</td>
        <td style="width: 197px">
            <asp:Label ID="lblmsg" runat="server"></asp:Label>
        </td>
        <td style="width: 195px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 151px; height: 30px">
            <asp:Button ID="Btnalterar" runat="server" OnClick="Btnalterar_Click" Text="Alterar" />
        </td>
        <td style="width: 197px; height: 30px">
            <asp:Button ID="Btnexcluir" runat="server" OnClick="Btnexcluir_Click" Text="Excluir" />
        </td>
        <td style="width: 195px; height: 30px">
            <asp:Button ID="Btnsalvar" runat="server" OnClick="Btnsalvar_Click" Text="Salvar" />
        </td>
        <td style="height: 30px"></td>
    </tr>
    <tr>
        <td style="width: 151px">&nbsp;</td>
        <td style="width: 197px">
            <asp:GridView ID="GridViewdados" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridViewdados_SelectedIndexChanged" Width="327px">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowSelectButton="True" />
                </Columns>
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
        <td style="width: 195px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 151px">&nbsp;</td>
        <td style="width: 197px">&nbsp;</td>
        <td style="width: 195px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
