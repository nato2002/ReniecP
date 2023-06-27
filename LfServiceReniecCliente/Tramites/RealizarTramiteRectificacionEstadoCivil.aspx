<%@ Page Title="" Language="C#" MasterPageFile="~/Tramites/Plantilla.Master" AutoEventWireup="true" CodeBehind="RealizarTramiteRectificacionEstadoCivil.aspx.cs" Inherits="LfServiceReniecCliente.Tramites.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="seccion-tramite">
            <p style="order:1;display: flex; flex-direction: column; align-items: center;">Numero de DNI
                <br>
                <input type="text" name="" class="form-control" placeholder="Coloque su DNI" id="txtDNI" runat="server"/>
                <br>
                Fecha de Nacimiento
                <br>
                <input type="date" name="" class="form-control" id="dateInput" runat="server"/>
            </p>
            <p style="order:2;display: flex; flex-direction: column; align-items: center;">Coloque su Nombre
                <br>
                <input type="text" name="" class="form-control" placeholder="Coloque su Nombre" id="txtNombre" runat="server"/>
                <br>
                Coloque su Apellido
                <br>
                <input type="text" name="" class="form-control" placeholder="Coloque su Apellido" id="txtApellido" runat="server"/>
            </p>
            <p style="order:4;display: flex; flex-direction: column; align-items: center;">
                Local Tramite
                <asp:DropDownList ID="cbLocalTramite" runat="server" CssClass="form-select">
                    <asp:ListItem Text="Virual" Value="Virtual"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <p style="order:5;display: flex; flex-direction: column; align-items: center;">
                Rectificacion de Estado Civil
                <br>
                <asp:DropDownList ID="cbEstadoCivil" runat="server" CssClass="form-select">
                    <asp:ListItem Text="Soltero(a)" Value="Soltero(a)"></asp:ListItem>
                    <asp:ListItem Text="Casado(a)" Value="Casado(a)"></asp:ListItem>
                    <asp:ListItem Text="Divorciado(a)" Value="Divorciado(a)"></asp:ListItem>
                    <asp:ListItem Text="Viudo(a)" Value="Viudo(a)"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <asp:Button ID="btnRealizar" runat="server" Text="REALIZAR TRAMITE" CssClass="btn btn-success" OnClick="btnRealizar_Click"/>
        </main>
        <div style="text-align:center; color:white; background-color:limegreen;">
            <asp:Label runat="server" ID="labelmensaje" CssClass="Mensaje"></asp:Label>
        </div>
</asp:Content>
