<%@ Page Title="" Language="C#" MasterPageFile="~/Tramites/Plantilla.Master" AutoEventWireup="true" CodeBehind="RealizarAsignacionCorreo.aspx.cs" Inherits="LfServiceReniecCliente.Tramites.Formulario_web17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="seccion-tramite">
        <p style="order:1;display: flex; flex-direction: column; align-items: center;">Numero de DNI
            <br>
            <input type="text" id="txtDNI" class="form-control" placeholder="Coloque DNI " runat="server"/>
            <br />
            <input type="date" id="dateInput" class="form-control" runat="server"/>
        </p>
        <p style="order:2;display: flex; flex-direction: column; align-items: center;">Nombres Completos
            <br>
            <input type="text" name="" class="form-control" placeholder="Coloque el Nombre Completo" id="txtNombre" runat="server"/>
            <br>
            Apellidos Completos
            <br>
            <input type="text" name="" class="form-control" placeholder="Coloque el Apellido Completo" id="txtApellido" runat="server"/>
        </p>
        <p style="order:3;display: flex; flex-direction: column; align-items: center;">Coloque su Correo
            <br>
            <input type="text" id="txtCorreo" class="form-control" placeholder="Coloque su Correo" runat="server"/>
        </p>
        <asp:Button ID="btnRealizar" runat="server" Text="REALIZAR TRAMITE" CssClass="btn btn-success" OnClick ="btnRealizar_Click"/>
        </main>
        <div style="text-align:center; color:white; background-color:limegreen;">
            <asp:Label runat="server" ID="labelmensaje" CssClass="Mensaje"></asp:Label>
        </div>
</asp:Content>
