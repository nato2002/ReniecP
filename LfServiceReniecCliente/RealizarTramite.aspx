<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RealizarTramite.aspx.cs" Inherits="LfServiceReniecCliente.RealizarTramite" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous"/>
    <link href="Style/estilos.css" rel="stylesheet" type="text/css"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <header class="cabeza">
            <img src="img/renieclogo.png"/>
            <h1>TRAMITES</h1>
            <div style="text-align:center">
                <asp:Button ID="btnVolver" runat="server" Text="VOLVER AL INICIO" CssClass="btn btn-secondary" OnClick="btnVolver_Click"/>
                <h3>RENIEC TRAMITES</h3>
            </div>
        </header>
        <section class="seccion-tramite">
            <p style="order:1;display: flex; flex-direction: column; align-items: center;">Tipo de Tramite
                <br/>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select">
                    <asp:ListItem Text="DNI" />
                    <asp:ListItem Text="CERTIFICADOS" />
                    <asp:ListItem Text="CONSULTA DE DATOS" />
                    <asp:ListItem Text="REGISTRO MATRIMONIAL" />
                </asp:DropDownList>
                <br/>
                Funciones
                <br/>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-select">
                    <asp:ListItem Text="DNI" />
                    <asp:ListItem Text="CERTIFICADOS" />
                    <asp:ListItem Text="CONSULTA DE DATOS" />
                    <asp:ListItem Text="REGISTRO MATRIMONIAL" />
                </asp:DropDownList>
            </p>
            <p style="order:2;display: flex; flex-direction: column; align-items: center;">DNI
                <br/>
                <asp:TextBox ID="btnDNI" runat="server" CssClass="form-control" placeholder="Coloque su DNI"></asp:TextBox>
            </p>
            <p style="order:3;display: flex; flex-direction: column; align-items: center;">Nombres
                <br/>
                <asp:TextBox ID="btnNombre" runat="server" CssClass="form-control" placeholder="Coloque su Nombre"></asp:TextBox>
                <br/>
               Apellidos
                <br/>
                <asp:TextBox ID="btnApellido" runat="server" CssClass="form-control" placeholder="Coloque su Apellido"></asp:TextBox>
            </p>
            <p style="order:4;display: flex; flex-direction: column; align-items: center;">
                Local Tramite
                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-select">
                    <asp:ListItem Text="Centro de Lima" />
                </asp:DropDownList>
            </p>
            <p style="order:5;display: flex; flex-direction: column; align-items: center;">
                Local Entrega
                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="form-select">
                    <asp:ListItem Text="Centro de Lima" />
                </asp:DropDownList>
            </p>
            <asp:Button ID="btnRealizar" runat="server" Text="REALIZAR TRAMITE" CssClass="btn btn-success" OnClick="btnRealizar_Click"/>
        </section>
        <footer class="pie-pagina">
            <a>Registro Nacional de Identificación y Estado Civil® 2022-RENIEC</a>
            <a href="https://www.reniec.gob.pe/wai/">Personas con Discapacidad</a>
            <a href="https://www.reniec.gob.pe/portal/mapaWeb.htm">Mapa Web</a>
            <a href="https://www.reniec.gob.pe/portal/avisolegal.htm">Aviso Legal</a>
            <a href="https://www.reniec.gob.pe/portal/homeContacto.htm">Contacto</a>
            <a href="https://www.reniec.gob.pe/portal/creditosreniec.htm">Créditos</a>
            <a href="https://www.reniec.gob.pe/portal/sedesreniec.htm">Sedes</a>
        </footer>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
</body>
</html>
