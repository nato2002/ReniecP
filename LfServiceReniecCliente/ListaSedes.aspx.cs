//using LfServiceReniecCliente.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LfServiceReniecCliente
{
    public partial class ListaSedes : System.Web.UI.Page
    {
        //ServiceReference1.ServiceReniecClient obj = new ServiceReference1.ServiceReniecClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindRegRecordsInGrid();
            }
        }
        private void BindRegRecordsInGrid()
        {
            //DataSet ds = new DataSet();
            //ds = obj.GetUserRegDetails();
            //grdWcfTest.DataSource = ds;
            //grdWcfTest.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "--Todas--")
            {
                txtnombre.Text = "";
                
                BindRegRecordsInGrid();
            }
            else
            {
                buscar();
                grdWcfTest.DataBind();

            }
        }

        protected void txtnombre_TextChanged(object sender, EventArgs e)
        {
                            
        }

        private void buscar()
        {
            //try
            //{
            //    if (DropDownList1.Text == "Nombre")
            //    {

            //        RegSede regSede = new RegSede();
            //        regSede.Nombre = txtnombre.Text;
            //        grdWcfTest.DataSource = obj.BuscarNombreSede(regSede).Tables[0];
            //        grdWcfTest.DataBind();

            //    }
            //    else if (DropDownList1.Text == "Direccion")
            //    {
            //        RegSede regSede = new RegSede();
            //        regSede.Direccion = txtnombre.Text;
            //        grdWcfTest.DataSource = obj.BuscarDireccionSede(regSede).Tables[0];
            //        grdWcfTest.DataBind();

            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("El producto no fue encontrado por: " + ex.Message, "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

            protected void btnCancel_Click(object sender, EventArgs e)
        {
                txtnombre.Text = string.Empty;
            DropDownList1.ClearSelection();
                BindRegRecordsInGrid();
           
        }
    }
}