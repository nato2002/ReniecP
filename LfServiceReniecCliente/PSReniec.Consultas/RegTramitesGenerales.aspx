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
            width: 565px;
        }
        .auto-style8 {
            width: 100%;
        }
        .auto-style9 {
            width: 565px;
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
        .auto-style14 {
            width: 173px;
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
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Font-Names="Bahnschrift SemiBold" Font-Size="X-Large" Text="Bandeja de registros de solicitud de trámites"></asp:Label>
                </td>
                <td class="auto-style15">
                    &nbsp;</td>
                <td class="auto-style14">
                    <asp:Image ID="btnlistar" runat="server" Height="61px" ImageUrl="~/img/boton.png" Width="315px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Panel ID="Panel2" runat="server" Width="296px">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Font-Names="Arial" Text="Filtrar por estado:" Font-Size="Large"></asp:Label>
                    </asp:Panel>
                </td>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    </td>
                <td class="auto-style16"></td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Text="Código de solicitud" Font-Names="Arial Narrow" Font-Size="Large"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label6" runat="server" Font-Names="Arial Narrow" Font-Size="Large" Text="Estado de solicitud"></asp:Label>
                </td>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9">
<<<<<<< HEAD
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="189px" Height="25px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Large" Height="32px" Width="213px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style16">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="🔍︎ Consultar" Width="188px" BackColor="#990000" Font-Names="Arial Black" Font-Size="Medium" ForeColor="White" Height="28px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
=======
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtid" runat="server" Width="189px" Height="25px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="cboestado" runat="server" Font-Size="Large" Height="32px" Width="213px">
                        <asp:ListItem>--ELEGIR ESTADO--</asp:ListItem>
                        <asp:ListItem>ACEPTADO</asp:ListItem>
                        <asp:ListItem>RECHAZADO</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style16">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnconsultar" runat="server" Text="🔍︎ Consultar" Width="188px" BackColor="#990000" Font-Names="Arial Black" Font-Size="Medium" ForeColor="White" Height="28px" OnClick="btnconsultar_Click" />
                </td>
>>>>>>> parent of 38feec5 (Revert "df")
                <td class="auto-style11">
                    <asp:Button ID="Button2" runat="server" Text="X Limpiar" Width="188px" Height="28px" BackColor="#003399" Font-Names="Arial Black" Font-Size="Large" ForeColor="White"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    &nbsp;</td>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" Height="122px" Width="1329px">
            <Columns>
                <asp:TemplateField HeaderText="COD. SOLICITUD">
                    <ControlStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="COD. CIUDADANO">
                    <ControlStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FECHA">
                    <ControlStyle Font-Bold="True" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ESTADO">
                    <ControlStyle Font-Bold="True" />
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
        <asp:Panel ID="Panel3" runat="server" Height="25px" Width="1265px">
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server" Height="36px" Width="1263px">
        </asp:Panel>

        <asp:Panel ID="Panel7" runat="server" BackColor="#535456" BorderStyle="Ridge" Height="235px" Width="1344px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image5" runat="server" CssClass="dynamic selected" BorderStyle="None" Height="98px" ImageUrl="~/img/logo.png" Width="295px" />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Font-Size="X-Small" ForeColor="White" Text="Registro Nacional de Identificación y Estado Civil® 2022-RENIEC"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="X-Small" ForeColor="White"  >Personas con Discapacidad</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </asp:Panel>
    </form>
</body>
</html>
