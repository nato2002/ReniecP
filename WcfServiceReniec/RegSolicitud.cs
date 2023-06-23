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
            string estado;

            [DataMember]
            public int SolicitudId
            {
                get { return s_Solid; }
                set { s_Solid = value; }
            }
            [DataMember]
            public int Ciudadanoid
            {
                get { return s_Ciudadanoid; }
                set { s_Ciudadanoid = value; }
            }
            [DataMember]
            public DateTime S_fecha
            {
                get { return s_fecha; }
                set { s_fecha = value; }
            }

            [DataMember]
            public string Estado
            {
               get { return estado; }
               set { estado = value; }
            }
    }
}
