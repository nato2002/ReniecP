<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EleccionTramite.aspx.cs" Inherits="LfServiceReniecCliente.EleccionTramite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Style/estilos.css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h1 class="titulo">Servicios de Trámite</h1>
            <img src="img/renieclogo.png"/>           
        </header>
        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Duplicado de DNI/DNIe" CssClass="labelNombre"></asp:Label>               
            &nbsp;</div>


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

    </form>
</body>
</html>
