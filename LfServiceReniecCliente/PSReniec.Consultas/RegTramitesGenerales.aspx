<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegTramitesGenerales.aspx.cs" Inherits="LfServiceReniecCliente.PSReniec.Consultas.RegTramitesGenerales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 72px;
        }
        .auto-style5 {
            width: 900px;
        }
        .auto-style8 {
            width: 100%;
        }
        .auto-style9 {
            width: 900px;
            height: 23px;
        }
        .auto-style11 {
            height: 23px;
            width: 173px;
        }
        .auto-style12 {
            width: 287px;
        }
        .auto-style13 {
            width: 93%;
        }
        .auto-style15 {
            width: 428px;
        }
        .auto-style16 {
            width: 428px;
            height: 23px;
        }
        .auto-style17 {
            width: 1349px;
        }
        .auto-style19 {
            width: 243px;
            height: 23px;
        }
        .auto-style20 {
            width: 243px;
        }
        .auto-style21 {
            width: 1851px;
        }
        .auto-style22 {
            width: 1851px;
            height: 23px;
        }
        .auto-style23 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style17">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#054478" ForeColor="#001646" Height="133px" Width="1349px">
                <table class="auto-style13">
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style12">&nbsp;</td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style12">
                            <asp:Image ID="Image1" runat="server" CssClass="auto-style3" Height="74px" ImageUrl="~/img/logo.png" Width="273px" />
                        </td>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Verificación de Trámites" Font-Names="Arial Rounded MT Bold" Font-Size="XX-Large" ForeColor="White"></asp:Label>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <table class="auto-style8">
            <tr>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style21">
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Names="Bahnschrift SemiBold" Font-Size="X-Large" Text="Bandeja de registros de solicitud de trámites"></asp:Label>
                </td>
                <td class="auto-style5">
                      &nbsp;</td>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style20">
                    <asp:Image ID="btnlistar" runat="server" Height="61px" ImageUrl="~/img/boton.png" Width="315px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style21">
                    <asp:Panel ID="Panel2" runat="server" Width="296px">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Font-Names="Arial" Text="Filtrar por estado:" Font-Size="Large"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style16"></td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Código de solicitud" Font-Names="Arial Narrow" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="Label6" runat="server" Font-Names="Arial Narrow" Font-Size="Large" Text="Estado de solicitud"></asp:Label>
                </td>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtid" runat="server" Width="189px" Height="25px"></asp:TextBox>
                    </td>
                <td class="auto-style9">
                    <asp:DropDownList ID="cboestado" runat="server" Height="16px" Width="198px" AutoPostBack="True">
                        <asp:ListItem>--Elegir Estado--</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style19">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnconsultar" runat="server" Text="🔍︎ Consultar" Width="188px" BackColor="#990000" Font-Names="Arial Black" Font-Size="Medium" ForeColor="White" Height="28px" OnClick="btnconsultar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>

                <td class="auto-style11">
                    <asp:Button ID="btnlimpiar" runat="server" Text="X Limpiar" Width="188px" Height="28px" BackColor="#003399" Font-Names="Arial Black" Font-Size="Large" ForeColor="White" OnClick="Button2_Click"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style22">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
            </tr>
        </table>
        <asp:Panel ID="Panel3" runat="server" Height="219px" Width="1265px">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Height="214px" Width="1139px">
                <Columns>
                    <asp:BoundField DataField="ID_Solicitud" HeaderText="ID SOLICITUD" />
                    <asp:BoundField DataField="ID_Tramite" HeaderText="ID TRAMITE" />
                    <asp:BoundField DataField="FecSolicitud" HeaderText="FECHA SOLICITUD" DataFormatString="{0:dd/MM/yyyy}" />
                    <asp:BoundField DataField="DNIsolicitante" HeaderText="DNI" />
                    <asp:BoundField DataField="NombreSolicitante" HeaderText="NOMBRE SOLICITANTE" />
                    <asp:BoundField DataField="EstadoSolicitud" HeaderText="ESTADO" />
                    <asp:TemplateField HeaderText="VERIFICAR ESTADO">
                        <ItemTemplate>
                            <asp:CheckBox ID="CheckBox1" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
