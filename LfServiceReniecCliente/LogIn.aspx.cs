using LfServiceReniecCliente.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LfServiceReniecCliente
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            ServiceReference1.ServiceReniecClient objServiceClientobjServic = new ServiceReference1.ServiceReniecClient();
            ConsultaLogin userConsult = new ConsultaLogin();
            userConsult.Email = txtcorreo.Text;
            userConsult.Contrasenna = txtcontra.Text;
            string resultado = objServiceClientobjServic.validaruser(userConsult);
            Response.Redirect("Inicio.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarUser.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discapacidad.aspx");
        }
    }
}