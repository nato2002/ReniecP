using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.UI.WebControls;

namespace WcfServiceReniec
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceReniec" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceReniec.svc o ServiceReniec.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceReniec : IServiceReniec
    {
        SqlConnection con = new SqlConnection("Data Source=serveproyectos.database.windows.net; Initial Catalog=RENIEC;User ID=admin01;Password=Admin123");

        public bool DeleteUserRegDetails(RegSede regdet)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delete from Sedes where id=@RegId", con);

            cmd.Parameters.AddWithValue("@RegId", regdet.RegId);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataSet FetchUpdatedRecords(RegSede regdet)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from Sedes where id=@RegId", con);

            cmd.Parameters.AddWithValue("@RegId", regdet.RegId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public DataSet GetUserRegDetails()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Sedes", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public string InsertUserRegDetails(RegSede regdet)
        {
            string Status;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insert into Sedes(nombre,direccion) values(@nombre,@direccion)", con);
            cmd.Parameters.AddWithValue("@nombre", regdet.Nombre);
            cmd.Parameters.AddWithValue("@direccion", regdet.Direccion);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = regdet.Nombre  + " se Registro con exito";
            }
            else
            {
                Status = regdet.Nombre  + " No se pudo Registrar";
            }
            con.Close();
            return Status;
        }

        public string UpdateUserRegDetails(RegSede regdet)
        {
            string Status;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("update Sedes set nombre=@nombre,direccion=@direccion where id=@RegId", con);
            cmd.Parameters.AddWithValue("@RegId", regdet.RegId);
            cmd.Parameters.AddWithValue("@nombre", regdet.Nombre);
            cmd.Parameters.AddWithValue("@direccion", regdet.Direccion);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Status = "Sede actualizada con éxito";
            }
            else
            {
                Status = "Sede no Actualizada";
            }
            con.Close();
            return Status;
        }

        public string RegistrartUsuario(ConsultaLogin userInfo)
        {
            string Message;
            
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombres", userInfo.Nombres);
            cmd.Parameters.AddWithValue("@Apellidos", userInfo.Apellidos);
            cmd.Parameters.AddWithValue("@Email", userInfo.Email);
            cmd.Parameters.AddWithValue("@Telefono", userInfo.Telefono);
            cmd.Parameters.AddWithValue("@Usuario", userInfo.Usuario);
            cmd.Parameters.AddWithValue("@Clave", userInfo.Contrasenna);
            cmd.Parameters.AddWithValue("@Cargo", userInfo.Cargo);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.Nombres + ", Bienvenido!!!";
                
            }
            else
            {
                Message = userInfo.Nombres + " Algo salio mal, Vuelva a Intentarlo ";
            }
            con.Close();
            return Message;
        }

        public DataSet validaruser(ConsultaLogin loginfo)
        {
            con.Open();
            //SqlCommand cmd = new SqlCommand("select * from usuario where nomuser=@usuario and clave=@clave", con);
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("@usuario", loginfo.Usuario);
            //cmd.Parameters.AddWithValue("@clave", loginfo.Contrasenna);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //return dt;

            SqlCommand cmd = new SqlCommand("select * from usuario where nomuser=@usuario and clave=@clave", con);
            cmd.Parameters.AddWithValue("@usuario", loginfo.Usuario);
            cmd.Parameters.AddWithValue("@clave", loginfo.Contrasenna);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public DataSet BuscarNombreSede(RegSede regdet)
        {
            DataSet DST = new DataSet();           
            SqlDataAdapter DA = new SqlDataAdapter("BUSCAR_SEDE_NOMBRE", con);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            DA.SelectCommand.Parameters.Add("@BUSCAR",SqlDbType.VarChar).Value = regdet.Nombre;
            DA.Fill(DST,"Sedes");
            return DST;
        }

        public DataSet BuscarDireccionSede(RegSede regdet)
        {
            DataSet DST = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter("BUSCAR_SEDE_DIRECCION", con);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            DA.SelectCommand.Parameters.Add("@BUSCAR", SqlDbType.VarChar).Value = regdet.Direccion;
            DA.Fill(DST, "Sedes");
            return DST;
        }

        //Registro Tramites

        public DataSet BuscarSolicitudID(RegSolicitud regdetsol)
        {
            DataSet DST = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter("buscarIDSol", con);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            DA.SelectCommand.Parameters.Add("@BUSCAR", SqlDbType.Int).Value = regdetsol.SolicitudId;
            DA.Fill(DST, "Solicitud");
            return DST;
        }

        public DataSet BuscarEstadoSolicitud(RegSolicitud regdetsol)
        {
            DataSet DST = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter("listarEstado", con);
            DA.SelectCommand.CommandType = CommandType.StoredProcedure;
            DA.SelectCommand.Parameters.Add("@BUSCAR", SqlDbType.Int).Value = regdetsol.Estado;
            DA.Fill(DST, "Solicitud");
            return DST;
        }

        public DataSet GetRegSolDetails()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select * from Solicitud", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Solicitud");
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }

        public string[] CargarEstadoSolicitud()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT EstadoSolicitud FROM EstadoSolicitud", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> estadosList = new List<string>();

            while (reader.Read())
            {
                string estadoSolicitud = reader["EstadoSolicitud"].ToString();
                estadosList.Add(estadoSolicitud);
            }

            reader.Close();
            con.Close();

            return estadosList.ToArray();
        }


        public List<RegEstado> EstadoSolicitud()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            List<RegEstado> estados = new List<RegEstado>();

            SqlCommand cmd = new SqlCommand("SELECT ID_EstadoSolicitud, EstadoSolicitud FROM EstadoSolicitud", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                RegEstado estado = new RegEstado
                {
                    ID_EstadoSolicitud = (int)reader["ID_EstadoSolicitud"],
                    EstadoSolicitud = (int)reader["EstadoSolicitud"]
                };
                estados.Add(estado);
            }

            reader.Close();
            con.Close();

            return estados;
        }
    }
}
