﻿using System;
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
        SqlConnection con = new SqlConnection("Server=serveproyectos.database.windows.net; Database=RENIEC; User Id=admin01; Password=Admin123;");

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
            SqlCommand cmd = new SqlCommand("insert into usuario values(@nombres,@apellidos,@email,@contrasenna)", con);
            cmd.Parameters.AddWithValue("@nombres", userInfo.Nombres);
            cmd.Parameters.AddWithValue("@apellidos", userInfo.Apellidos);
            cmd.Parameters.AddWithValue("@email", userInfo.Email);
            cmd.Parameters.AddWithValue("@contrasenna", userInfo.Contrasenna);
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

        public string validaruser(ConsultaLogin loginfo)
        {
            String mensaje = "";

            List<String> userPasword = new List<String>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from usuario where email=@email and contrasenna=@contrasenna", con);
            cmd.Parameters.AddWithValue("@email", loginfo.Email);
            cmd.Parameters.AddWithValue("@contrasenna", loginfo.Contrasenna);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                mensaje = "Usuario Encontrado";
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    string email = tb.Rows[i]["email"].ToString();
                    string contra = tb.Rows[i]["contrasenna"].ToString();
                    userPasword.Add(email);
                    userPasword.Add(contra);
                }
            }
            else
            {
                mensaje = "Usuario no Encontrado";
            }
            con.Close();

            return mensaje;
        }
        public string Tramite(Tramite tramite)
        {
            string Message;
            List<String> Datos = new List<String>();
            con.Open();
            SqlCommand cmd = new SqlCommand("RealizarTramite", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TipoT", tramite.Tipotramite);
            cmd.Parameters.AddWithValue("@DNI", tramite.Dni);
            cmd.Parameters.AddWithValue("@NOMBRES", tramite.Nombres);
            cmd.Parameters.AddWithValue("@APELLIDOS", tramite.Apellidos);
            cmd.Parameters.AddWithValue("@LocalT", tramite.Localtramite);
            cmd.Parameters.AddWithValue("@LocalE", tramite.Localentrega);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = "Tu Tramite Se realizo correctamente";
            }
            else
            {
                Message = "No Pudo Procesar su Tramite, intente nuevamente";
            }
            con.Close();
            return Message;
        }

        public List<String> VerProcesoTramite(Tramite tramite)
        {
            List<String> Datos = new List<String>();
            con.Open();
            SqlCommand cmd = new SqlCommand("VerEstadoTramite", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DNI", tramite.Dni);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                Datos.Add(tb.Rows[i]["ID_Tramite"].ToString());
                Datos.Add(tb.Rows[i]["DNI"].ToString());
                Datos.Add(tb.Rows[i]["TipoTramite"].ToString());
                Datos.Add(tb.Rows[i]["Fecha_Tramite"].ToString());
                Datos.Add(tb.Rows[i]["LocalTramite"].ToString());
                Datos.Add(tb.Rows[i]["LocalEntrega"].ToString());
                Datos.Add(tb.Rows[i]["EstadoTramite"].ToString());
            }
            con.Close();
            return Datos;
        }

        public string ColocarProceso(Tramite tramite)
        {
            string Message;

            con.Open();
            SqlCommand cmd = new SqlCommand("ColocarProceso", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdTramite", tramite.Idtramite);
            cmd.Parameters.AddWithValue("@IdTipoTra", tramite.Tipotramite);
            cmd.Parameters.AddWithValue("@EstadoTramite", tramite.Estadotramite);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = "Se Modifico El estado del Tramite";

            }
            else
            {
                Message = "No Pudo Modificar el estado del tramite";
            }
            con.Close();
            return Message;
        }
        public string Get(string dni)
        {
            ApiConsultaDni api = new ApiConsultaDni();
            string Message = "";
            dynamic r = api.Get("https://dniruc.apisperu.com/api/v1/dni/"+dni+"?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImRpYXpyb2RyaWdvZGNAZ21haWwuY29tIn0.hQoAQUcRj2yp9aWfXYPu8Eg40bxnRJnp3HACNMQBZL8");
            return Message = r.nombres.ToString();
        }
    }
}
