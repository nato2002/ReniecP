using LfServiceReniecCliente.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LfServiceReniecCliente
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int intentos = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        #region Login
        void ingresar()
        {
            ServiceReference1.ServiceReniecClient obj = new ServiceReference1.ServiceReniecClient();
            ConsultaLogin obje = new ConsultaLogin();
            DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            obje.Usuario = txtcorreo.Text;
            obje.Contrasenna = txtcontra.Text;
            ds = obj.validaruser(obje);
            if (ds.Tables[0].Rows.Count > 0)
            {
                obje.Usuario = ds.Tables[0].Rows[0][6].ToString();
                obje.Contrasenna = ds.Tables[0].Rows[0][7].ToString();

                obje.Nombres = ds.Tables[0].Rows[0][1].ToString();
                obje.Apellidos = ds.Tables[0].Rows[0][2].ToString();
                obje.Cargo = ds.Tables[0].Rows[0][7].ToString();
                MessageBox.Show("Bienvenido(a) " + obje.Nombres + " " + obje.Apellidos + ": " + obje.Cargo);
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                MessageBox.Show("Error, usuario o contraseña incorrectos");
            }
        }
    

        #endregion

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            ingresar();
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