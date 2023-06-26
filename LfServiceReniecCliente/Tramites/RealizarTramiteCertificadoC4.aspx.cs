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
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        ServiceReniecClient cliente = new ServiceReniecClient();
        SqlConnection con = new SqlConnection("Server=serveproyectos.database.windows.net; Database=RENIEC; User Id=admin01; Password=Admin123;");
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            string selectQuery = "select nombre from Sedes";
            using (SqlCommand command = new SqlCommand(selectQuery, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string valor = reader.GetString(0);
                        cbLocalEntrega.Items.Add(valor);
                    }
                }

            }

        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {
            Tramite tramite = new Tramite();
            try
            {
                tramite.Tipotramite = 4;
                tramite.Dni = int.Parse(txtDNISolicitante.Value);
                tramite.Nombres = txtNombreSolicitante.Value;
                tramite.Apellidos = txtApellidoSolicitante.Value;
                tramite.Localentrega = cbLocalEntrega.Value;
                tramite.Localtramite = cbLocalTramite.Value;
                tramite.Cambio = "Solictud de Certificado C4";
                string mensaje = cliente.Tramite(tramite);
                labelmensaje.Text = mensaje + ", Dirijase a la sede seleccionada para validar su huella y posteriormente la entrega de su documento.";
                txtDNISolicitante.Value = "";
                txtNombreSolicitante.Value = "";
                txtApellidoSolicitante.Value = "";
                cbLocalEntrega.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                labelmensaje.Text = "No se pudo Realizar el tramite";
            }
        }
    }
}