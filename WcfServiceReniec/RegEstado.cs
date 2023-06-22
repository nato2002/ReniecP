using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceReniec
{
    [DataContract]
    public class RegEstado
    {
        int id_EstadoSolicitud;
        int estadoSolicitud;

        [DataMember]
        public int ID_EstadoSolicitud
        {
            get => id_EstadoSolicitud;
            set => id_EstadoSolicitud = value;
        }

        [DataMember]
        public int EstadoSolicitud
        {
            get => estadoSolicitud;
            set => estadoSolicitud = value;
        }
    }
}