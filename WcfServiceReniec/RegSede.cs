using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceReniec
{
    [DataContract]
    public class RegSede
    {
        int s_RegId;
        string s_Nombre = string.Empty;
        string s_Direccion = string.Empty;


        [DataMember]
        public int RegId
        {
            get { return s_RegId; }
            set { s_RegId = value; }
        }
        [DataMember]
        public string Nombre
        {
            get { return s_Nombre; }
            set { s_Nombre = value; }
        }
        [DataMember]
        public string Direccion
        {
            get { return s_Direccion; }
            set { s_Direccion = value; }
        }
        
    }
}