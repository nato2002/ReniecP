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
            GridView1.DataSource = ds.Tables[0]; ;
            GridView1.DataBind();
        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void LlenarDDL()
        {
            RegEstado[] estadosArray = obj.EstadoSolicitud();

            List<RegEstado> estados = new List<RegEstado>(estadosArray);

            cboestado.Items.Clear();

            foreach (var estado in estados)
            {
                cboestado.Items.Add(new ListItem(estado.EstadoSolicitud, estado.ID_EstadoSolicitud.ToString()));
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

                    // Mostrar los resultados en el GridView
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