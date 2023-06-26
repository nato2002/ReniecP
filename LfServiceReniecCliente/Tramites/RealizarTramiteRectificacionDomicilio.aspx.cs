using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LfServiceReniecCliente.ServiceReference1;

namespace LfServiceReniecCliente.Tramites
{
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        ServiceReniecClient cliente = new ServiceReniecClient();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {
            Tramite tramite = new Tramite();
            try
            {
                tramite.Tipotramite = 2;
                tramite.Dni = int.Parse(txtDNI.Value);
                tramite.Nombres = txtNombre.Value;
                tramite.Apellidos = txtApellido.Value;
                tramite.Localentrega = "Virtual";
                tramite.Localtramite = cbLocalTramite.Value;
                tramite.Cambio = "Solicitud de rectificacion de Domicilio";
                string mensaje = cliente.Tramite(tramite);
                labelmensaje.Text = mensaje + "Se cambio su Domicilio correctamente";
                txtDNI.Value = "";
                txtNombre.Value = "";
                txtApellido.Value = "";

            }
            catch (Exception ex)
            {
                labelmensaje.Text = "No se pudo Realizar el tramite";
            }
        }
    }
}