using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Windows.Forms;
using WcfServiceReniec;
using CheckBox = System.Web.UI.WebControls.CheckBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            SetCheckBoxStatus();
        }

        protected void btnconsultar_Click(object sender, EventArgs e)
        {
            buscar();
            SetCheckBoxStatus();
            BindRegRecordsInGrid();
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

            SetCheckBoxStatus();

        }

        protected void Button2_Click(System.Object sender, System.EventArgs e)
        {
            txtid.Text = string.Empty;
            cboestado.ClearSelection();
            BindRegRecordsInGrid();
            SetCheckBoxStatus();
        }

        protected void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            GridViewRow row = (GridViewRow)checkbox.NamingContainer;
            int solicitudId = Convert.ToInt32(row.Cells[0].Text);

            if (checkbox.Checked)
            {
                obj.ActualizarEstadoSolicitud(solicitudId);
            }

            BindRegRecordsInGrid();
            //SetCheckBoxStatus();
        }

        private void SetCheckBoxStatus()
        {
            foreach (GridViewRow row in GridView1.Rows)
            {
                string estadoSolicitud = Convert.ToString(row.Cells[5].Text);
                CheckBox checkbox = (CheckBox)row.FindControl("CheckBox1");

                if (estadoSolicitud == "Completada")
                {
                    checkbox.Checked = true;
                }
                else
                {
                    checkbox.Checked = false;
                }
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                CheckBox checkBox = e.Row.FindControl("CheckBox1") as CheckBox;
                if (checkBox != null)
                {
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                    checkBox.AutoPostBack = true;
                }
            }
        }
    }
}