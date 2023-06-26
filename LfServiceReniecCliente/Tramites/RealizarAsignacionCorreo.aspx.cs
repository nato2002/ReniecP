using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LfServiceReniecCliente.ServiceReference1;
namespace LfServiceReniecCliente.Tramites
{
    public partial class Formulario_web17 : System.Web.UI.Page
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
                tramite.Tipotramite = 8;
                tramite.Dni = int.Parse(txtDNI.Value);
                tramite.Nombres = txtNombre.Value;
                tramite.Apellidos = txtApellido.Value;
                tramite.Localentrega = "Virtual";
                tramite.Localtramite = "Virtual";
                tramite.Cambio = "Solictud Cambio de Correo";
                string mensaje = cliente.Tramite(tramite);
                labelmensaje.Text = mensaje;
                txtDNI.Value = "";
                txtNombre.Value = "";
                txtApellido.Value = "";
                txtCorreo.Value = "";
            }
            catch (Exception ex)
            {
                labelmensaje.Text = "No se pudo Realizar el tramite";
            }
        }
    }
}