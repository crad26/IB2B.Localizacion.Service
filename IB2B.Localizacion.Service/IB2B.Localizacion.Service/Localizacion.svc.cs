using IB2B.Localizacion.Service.DataContract.Financial;
using IB2B.Localizacion.Service.DataContract.Global;
using IB2B.Localizacion.Service.DataContract.SUNAT;
using IB2B.Localizacion.Service.Utilitario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace IB2B.Localizacion.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : ILocalizacion
    {
        public ResultadoBE RegistrarCliente(ClienteBE pClienteBE, string pAplicacionId)
        {
            ResultadoBE obResultadoBE = new ResultadoBE();
            try
            {
                if (pAplicacionId == Util.Aplicacion.Financial)
                {
                    new ClienteFinancial().conect(pClienteBE, pAplicacionId);
                    obResultadoBE.Resultado = Util.ResultadoSistema.Ok;
                }
                else
                {
                }
                return obResultadoBE;
            }
            catch (Exception ex)
            {
                obResultadoBE.Resultado = Util.ResultadoSistema.Error;
                obResultadoBE.Mensaje = ex.Message;
            }
            return obResultadoBE;
        }

        public DatosSUNATBE GetDataSUNAT(string Numero_ruc)
        {
            DatosSUNATBE obDatosSUNATBE = new DatosSUNATBE();
            try
            {
                //new ClienteFinancial().conect(pClienteBE, pAplicacionId);
                obDatosSUNATBE = new ConectionSunat().GetInfo(Numero_ruc);

                //obDatosSUNATBE.Resultado = Util.ResultadoSistema.Ok;

            }
            catch (Exception ex)
            {
                // obDatosSUNATBE.Resultado = Util.ResultadoSistema.Error;
                // obDatosSUNATBE.Mensaje = ex.Message;
            }
            return obDatosSUNATBE;

        }
    }
}
