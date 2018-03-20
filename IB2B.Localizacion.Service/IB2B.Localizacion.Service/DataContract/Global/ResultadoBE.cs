using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IB2B.Localizacion.Service.DataContract.Global
{
    [DataContract]
    public class ResultadoBE
    {
        [DataMember]
        public string Resultado { get; set; }
        [DataMember]
        public string Mensaje { get; set; }
    }
}