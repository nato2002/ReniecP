using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceReniec
{
    [DataContract]
    public class RegSolicitud
    {
        int s_Solid;
        int s_Ciudadanoid;
        DateTime s_fecha;
        int estado;

        [DataMember]
        public int SolicitudId 
        { 
            get => s_Solid; 
            set => s_Solid = value; 
        }
        [DataMember]
        public int Ciudadanoid 
        { 
            get => s_Ciudadanoid; 
            set => s_Ciudadanoid = value; 
        }
        [DataMember]
        public DateTime S_fecha 
        { 
            get => s_fecha; 
            set => s_fecha = value; 
        }

        [DataMember]
        public int Estado
        { 
            get => estado; 
            set => estado = value; 
        }
    }
}