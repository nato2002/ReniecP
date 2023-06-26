<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarSedes.aspx.cs" Inherits="LfServiceReniecCliente.RegistrarSedes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style/estilos.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 525px;
        }
        .auto-style5 {
            height: 28px;
            width: 525px;
        }
        .auto-style6 {
            height: 23px;
            width: 525px;
        }
        .auto-style7 {
            width: 1484px;
        }
        .auto-style10 {
            width: 525px;
            height: 30px;
        }
        .auto-style13 {
            height: 171px;
            width: 1525px;
        }
        .auto-style17 {
            width: 2574px;
            height: 30px;
        }
        .auto-style18 {
            height: 28px;
            width: 2574px;
        }
        .auto-style21 {
            height: 23px;
            width: 2574px;
        }
        .auto-style27 {
            width: 2574px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header class="auto-style13">
            
            <img src="img/renieclogo.png"/>           
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="White" Text="Registro de Sedes" CssClass="titulo"></asp:Label>
        </header>
            </div>
        <div>
            <asp:Panel ID="Panel1" runat="server" Width="1499px">
                <fieldset style="width:900px">
    <legend>AGREGAR SEDES </legend>
        <table class="auto-style7" >
            <tr>
                <td class="auto-style17">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style10">
                    &nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style18">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="False" Font-Italic="False" Font-Size="XX-Large" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="txtnombre" runat="server" Font-Size="Medium" Height="29px" style="margin-right: 59px" Width="304px"></asp:TextBox>
                    &nbsp;<asp:Label ID="Label6" runat="server" Font-Bold="False" Font-Italic="False" Font-Size="XX-Large" Text="Direccion"></asp:Label>
                    <asp:TextBox ID="txtdireccion" runat="server" Font-Size="Medium" Height="29px" Width="304px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <br />
                    <br />
                    <br />
                    <div>
                    <asp:Button ID="btnSubmit" runat="server" CssClass="buttonagg" Font-Size="Large" ForeColor="White" Height="48px" Text="     Agregar" Width="117px" OnClick="btnSubmit_Click1" />
                    </div>&nbsp;<div><asp:Button ID="btnCancel" runat="server" CssClass="buttoncancelar" Font-Size="Large" ForeColor="White" Height="48px" Text="    Cancelar" Width="116px" OnClick="btnCancel_Click1" />
                </div></td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Label ID="lblStatus" runat="server" Font-Bold="True" ForeColor="#FF6600" style="color: #FF3300"></asp:Label>
                </td>
                <td class="auto-style4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="auto-style21">
                    </td>
                <td class="auto-style6">
                    </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="grdWcfTest" runat="server" AutoGenerateColumns="False"
                        DataKeyNames="id" CellPadding="3"  Width="1463px" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" Font-Size="Large" GridLines="Horizontal" >
                        <AlternatingRowStyle BackColor="#F7F7F7" />
                    <Columns>

                                            <asp:TemplateField HeaderText="NOMBRE" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("nombre") %>'></asp:Label>
                                                </ItemTemplate>

                                                <FooterStyle Font-Size="Large" />

<HeaderStyle HorizontalAlign="Center" Width="200px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="DIRECCION" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblPwd" runat="server" Text='<%#Eval("direccion") %>'></asp:Label>
                                                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center" Width="300px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Edit" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgBtn" runat="server" CausesValidation="false" CommandArgument='<%#Eval("id") %>'
                                                         ImageUrl="~/img/lapiz.png"
                                                        ToolTip="Edit" OnCommand="imgBtn_Command"  />
                                                </ItemTemplate>                                              

<HeaderStyle HorizontalAlign="Center" Width="50px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                                            </asp:TemplateField>

                                            <asp:TemplateField HeaderText="Delete" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                                             
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imgDel" runat="server" CausesValidation="false" CommandArgument='<%#Eval("id") %>'
                                                        CommandName="Delete"  ImageUrl="~/img/borrar.png"
                                                        ToolTip="Delete" OnClientClick="return confirm('Esta seguro de Eliminar la Sede?')"  OnCommand="imgDel_Command1"  />
                                                </ItemTemplate>

<HeaderStyle HorizontalAlign="Center" Width="50px"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
                                            </asp:TemplateField>
                                        </Columns>
                        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <PagerStyle ForeColor="#4A3C8C" HorizontalAlign="Right" BackColor="#E7E7FF" />
                        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                        <SortedAscendingCellStyle BackColor="#F4F4FD" />
                        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                        <SortedDescendingCellStyle BackColor="#D8D8F0" />
                        <SortedDescendingHeaderStyle BackColor="#3E3277" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </fieldset>
        </div>
            </asp:Panel>
        
        
        <div class="panel">        
        <asp:Panel ID="Panel7" runat="server" CssClass="span" BackColor="#535456"   Height="220px" Width="1582px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image5" runat="server"  BorderStyle="None" Height="108px" img src="img/renieclogo.png"   Width="247px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Size="Small" ForeColor="White" Text="Registro Nacional de Identificación y Estado Civil® 2022-RENIEC"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="Medium" ForeColor="White" >Personas con Discapacidad</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:LinkButton ID="LinkButton3" runat="server" Font-Size="Medium" ForeColor="White">Sedes</asp:LinkButton>
&nbsp;
            <br />
        </asp:Panel>
            </div>
    </form>
</body>
</html>
