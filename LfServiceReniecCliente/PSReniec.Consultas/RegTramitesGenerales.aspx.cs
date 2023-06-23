using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
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

            // Agregar el elemento "--ELEGIR ESTADO--" al DropDownList
            cboestado.Items.Add("--ELEGIR ESTADO--");

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

                    GridView1.DataSource = resultado.Tables[0];
                    GridView1.DataBind();
                }
                else if (cboestado.Text == "--ELEGIR ESTADO--")
                {
                    int solicitudId = int.Parse(txtid.Text);
                    RegSolicitud regdetsol = new RegSolicitud();
                    regdetsol.SolicitudId = solicitudId;

                    DataSet resultado = obj.BuscarSolicitudID(regdetsol);

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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ActualizarEstado")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                int solicitudId = Convert.ToInt32(GridView1.DataKeys[rowIndex].Value);

                obj.ActualizarEstadoSolicitud(solicitudId);

                BindRegRecordsInGrid();
            }
        }
    }
}