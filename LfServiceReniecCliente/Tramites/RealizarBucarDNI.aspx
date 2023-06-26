<%@ Page Title="" Language="C#" MasterPageFile="~/Tramites/Plantilla.Master" AutoEventWireup="true" CodeBehind="RealizarBucarDNI.aspx.cs" Inherits="LfServiceReniecCliente.Tramites.Formulario_web16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center;"><label style="font-weight:bold; font-size:2em;color:white;">Acta de Nacimiento</label></div>
    <main class="seccion-tramite">
        <p style="order:1;display: flex;color:white; flex-direction: column; align-items: center;">Numero de DNI
            <br>
            <input type="text" id="txtDNI" class="form-control" placeholder="Coloque DNI " runat="server"/>
        </p>
        <p style="order:2;display: flex;color:white;font-weight:bold; flex-direction: column; align-items: center;">Nombres
            <br>
            <asp:Label ID="lbPNombre" runat="server" Text=".........."></asp:Label>
            <br>
            Primer Apellido
            <br>
            <asp:Label ID="lbPApellido" runat="server" Text=".........."></asp:Label>
            <br />
            Segundo Apellido
            <br />
            <asp:Label ID="lbSApellido" runat="server" Text=".........."></asp:Label>
            <asp:Button ID="btnRealizar" runat="server" Text="REALIZAR TRAMITE" CssClass="btn btn-success" OnClick ="btnRealizar_Click"/>
        </p>
    </main>
</asp:Content>
