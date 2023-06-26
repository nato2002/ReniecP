<%@ Page Title="" Language="C#" MasterPageFile="~/Tramites/Plantilla.Master" AutoEventWireup="true" CodeBehind="RealizarValidacionActas.aspx.cs" Inherits="LfServiceReniecCliente.Tramites.Formulario_web15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;"><label style="font-weight:bold; font-size:2em;color:white;">Acta de Nacimiento</label></div>
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
        <p style="order:4;display: flex; flex-direction: column; align-items: center;">
            <br />
            Local Tramite
            <select name="name" class="form-select" id="cbLocalTramite" runat="server">
                <option value="">Centro de Lima</option>
            </select>
            <br />
            Local Entrega
            <select name="name" class="form-select" id="cbLocalEntrega" runat="server">
                <option value="">Centro de Lima</option>
            </select>
        </p>
        <input style="order: 5;" type="button" class="btn btn-success" value="REALIZAR TRAMITE" id="btnRealizar" runat="server">
    </main>
</asp:Content>
