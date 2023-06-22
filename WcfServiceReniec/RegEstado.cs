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

        [DataMember]
        public int ID_EstadoSolicitud
        {
            get => id_EstadoSolicitud;
            set => id_EstadoSolicitud = value;
        }

        [DataMember]
        public string EstadoSolicitud
        {
            get => EstadoSolicitud;
            set => EstadoSolicitud = value;
        }
    }
}