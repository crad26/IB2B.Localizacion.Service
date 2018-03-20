using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IB2B.Localizacion.Service.DataContract.Global
{
    [DataContract]
    public class ClienteBE
    {
        [DataMember]
        public String ClienteID { get; set; }

        [DataMember]
        public String Name { get; set; }
    }
}