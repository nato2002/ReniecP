using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LfServiceReniecCliente.PSReniec.Consultas
{
    public partial class RegTramitesGenerales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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