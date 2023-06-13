using LfServiceReniecCliente.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LfServiceReniecCliente
{
    public partial class RegistrarSedes : System.Web.UI.Page
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
            ds = obj.GetUserRegDetails();
            grdWcfTest.DataSource = ds;
            grdWcfTest.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnSubmit.Text == "Modificar")
            {
                UpdateRegDetails();
            }
            else
            {
                SaveRegDetails();
            }
        }
        private void UpdateRegDetails()
        {
            RegSede regDet = new RegSede();
            regDet.RegId = Convert.ToInt32(ViewState["id"].ToString());
            regDet.Nombre = txtnombre.Text.Trim();
            regDet.Direccion = txtdireccion.Text.Trim();

            obj.UpdateUserRegDetails(regDet);
            lblStatus.Text = obj.UpdateUserRegDetails(regDet);
            ClearControls();
            BindRegRecordsInGrid();
        }
        private void ClearControls()
        {
            txtnombre.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            btnSubmit.Text = "Agregar";
            txtnombre.Focus();
        }
        private void SaveRegDetails()
        {
            RegSede regDet = new RegSede();
            regDet.Nombre = txtnombre.Text.Trim();
            regDet.Direccion = txtdireccion.Text.Trim();

            lblStatus.Text = obj.InsertUserRegDetails(regDet);
            ClearControls();
            BindRegRecordsInGrid();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
            lblStatus.Text = string.Empty;
        }

        protected void imgDel_Command1(object sender, CommandEventArgs e)
        {
            RegSede regDet = new RegSede();
            regDet.RegId = int.Parse(e.CommandArgument.ToString());
            if (obj.DeleteUserRegDetails(regDet) == true)
            {
                lblStatus.Text = "Sede Eliminada con Exito";
            }
            else
            {
                lblStatus.Text = "No se Elimino la Sede";
            }
            BindRegRecordsInGrid();
        }

        protected void imgBtn_Command(object sender, CommandEventArgs e)
        {
            RegSede regDet = new RegSede();
            regDet.RegId = int.Parse(e.CommandArgument.ToString());
            ViewState["id"] = regDet.RegId;
            DataSet ds = new DataSet();
            ds = obj.FetchUpdatedRecords(regDet);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                btnSubmit.Text = "Modificar";
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Discapacidad.aspx");
        }
    }
    }