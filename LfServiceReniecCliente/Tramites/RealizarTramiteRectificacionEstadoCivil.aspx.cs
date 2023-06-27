using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LfServiceReniecCliente.ServiceReference1;
using System.Data.SqlClient;
using System.Data;
namespace LfServiceReniecCliente.Tramites
{
    public partial class Formulario_web12 : System.Web.UI.Page
    {
        ServiceReniecClient cliente = new ServiceReniecClient();
        SqlConnection con = new SqlConnection("Server=serveproyectos.database.windows.net; Database=RENIEC; User Id=admin01; Password=Admin123;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {
            Tramite tramite = new Tramite();
            try
            {
                tramite.Tipotramite = 3;
                tramite.Dni = int.Parse(txtDNI.Value);
                tramite.Nombres = txtNombre.Value;
                tramite.Apellidos = txtApellido.Value;
                tramite.Localentrega = "Virtual";
                tramite.Localtramite = cbLocalTramite.Text;
                tramite.Cambio = "Solicitud de rectificacion Estado Civil " + cbEstadoCivil.Text;
                string mensaje = cliente.Tramite(tramite);
                labelmensaje.Text = mensaje+", Se evaluara su cambio de Estado Civil.";
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