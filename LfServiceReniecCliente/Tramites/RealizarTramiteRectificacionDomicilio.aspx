<%@ Page Title="" Language="C#" MasterPageFile="~/Tramites/Plantilla.Master" AutoEventWireup="true" CodeBehind="RealizarTramiteRectificacionDomicilio.aspx.cs" Inherits="LfServiceReniecCliente.Tramites.Formulario_web11" %>
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
            <p style="order:3;display: flex; flex-direction: column; align-items: center;">
                Local Tramite
                <asp:DropDownList ID="cbLocalTramite" runat="server" CssClass="form-select">
                    <asp:ListItem Text="Virual" Value="Virtual"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <p style="order:4;display: flex; flex-direction: column; align-items: center;">
                Rectificacion de Domicilio
                <br>
                <input type="text" name="" class="form-control" placeholder="Domicilio" id="txtDomicilio" runat="server"/>
            </p>
            <asp:Button ID="btnRealizar" runat="server" Text="REALIZAR TRAMITE" CssClass="btn btn-success" OnClick="btnRealizar_Click"/>
        </main>
        <div style="text-align:center; color:white; background-color:limegreen;">
            <asp:Label runat="server" ID="labelmensaje" CssClass="Mensaje"></asp:Label>
        </div>
</asp:Content>
