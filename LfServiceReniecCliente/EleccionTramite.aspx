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
            <img src="img/renieclogo.png"/>
            <h1 class="titulo">Eliga un Trámite</h1>
            <h2 class="subtitulo">Consulta el Estado de Tramite</h2>
            <h3 class="subtitulo">DNI/DNIe Y Ficha Registral</h3>
        </header>
        <div class="seccion-PanelDatos">
            <div style="font-family:Arial;font-size:1.7em;">
                <asp:Label runat="server" Text="Rodrigo Diaz" CssClass="labelNombre"></asp:Label>
            </div>
            <div>
                <asp:Button runat="server" CssClass="btnCerrar" Text="Cerrar"/>
            </div>
        </div>
    </form>
</body>
</html>
