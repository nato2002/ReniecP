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
    public partial class Formulario_web1 : System.Web.UI.Page
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
                tramite.Tipotramite = 1;
                tramite.Dni = int.Parse(txtDNI.Value);
                tramite.Nombres = txtNombre.Value;
                tramite.Apellidos = txtApellido.Value;
                tramite.Localentrega = cbLocalEntrega.Value;
                tramite.Localtramite = cbLocalTramite.Value;
                tramite.Cambio = "Solictud de duplicado de DNI";
                string mensaje = cliente.Tramite(tramite);
                labelmensaje.Text = mensaje + ", Dirijase a la sede seleccionada para validar su huella y posteriormente la entrega de su documento.";
                txtDNI.Value = "";
                txtNombre.Value = "";
                txtApellido.Value = "";
                cbLocalEntrega.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                labelmensaje.Text = "No se pudo Realizar el tramite";
            }
        }
    }
}