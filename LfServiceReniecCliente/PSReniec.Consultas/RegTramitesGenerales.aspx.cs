using LfServiceReniecCliente.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

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
            }
        }

        private void BindRegRecordsInGrid()
        {
            DataSet ds = new DataSet();
            ds = obj.GetRegSolDetails();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtid.Text = string.Empty;
            cboestado.ClearSelection();
            BindRegRecordsInGrid();
        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {

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

                }
                else if (cboestado.Text == "--Elegir Estado--")
                {
                    int solicitudId = int.Parse(txtid.Text);
                    RegSolicitud regdetsol = new RegSolicitud();
                    regdetsol.SolicitudId = solicitudId;

                    DataSet resultado = obj.BuscarSolicitudID(regdetsol);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro de solicitud no fue encontrado: " + ex.Message, "Busqueda y Listado Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}