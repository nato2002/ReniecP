using LfServiceReniecCliente.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LfServiceReniecCliente
{
    public partial class RegistrarUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

        }

        protected void btnregistrar_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceReniecClient objServiceClientobjServic = new ServiceReference1.ServiceReniecClient();
            ConsultaLogin userConsult = new ConsultaLogin();
            userConsult.Nombres = txtnombres.Text;
            userConsult.Apellidos = txtapellidos.Text;
            userConsult.Email = txtcorreo.Text;
            userConsult.Contrasenna = txtcontra.Text;
            string resultado = objServiceClientobjServic.RegistrartUsuario(userConsult);
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discapacidad.aspx");
        }
    }
}