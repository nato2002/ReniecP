<%@ Page Title="" Language="C#" MasterPageFile="~/Tramites/Plantilla.Master" AutoEventWireup="true" CodeBehind="RealizarTramiteCertificadoC4.aspx.cs" Inherits="LfServiceReniecCliente.Tramites.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main class="seccion-tramite">
            <p style="order:1;display: flex; flex-direction: column; align-items: center;">Numero de DNI del Solicitado
                <br>
                <input type="text" id="txtDNISolicitante" class="form-control" placeholder="Coloque DNI del Solicitante" runat="server"/>
            </p>
            <p style="order:2;display: flex; flex-direction: column; align-items: center;">Nombres Completos del Solicitante
                <br>
                <input type="text" name="" class="form-control" placeholder="Coloque el Nombre Completo" id="txtNombreSolicitante" runat="server"/>
                <br>
                Apellidos Completo del Solicitante
                <br>
                <input type="text" name="" class="form-control" placeholder="Coloque el Apellido Completo" id="txtApellidoSolicitante" runat="server"/>
            </p>
            <p style="order:4;display: flex; flex-direction: column; align-items: center;">
                Local Tramite
                <select name="name" class="form-select" id="cbLocalTramite" runat="server">
                    <option value="">Virtual</option>
                </select>
            </p>
            <p style="order:5;display: flex; flex-direction: column; align-items: center;">
                Local Entrega
                <select name="name" class="form-select" id="cbLocalEntrega" runat="server">
                </select>
            </p>
            <asp:Button ID="btnRealizar" runat="server" Text="REALIZAR TRAMITE" CssClass="btn btn-success" OnClick ="btnRealizar_Click"/>
        </main>
        <div style="text-align:center; color:white; background-color:limegreen;">
            <asp:Label runat="server" ID="labelmensaje" CssClass="Mensaje"></asp:Label>
        </div>
</asp:Content>
