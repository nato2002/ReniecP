using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using LfServiceReniecCliente.ServiceReference1;
using System.Windows.Forms;
using System.Web.Services.Description;
using WcfServiceReniec;
using RegSolicitud = LfServiceReniecCliente.ServiceReference1.RegSolicitud;

namespace LfServiceReniecCliente.PSReniec.Consultas
{
    public partial class RegTramitesGenerales : System.Web.UI.Page
    {
        ServiceReference1.ServiceReniecClient obj = new ServiceReference1.ServiceReniecClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindRegRecordsInGrid();
                LlenarDDL();
            }
        }

        private void BindRegRecordsInGrid()
        {
            DataSet ds = new DataSet();
            ds = obj.GetRegSolDetails();
            GridView1.DataSource = ds.Tables["Solicitud"]; ;
            GridView1.DataBind();
        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            buscar();
        }


        private void LlenarDDL()
        {
            string[] estadosSolicitud = obj.EstadoSolicitud();

            cboestado.Items.Clear();

            foreach (string estado in estadosSolicitud)
            {
                cboestado.Items.Add(estado);
            }
        }


        private void buscar()
        {
            try
            {
                if (txtid.Text == "")
                {
                    string estado = cboestado.Text;

                    RegSolicitud regdetsol = new RegSolicitud();
                    regdetsol.Estado = estado;

                    DataSet resultado = obj.BuscarEstadoSolicitud(regdetsol);

                    GridView1.DataSource = resultado.Tables["Solicitud"];
                    GridView1.DataBind();
                }
                else if (cboestado.Text == "--Elegir Estado--")
                {
                    int solicitudId = int.Parse(txtid.Text);
                    RegSolicitud regdetsol = new RegSolicitud();
                    regdetsol.SolicitudId = solicitudId;

                    DataSet resultado = obj.BuscarSolicitudID(regdetsol);

                    // Mostrar los resultados en el GridView
                    GridView1.DataSource = resultado.Tables["Solicitud"];
                    GridView1.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro de solicitud no fue encontrado: " + ex.Message, "Busqueda y Listado Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        protected void Button2_Click(System.Object sender, System.EventArgs e)
        {
            txtid.Text = string.Empty;
            cboestado.ClearSelection();
            BindRegRecordsInGrid();
        }
    }
}