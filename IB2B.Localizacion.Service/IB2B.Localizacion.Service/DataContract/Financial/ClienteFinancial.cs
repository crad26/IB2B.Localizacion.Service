using IB2B.Localizacion.Service.DataContract.Global;
using Microsoft.OData.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IB2B.Localizacion.Service.DataContract.Financial
{
    public class ClienteFinancial
    {

        public static string ODataEntityPath = ClientConfiguration.Default.UriString + "data";



        public ClienteBE conect(ClienteBE pCustomer, string pAplicacionId)
        {
            ClienteBE vResul = new ClienteBE();
            Uri oDataUri = new Uri(ODataEntityPath, UriKind.Absolute);
            var context = new Resources(oDataUri);

            context.SendingRequest2 += new EventHandler<SendingRequest2EventArgs>(delegate (object sender, SendingRequest2EventArgs e)
            {
                var authenticationHeader = OAuthHelper.GetAuthenticationHeader();
                e.RequestMessage.SetHeader(OAuthHelper.OAuthHeader, authenticationHeader);
            });
            CreateCustomer(context, pCustomer);
            return vResul;
        }


        public static void CreateCustomer(Resources context, ClienteBE pCustomer)
        {
            try
            {
                Customer vendorEntity = new Customer();

                DataServiceCollection<Customer> vendorEntityCollection = new DataServiceCollection<Customer>(context);
                vendorEntityCollection.Add(vendorEntity);
                vendorEntity.CustomerAccount = pCustomer.ClienteID;
                vendorEntity.Name = pCustomer.Name;
                vendorEntity.CustomerGroupId = "Sales";
                vendorEntity.SalesCurrencyCode = "USD";
               // DataServiceCollection<Customer> vend = new DataServiceCollection<Customer>(context.Customers.Where(p => p.CustomerAccount == "C0000000049"));
                context.SaveChanges(SaveChangesOptions.PostOnlySetProperties | SaveChangesOptions.BatchWithSingleChangeset);

            }
            catch (Exception msj)
            {
                string mensaje = msj.InnerException.Message;
            }
        }
    }
}