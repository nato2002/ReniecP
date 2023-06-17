using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceReniec
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceReniec" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceReniec.svc o ServiceReniec.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceReniec : IServiceReniec
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-E593S88\\SQLEXPRESS; Initial Catalog=RENIEC; Integrated Security=True");

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
    }
}
