using Microsoft.OData.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IB2B.Localizacion.Service.DataContract.Financial
{
    public class ConexionD365
    {
        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";
        public static Resources conect()
        {

            //Resources context = new Resources();

        
            Uri oDataUri = new Uri(ODataEntityPath, UriKind.Absolute);
            var context = new Resources(oDataUri);

            context.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>(delegate (object sender, SendingRequest2EventArgs e)
            {
                var authenticationHeader = OAuthHelper.GetAuthenticationHeader();
                e.RequestMessage.SetHeader(OAuthHelper.OAuthHeader, authenticationHeader);
            });
            
            return context;
        }
    }
}