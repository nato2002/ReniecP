using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LfServiceReniecCliente.ServiceReference1;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace LfServiceReniecCliente.Tramites
{
    public partial class Formulario_web16 : System.Web.UI.Page
    {
        ServiceReniecClient cliente = new ServiceReniecClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRealizar_Click(object sender, EventArgs e)
        {
            lbPNombre.Text = cliente.Get(txtDNI.Value, "nombres");
            lbPApellido.Text = cliente.Get(txtDNI.Value, "apellidoPaterno");
            lbSApellido.Text = cliente.Get(txtDNI.Value, "apellidoMaterno");
        }

    }
}