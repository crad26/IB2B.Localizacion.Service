using IB2B.Localizacion.Service.DataContract.Global;
using IB2B.Localizacion.Service.DataContract.SUNAT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IB2B.Localizacion.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ILocalizacion
    {
        [WebInvoke(Method = "POST", UriTemplate = "/RegistrarCliente", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [OperationContract]
        ResultadoBE RegistrarCliente(ClienteBE pClienteBE, string pAplicacionId);


        [WebInvoke(Method = "POST", UriTemplate = "/GetDataSUNAT", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        [OperationContract]
        DatosSUNATBE GetDataSUNAT(string Numero_ruc);
    }


}
