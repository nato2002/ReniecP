<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EleccionTramite.aspx.cs" Inherits="LfServiceReniecCliente.EleccionTramite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style/estilos.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 174px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header class="auto-style1">
            
            <img src="img/renieclogo.png"/>           
            <br />
            <br />
            <br />
            <br />
<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" ForeColor="White" Text="Servicios de Trámite" CssClass="titulo"></asp:Label>
        </header>
        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Duplicado de DNI/DNIe" CssClass="labelNombre"></asp:Label>                           
            </div>

            <asp:Image ID="Image1" runat="server" Height="100px" ImageUrl="https://png.pngtree.com/png-vector/20220218/ourmid/pngtree-document-identification-png-image_4392943.png" Width="118px" />

            <div class="button">
                <asp:Button runat="server" Text="Realizar Trámite" CssClass="span" />
            </div>



        </div>

        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Rectificacion de Domicilio" CssClass="labelNombre"></asp:Label>
            </div>
            <br />
            <div class="button">
                <asp:Button runat="server" Text="Realizar Trámite" CssClass="span" />
            </div>

        </div>

        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Rectificacion del Estado Civil" CssClass="labelNombre"></asp:Label>
            </div>
            <br />
            <div class="button">
                <asp:Button runat="server" Text="Realizar Trámite" CssClass="span" />
            </div>

        </div>

        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Certificado de Inscripcion (C4)" CssClass="labelNombre"></asp:Label>
            </div>
            <br />
            <div class="button">
                <asp:Button runat="server" Text="Realizar Trámite" CssClass="span" />
            </div>

        </div>

        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Copias certificadas de Actas/Partidas" CssClass="labelNombre"></asp:Label>
            </div>
            <br />
            <div class="button">
                <asp:Button runat="server" Text="Realizar Trámite" CssClass="span" />
            </div>

        </div>

        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Validacion de copiasd certificadas" CssClass="labelNombre"></asp:Label>
            </div>
            <br />
            <div class="button">
                <asp:Button runat="server" Text="Realizar Trámite" CssClass="span" />
            </div>

        </div>

        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Acceso a la informacion pública" CssClass="labelNombre"></asp:Label>
            </div>
            <br />
            <div class="button">
                <asp:Button runat="server" Text="Realizar Trámite" CssClass="span" />
            </div>

        </div>

        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Asignar/Cambiar domicilio electrónico" CssClass="labelNombre"></asp:Label>
            </div>
            <br />
            <div class="button">
                <asp:Button runat="server" Text="Realizar Trámite" CssClass="span" />
            </div>

        </div>
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
            <asp:Label ID="Label2" runat="server" Font-Size="Small" ForeColor="White" Text="Registro Nacional de Identificación y Estado Civil® 2022-RENIEC"></asp:Label>
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
