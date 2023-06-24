using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfServiceReniec
{
    [DataContract]
    public class ConsultaLogin
    {
        int id = 0;
        string nombres= string.Empty;
        string apellidos = string.Empty;
        string email= string.Empty;
        int telefono = 0;
        string usuario= string.Empty;
        string contrasenna= string.Empty;
        string cargo= string.Empty;

        public ConsultaLogin()
        {
        }

        public ConsultaLogin(string usuario, string contrasenna)
        {
            this.usuario = usuario;
            this.contrasenna = contrasenna;
        }

        public ConsultaLogin(string nombres, string apellidos, string email, int telefono, string usuario, string contrasenna, string cargo)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.telefono = telefono;
            this.usuario = usuario;
            this.contrasenna = contrasenna;
            this.cargo = cargo;
        }

        [DataMember]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        [DataMember]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        [DataMember]
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        [DataMember]
        public string Contrasenna
        {
            get { return contrasenna; }
            set { contrasenna = value; }
        }
        [DataMember]
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }


    }
}