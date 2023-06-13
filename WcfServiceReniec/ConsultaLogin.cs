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
        string id= string.Empty;
        string nombres= string.Empty;
        string apellidos = string.Empty;
        string email= string.Empty;
        string contrasenna= string.Empty;

        public ConsultaLogin(string email, string contrasenna)
        {
            this.email = email;
            this.contrasenna = contrasenna;
        }

        public ConsultaLogin( string nombres, string apellidos, string email, string contrasenna)
        {

            this.nombres = nombres;
            this.apellidos = apellidos;
            this.email = email;
            this.contrasenna = contrasenna;
        }

        [DataMember]
        public string Id
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
        public string Contrasenna
        {
            get { return contrasenna; }
            set { contrasenna = value; }
        }


    }
}