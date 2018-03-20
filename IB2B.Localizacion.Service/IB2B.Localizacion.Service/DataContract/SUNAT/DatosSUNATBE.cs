using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IB2B.Localizacion.Service.DataContract.SUNAT
{
    [DataContract]
        public class DatosSUNATBE
        {

            public DatosSUNATBE()
            {
                RUC = String.Empty;
                RazonSocial = String.Empty;
                NombreNatural = String.Empty;
                TipoDocumento = String.Empty;
                TipoContribuyente = String.Empty;
                NombreComercial = String.Empty;
                FechaInscripcion = String.Empty;
                FechaInicioActividades = String.Empty;
                EstadoContribuyente = String.Empty;
                CondicionContribuyente = String.Empty;
                DomicilioFiscal = String.Empty;
                Telefono = String.Empty;
                SistemaEmisionComprobante = String.Empty;
                ActividadComercioExterior = String.Empty;
                SistemaContabilidad = String.Empty;
                ActividadEconomica = String.Empty;
                SistemaEmisionElectronica = String.Empty;
                EmisionElectronicaDesde = String.Empty;
                ComprobanteElectronica = String.Empty;
                AfiliadoPLEDesde = String.Empty;
                Padrones = String.Empty;
                MensajeError = String.Empty;
            }
            public Int32 Id { get; set; }

            [DataMember]
            public String RUC { get; set; }

            [DataMember]
            public String RazonSocial { get; set; }
            [DataMember]
            public String NombreNatural { get; set; }
            [DataMember]
            public String TipoDocumento { get; set; }
            [DataMember]
            public String TipoContribuyente { get; set; }
            [DataMember]
            public String NombreComercial { get; set; }
            public String FechaInscripcion { get; set; }
            public String FechaInicioActividades { get; set; }
            public String EstadoContribuyente { get; set; }
            public String CondicionContribuyente { get; set; }
            public String DomicilioFiscal { get; set; }
            public String Telefono { get; set; }
            public String SistemaEmisionComprobante { get; set; }
            public String ActividadComercioExterior { get; set; }
            public String SistemaContabilidad { get; set; }
            public String ActividadEconomica { get; set; }
            public String SistemaEmisionElectronica { get; set; }
            public String EmisionElectronicaDesde { get; set; }
            public String ComprobanteElectronica { get; set; }
            public String AfiliadoPLEDesde { get; set; }
            public String Padrones { get; set; }
            public String MensajeError { get; set; }
        }
}