<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="Sugestao.aspx.cs" Inherits="Mobilidade.Paginas.Locacao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<p>
        <br />
    </p>
    <p>
    </p>--%>
    <div style="height: 230px">
        <td style="width: 400px">
            <asp:Label ID="lblmsg1" runat="server"></asp:Label>
        </td>
        <br />
        <table style="text-align:left; font-weight: bold; color: brown; font-size: large; width: 100%">
            <tr>
                <td style="width: 187px">Tipo Serviço</td>
                <td style="width: 172px">
                    &nbsp;<asp:DropDownList ID="Dropdtipo" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="Dropdtipo_SelectedIndexChanged" Width="123px">
                    </asp:DropDownList>
                </td>
                <td style="width: 117px">
                    Nome</td>
                <td>
                    <asp:DropDownList ID="Dropdnome" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 187px">&nbsp;</td>
                <td style="width: 172px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td style="width: 117px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 187px">&nbsp;</td>
                <td style="width: 172px">
                    &nbsp;</td>
                <td style="width: 117px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 187px">&nbsp;</td>
                <td style="width: 172px">
                    &nbsp;</td>
                <td style="width: 117px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 187px">Sugestão:</td>
                <td style="width: 172px">
                    <asp:TextBox ID="txtcoment" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                <td style="width: 117px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <%-- <td style="width: 500px">
                    <asp:Label ID="lblmsg" runat="server" ></asp:Label>
                </td>
                <td>&nbsp;</td>--%>
            </tr>
            <tr>
                <td style="width: 187px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                <asp:Button ID="btnsalvar" runat="server" OnClick="btnsalvar_Click1" Text="Salvar" Height="34px" Width="57px" />
                    &nbsp;</td>
                <td style="width: 172px">&nbsp;</td>
                <td style="width: 117px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 187px">&nbsp;</td>
                <td style="width: 172px">
                    <asp:Label ID="lblmsg" runat="server" Text="lblmsg"></asp:Label>
                </td>
                <td style="width: 117px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        
        <br />
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
    <p>
    </p>
</asp:Content>
