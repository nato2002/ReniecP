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
        string dni = string.Empty;
        [DataMember]
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
    }
}