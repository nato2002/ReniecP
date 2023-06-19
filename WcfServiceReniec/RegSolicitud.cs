using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceReniec
{
<<<<<<< HEAD
        [DataContract]
        public class RegSolicitud
        {
            int s_Solid;
            int s_Ciudadanoid;
            DateTime s_fecha;
            string estado;
=======
    [DataContract]
    public class RegSolicitud
    {
        int s_Solid;
        int s_Ciudadanoid;
        DateTime s_fecha;
        string estado;
>>>>>>> parent of 38feec5 (Revert "df")

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

<<<<<<< HEAD
            [DataMember]
            public string Estado
            {
                get => estado;
                set => estado = value;
            }
=======
        [DataMember]
        public string Estado
        { 
            get => estado; 
            set => estado = value; 
        }
>>>>>>> parent of 38feec5 (Revert "df")
    }
}