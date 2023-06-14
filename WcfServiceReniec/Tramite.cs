using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfServiceReniec
{
    [DataContract]
    public class Tramite
    {
        int idtramite = int.MinValue;
        int tipotramite = int.MinValue;
        int dni = int.MinValue;
        string nombres = string.Empty;
        string apellidos = string.Empty;
        string localtramite = string.Empty;
        string localentrega = string.Empty;
        string estadotramite = string.Empty;
        public Tramite(int dni)
        {
            this.dni = dni;
        }
        public Tramite(string estadotramite)
        {
            this.estadotramite = estadotramite;
        }
        public Tramite(int tipotramite,int dni,string nombres,string apellidos
                      ,string localtramite,string localentrega)
        {
            this.tipotramite = tipotramite;
            this.dni= dni;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.localtramite = localtramite;
            this.localentrega = localentrega;
        }
        [DataMember]
        public int Idtramite
        {
            get { return this.idtramite; }
            set { idtramite = value; }
        }
        [DataMember]
        public int Tipotramite
        {
            get { return this.tipotramite; }
            set { tipotramite = value; }
        }
        [DataMember]
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
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
        public string Localtramite
        {
            get { return localtramite; }
            set { localtramite = value; }
        }
        [DataMember]
        public string Localentrega
        {
            get { return localentrega; }
            set { localentrega = value; }
        }
        [DataMember]
        public string Estadotramite
        {
            get { return estadotramite; }
            set { estadotramite = value; }
        }
    }
}