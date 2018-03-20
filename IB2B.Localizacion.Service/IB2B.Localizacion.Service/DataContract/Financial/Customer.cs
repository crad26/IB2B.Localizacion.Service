using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IB2B.Localizacion.Service.DataContract.Financial
{
    [DataContract]

    [global::Microsoft.OData.Client.Key("dataAreaId", "CustomerAccount")]
    [global::Microsoft.OData.Client.EntitySet("Customers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Customer")]

    // public partial class Customer : global::System.ComponentModel.INotifyPropertyChanged
    public partial class Customer : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="addressLatitude">Initial value of AddressLatitude.</param>
        /// <param name="personAnniversaryDay">Initial value of PersonAnniversaryDay.</param>
        /// <param name="warehouseFulfillmentRate">Initial value of WarehouseFulfillmentRate.</param>
        /// <param name="addressValidTo">Initial value of AddressValidTo.</param>
        /// <param name="dataAreaId">Initial value of DataAreaId.</param>
        /// <param name="customerAccount">Initial value of CustomerAccount.</param>
        /// <param name="creditLimit">Initial value of CreditLimit.</param>
        /// <param name="organizationNumberOfEmployees">Initial value of OrganizationNumberOfEmployees.</param>
        /// <param name="dAXIntegrationId">Initial value of DAXIntegrationId.</param>
        /// <param name="personAnniversaryYear">Initial value of PersonAnniversaryYear.</param>
        /// <param name="addressValidFrom">Initial value of AddressValidFrom.</param>
        /// <param name="addressLongitude">Initial value of AddressLongitude.</param>
        /// <param name="paymentTermsBaseDays">Initial value of PaymentTermsBaseDays.</param>
        /// <param name="consolidationDay">Initial value of ConsolidationDay.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public static Customer CreateCustomer(decimal addressLatitude,
                    int personAnniversaryDay,
                    decimal warehouseFulfillmentRate,
                    global::System.DateTimeOffset addressValidTo,
                    string dataAreaId,
                    string customerAccount,
                    decimal creditLimit,
                    int organizationNumberOfEmployees,
                    global::System.Guid dAXIntegrationId,
                    int personAnniversaryYear,
                    global::System.DateTimeOffset addressValidFrom,
                    decimal addressLongitude,
                    int paymentTermsBaseDays,
                    int consolidationDay)
        {
            Customer customer = new Customer();
            customer.AddressLatitude = addressLatitude;
            customer.PersonAnniversaryDay = personAnniversaryDay;
            customer.WarehouseFulfillmentRate = warehouseFulfillmentRate;
            customer.AddressValidTo = addressValidTo;
            customer.DataAreaId = dataAreaId;
            customer.CustomerAccount = customerAccount;
            customer.CreditLimit = creditLimit;
            customer.OrganizationNumberOfEmployees = organizationNumberOfEmployees;
            customer.DAXIntegrationId = dAXIntegrationId;
            customer.PersonAnniversaryYear = personAnniversaryYear;
            customer.AddressValidFrom = addressValidFrom;
            customer.AddressLongitude = addressLongitude;
            customer.PaymentTermsBaseDays = paymentTermsBaseDays;
            customer.ConsolidationDay = consolidationDay;
            return customer;
        }
        /// <summary>
        /// There are no comments for Property WarehouseId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseId")]
        public string WarehouseId
        {
            get
            {
                return this._WarehouseId;
            }
            set
            {
                this.OnWarehouseIdChanging(value);
                this._WarehouseId = value;
                this.OnWarehouseIdChanged();
                this.OnPropertyChanged("WarehouseId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _WarehouseId;
        partial void OnWarehouseIdChanging(string value);
        partial void OnWarehouseIdChanged();
        /// <summary>
        /// There are no comments for Property CustomerRebateGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerRebateGroupId")]
        public string CustomerRebateGroupId
        {
            get
            {
                return this._CustomerRebateGroupId;
            }
            set
            {
                this.OnCustomerRebateGroupIdChanging(value);
                this._CustomerRebateGroupId = value;
                this.OnCustomerRebateGroupIdChanged();
                this.OnPropertyChanged("CustomerRebateGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CustomerRebateGroupId;
        partial void OnCustomerRebateGroupIdChanging(string value);
        partial void OnCustomerRebateGroupIdChanged();
        /// <summary>
        /// There are no comments for Property DeliveryFreightZone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryFreightZone")]
        public string DeliveryFreightZone
        {
            get
            {
                return this._DeliveryFreightZone;
            }
            set
            {
                this.OnDeliveryFreightZoneChanging(value);
                this._DeliveryFreightZone = value;
                this.OnDeliveryFreightZoneChanged();
                this.OnPropertyChanged("DeliveryFreightZone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DeliveryFreightZone;
        partial void OnDeliveryFreightZoneChanging(string value);
        partial void OnDeliveryFreightZoneChanged();
        /// <summary>
        /// There are no comments for Property AddressDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressDescription")]
        public string AddressDescription
        {
            get
            {
                return this._AddressDescription;
            }
            set
            {
                this.OnAddressDescriptionChanging(value);
                this._AddressDescription = value;
                this.OnAddressDescriptionChanged();
                this.OnPropertyChanged("AddressDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressDescription;
        partial void OnAddressDescriptionChanging(string value);
        partial void OnAddressDescriptionChanged();
        /// <summary>
        /// There are no comments for Property NumberSequenceGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("NumberSequenceGroup")]
        public string NumberSequenceGroup
        {
            get
            {
                return this._NumberSequenceGroup;
            }
            set
            {
                this.OnNumberSequenceGroupChanging(value);
                this._NumberSequenceGroup = value;
                this.OnNumberSequenceGroupChanged();
                this.OnPropertyChanged("NumberSequenceGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _NumberSequenceGroup;
        partial void OnNumberSequenceGroupChanging(string value);
        partial void OnNumberSequenceGroupChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceAccount")]
        public string InvoiceAccount
        {
            get
            {
                return this._InvoiceAccount;
            }
            set
            {
                this.OnInvoiceAccountChanging(value);
                this._InvoiceAccount = value;
                this.OnInvoiceAccountChanged();
                this.OnPropertyChanged("InvoiceAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _InvoiceAccount;
        partial void OnInvoiceAccountChanging(string value);
        partial void OnInvoiceAccountChanged();
        /// <summary>
        /// There are no comments for Property LineDiscountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LineDiscountCode")]
        public string LineDiscountCode
        {
            get
            {
                return this._LineDiscountCode;
            }
            set
            {
                this.OnLineDiscountCodeChanging(value);
                this._LineDiscountCode = value;
                this.OnLineDiscountCodeChanged();
                this.OnPropertyChanged("LineDiscountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _LineDiscountCode;
        partial void OnLineDiscountCodeChanging(string value);
        partial void OnLineDiscountCodeChanged();
        /// <summary>
        /// There are no comments for Property AddressState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressState")]
        public string AddressState
        {
            get
            {
                return this._AddressState;
            }
            set
            {
                this.OnAddressStateChanging(value);
                this._AddressState = value;
                this.OnAddressStateChanged();
                this.OnPropertyChanged("AddressState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressState;
        partial void OnAddressStateChanging(string value);
        partial void OnAddressStateChanged();
        /// <summary>
        /// There are no comments for Property AddressBooks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressBooks")]
        public string AddressBooks
        {
            get
            {
                return this._AddressBooks;
            }
            set
            {
                this.OnAddressBooksChanging(value);
                this._AddressBooks = value;
                this.OnAddressBooksChanged();
                this.OnPropertyChanged("AddressBooks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressBooks;
        partial void OnAddressBooksChanging(string value);
        partial void OnAddressBooksChanged();
        /// <summary>
        /// There are no comments for Property AddressCity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressCity")]
        public string AddressCity
        {
            get
            {
                return this._AddressCity;
            }
            set
            {
                this.OnAddressCityChanging(value);
                this._AddressCity = value;
                this.OnAddressCityChanged();
                this.OnPropertyChanged("AddressCity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressCity;
        partial void OnAddressCityChanging(string value);
        partial void OnAddressCityChanged();
        /// <summary>
        /// There are no comments for Property PartyState in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyState")]
        public string PartyState
        {
            get
            {
                return this._PartyState;
            }
            set
            {
                this.OnPartyStateChanging(value);
                this._PartyState = value;
                this.OnPartyStateChanged();
                this.OnPropertyChanged("PartyState");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PartyState;
        partial void OnPartyStateChanging(string value);
        partial void OnPartyStateChanged();
        /// <summary>
        /// There are no comments for Property SiteId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SiteId")]
        public string SiteId
        {
            get
            {
                return this._SiteId;
            }
            set
            {
                this.OnSiteIdChanging(value);
                this._SiteId = value;
                this.OnSiteIdChanged();
                this.OnPropertyChanged("SiteId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SiteId;
        partial void OnSiteIdChanging(string value);
        partial void OnSiteIdChanged();
        /// <summary>
        /// There are no comments for Property IsExcludedFromCollectionFeeCalculation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IsExcludedFromCollectionFeeCalculation")]

        partial void OnIsExcludedFromCollectionFeeCalculationChanged();
        /// <summary>
        /// There are no comments for Property PaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentMethod")]
        public string PaymentMethod
        {
            get
            {
                return this._PaymentMethod;
            }
            set
            {
                this.OnPaymentMethodChanging(value);
                this._PaymentMethod = value;
                this.OnPaymentMethodChanged();
                this.OnPropertyChanged("PaymentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentMethod;
        partial void OnPaymentMethodChanging(string value);
        partial void OnPaymentMethodChanged();
        /// <summary>
        /// There are no comments for Property AddressLatitude in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressLatitude")]
        public decimal AddressLatitude
        {
            get
            {
                return this._AddressLatitude;
            }
            set
            {
                this.OnAddressLatitudeChanging(value);
                this._AddressLatitude = value;
                this.OnAddressLatitudeChanged();
                this.OnPropertyChanged("AddressLatitude");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private decimal _AddressLatitude;
        partial void OnAddressLatitudeChanging(decimal value);
        partial void OnAddressLatitudeChanged();
        /// <summary>
        /// There are no comments for Property AddressZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressZipCode")]
        public string AddressZipCode
        {
            get
            {
                return this._AddressZipCode;
            }
            set
            {
                this.OnAddressZipCodeChanging(value);
                this._AddressZipCode = value;
                this.OnAddressZipCodeChanged();
                this.OnPropertyChanged("AddressZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressZipCode;
        partial void OnAddressZipCodeChanging(string value);
        partial void OnAddressZipCodeChanged();
        /// <summary>
        /// There are no comments for Property PANReferenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PANReferenceNumber")]
        public string PANReferenceNumber
        {
            get
            {
                return this._PANReferenceNumber;
            }
            set
            {
                this.OnPANReferenceNumberChanging(value);
                this._PANReferenceNumber = value;
                this.OnPANReferenceNumberChanged();
                this.OnPropertyChanged("PANReferenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PANReferenceNumber;
        partial void OnPANReferenceNumberChanging(string value);
        partial void OnPANReferenceNumberChanged();
        /// <summary>
        /// There are no comments for Property IRS1099CIndicator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IRS1099CIndicator")]
        partial void OnIRS1099CIndicatorChanged();
        /// <summary>
        /// There are no comments for Property PersonAnniversaryDay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonAnniversaryDay")]
        public int PersonAnniversaryDay
        {
            get
            {
                return this._PersonAnniversaryDay;
            }
            set
            {
                this.OnPersonAnniversaryDayChanging(value);
                this._PersonAnniversaryDay = value;
                this.OnPersonAnniversaryDayChanged();
                this.OnPropertyChanged("PersonAnniversaryDay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _PersonAnniversaryDay;
        partial void OnPersonAnniversaryDayChanging(int value);
        partial void OnPersonAnniversaryDayChanged();
        /// <summary>
        /// There are no comments for Property WithholdingTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WithholdingTaxGroup")]
        public string WithholdingTaxGroup
        {
            get
            {
                return this._WithholdingTaxGroup;
            }
            set
            {
                this.OnWithholdingTaxGroupChanging(value);
                this._WithholdingTaxGroup = value;
                this.OnWithholdingTaxGroupChanged();
                this.OnPropertyChanged("WithholdingTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _WithholdingTaxGroup;
        partial void OnWithholdingTaxGroupChanging(string value);
        partial void OnWithholdingTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property CreditCardAddressVerification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditCardAddressVerification")]
        partial void OnCreditCardAddressVerificationChanged();
        /// <summary>
        /// There are no comments for Property PersonProfessionalTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonProfessionalTitle")]
        public string PersonProfessionalTitle
        {
            get
            {
                return this._PersonProfessionalTitle;
            }
            set
            {
                this.OnPersonProfessionalTitleChanging(value);
                this._PersonProfessionalTitle = value;
                this.OnPersonProfessionalTitleChanged();
                this.OnPropertyChanged("PersonProfessionalTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PersonProfessionalTitle;
        partial void OnPersonProfessionalTitleChanging(string value);
        partial void OnPersonProfessionalTitleChanged();
        /// <summary>
        /// There are no comments for Property GiroType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("GiroType")]

        partial void OnGiroTypeChanged();
        /// <summary>
        /// There are no comments for Property IsOrderNumberReferenceUsed in the schema.


        partial void OnIsOrderNumberReferenceUsedChanged();
        /// <summary>
        /// There are no comments for Property AddressCounty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressCounty")]
        public string AddressCounty
        {
            get
            {
                return this._AddressCounty;
            }
            set
            {
                this.OnAddressCountyChanging(value);
                this._AddressCounty = value;
                this.OnAddressCountyChanged();
                this.OnPropertyChanged("AddressCounty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressCounty;
        partial void OnAddressCountyChanging(string value);
        partial void OnAddressCountyChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactEmailIsIM in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property FederalComments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FederalComments")]
        public string FederalComments
        {
            get
            {
                return this._FederalComments;
            }
            set
            {
                this.OnFederalCommentsChanging(value);
                this._FederalComments = value;
                this.OnFederalCommentsChanged();
                this.OnPropertyChanged("FederalComments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _FederalComments;
        partial void OnFederalCommentsChanging(string value);
        partial void OnFederalCommentsChanged();
        /// <summary>
        /// There are no comments for Property WarehouseFulfillmentRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseFulfillmentRate")]
        public decimal WarehouseFulfillmentRate
        {
            get
            {
                return this._WarehouseFulfillmentRate;
            }
            set
            {
                this.OnWarehouseFulfillmentRateChanging(value);
                this._WarehouseFulfillmentRate = value;
                this.OnWarehouseFulfillmentRateChanged();
                this.OnPropertyChanged("WarehouseFulfillmentRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private decimal _WarehouseFulfillmentRate;
        partial void OnWarehouseFulfillmentRateChanging(decimal value);
        partial void OnWarehouseFulfillmentRateChanged();
        /// <summary>
        /// There are no comments for Property SalesCurrencyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesCurrencyCode")]

        [DataMember]
        public string SalesCurrencyCode
        {
            get
            {
                return this._SalesCurrencyCode;
            }
            set
            {
                this.OnSalesCurrencyCodeChanging(value);
                this._SalesCurrencyCode = value;
                this.OnSalesCurrencyCodeChanged();
                this.OnPropertyChanged("SalesCurrencyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesCurrencyCode;
        partial void OnSalesCurrencyCodeChanging(string value);
        partial void OnSalesCurrencyCodeChanged();
        /// <summary>
        /// There are no comments for Property PaymentSchedule in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentSchedule")]
        public string PaymentSchedule
        {
            get
            {
                return this._PaymentSchedule;
            }
            set
            {
                this.OnPaymentScheduleChanging(value);
                this._PaymentSchedule = value;
                this.OnPaymentScheduleChanged();
                this.OnPropertyChanged("PaymentSchedule");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentSchedule;
        partial void OnPaymentScheduleChanging(string value);
        partial void OnPaymentScheduleChanged();
        /// <summary>
        /// There are no comments for Property LineOfBusinessId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LineOfBusinessId")]
        public string LineOfBusinessId
        {
            get
            {
                return this._LineOfBusinessId;
            }
            set
            {
                this.OnLineOfBusinessIdChanging(value);
                this._LineOfBusinessId = value;
                this.OnLineOfBusinessIdChanged();
                this.OnPropertyChanged("LineOfBusinessId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _LineOfBusinessId;
        partial void OnLineOfBusinessIdChanging(string value);
        partial void OnLineOfBusinessIdChanged();
        /// <summary>
        /// There are no comments for Property CreditCardAddressVerificationLevel in the schema.
        /// </summary>

        partial void OnCreditCardAddressVerificationLevelChanged();
        /// <summary>
        /// There are no comments for Property ItemCustomerGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCustomerGroupId")]
        public string ItemCustomerGroupId
        {
            get
            {
                return this._ItemCustomerGroupId;
            }
            set
            {
                this.OnItemCustomerGroupIdChanging(value);
                this._ItemCustomerGroupId = value;
                this.OnItemCustomerGroupIdChanged();
                this.OnPropertyChanged("ItemCustomerGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ItemCustomerGroupId;
        partial void OnItemCustomerGroupIdChanging(string value);
        partial void OnItemCustomerGroupIdChanged();
        /// <summary>
        /// There are no comments for Property PaymentTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTerms")]
        public string PaymentTerms
        {
            get
            {
                return this._PaymentTerms;
            }
            set
            {
                this.OnPaymentTermsChanging(value);
                this._PaymentTerms = value;
                this.OnPaymentTermsChanged();
                this.OnPropertyChanged("PaymentTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentTerms;
        partial void OnPaymentTermsChanging(string value);
        partial void OnPaymentTermsChanged();
        /// <summary>
        /// There are no comments for Property IsOneTimeCustomer in the schema.
        /// </summary>

        partial void OnIsOneTimeCustomerChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactURL in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactURL")]
        public string PrimaryContactURL
        {
            get
            {
                return this._PrimaryContactURL;
            }
            set
            {
                this.OnPrimaryContactURLChanging(value);
                this._PrimaryContactURL = value;
                this.OnPrimaryContactURLChanged();
                this.OnPropertyChanged("PrimaryContactURL");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactURL;
        partial void OnPrimaryContactURLChanging(string value);
        partial void OnPrimaryContactURLChanged();
        /// <summary>
        /// There are no comments for Property SalesOrderPoolId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOrderPoolId")]
        public string SalesOrderPoolId
        {
            get
            {
                return this._SalesOrderPoolId;
            }
            set
            {
                this.OnSalesOrderPoolIdChanging(value);
                this._SalesOrderPoolId = value;
                this.OnSalesOrderPoolIdChanged();
                this.OnPropertyChanged("SalesOrderPoolId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesOrderPoolId;
        partial void OnSalesOrderPoolIdChanging(string value);
        partial void OnSalesOrderPoolIdChanged();
        /// <summary>
        /// There are no comments for Property TCSGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TCSGroup")]
        public string TCSGroup
        {
            get
            {
                return this._TCSGroup;
            }
            set
            {
                this.OnTCSGroupChanging(value);
                this._TCSGroup = value;
                this.OnTCSGroupChanged();
                this.OnPropertyChanged("TCSGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TCSGroup;
        partial void OnTCSGroupChanging(string value);
        partial void OnTCSGroupChanged();
        /// <summary>
        /// There are no comments for Property IsTransactionPostedAsShipment in the schema.
        /// </summary>
        partial void OnIsTransactionPostedAsShipmentChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactPhonePurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactPhonePurpose")]
        public string PrimaryContactPhonePurpose
        {
            get
            {
                return this._PrimaryContactPhonePurpose;
            }
            set
            {
                this.OnPrimaryContactPhonePurposeChanging(value);
                this._PrimaryContactPhonePurpose = value;
                this.OnPrimaryContactPhonePurposeChanged();
                this.OnPropertyChanged("PrimaryContactPhonePurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactPhonePurpose;
        partial void OnPrimaryContactPhonePurposeChanging(string value);
        partial void OnPrimaryContactPhonePurposeChanged();
        /// <summary>
        /// There are no comments for Property PersonAnniversaryMonth in the schema.
        /// </summary>

        partial void OnPersonAnniversaryMonthChanged();
        /// <summary>
        /// There are no comments for Property CURPNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CURPNumber")]
        public string CURPNumber
        {
            get
            {
                return this._CURPNumber;
            }
            set
            {
                this.OnCURPNumberChanging(value);
                this._CURPNumber = value;
                this.OnCURPNumberChanged();
                this.OnPropertyChanged("CURPNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CURPNumber;
        partial void OnCURPNumberChanging(string value);
        partial void OnCURPNumberChanged();
        /// <summary>
        /// There are no comments for Property OrderEntryDeadline in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderEntryDeadline")]
        public string OrderEntryDeadline
        {
            get
            {
                return this._OrderEntryDeadline;
            }
            set
            {
                this.OnOrderEntryDeadlineChanging(value);
                this._OrderEntryDeadline = value;
                this.OnOrderEntryDeadlineChanged();
                this.OnPropertyChanged("OrderEntryDeadline");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _OrderEntryDeadline;
        partial void OnOrderEntryDeadlineChanging(string value);
        partial void OnOrderEntryDeadlineChanged();
        /// <summary>
        /// There are no comments for Property PaymentCashDiscount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentCashDiscount")]
        public string PaymentCashDiscount
        {
            get
            {
                return this._PaymentCashDiscount;
            }
            set
            {
                this.OnPaymentCashDiscountChanging(value);
                this._PaymentCashDiscount = value;
                this.OnPaymentCashDiscountChanged();
                this.OnPropertyChanged("PaymentCashDiscount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentCashDiscount;
        partial void OnPaymentCashDiscountChanging(string value);
        partial void OnPaymentCashDiscountChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactFax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactFax")]
        public string PrimaryContactFax
        {
            get
            {
                return this._PrimaryContactFax;
            }
            set
            {
                this.OnPrimaryContactFaxChanging(value);
                this._PrimaryContactFax = value;
                this.OnPrimaryContactFaxChanged();
                this.OnPropertyChanged("PrimaryContactFax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactFax;
        partial void OnPrimaryContactFaxChanging(string value);
        partial void OnPrimaryContactFaxChanged();
        /// <summary>
        /// There are no comments for Property AddressStreet in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressStreet")]
        public string AddressStreet
        {
            get
            {
                return this._AddressStreet;
            }
            set
            {
                this.OnAddressStreetChanging(value);
                this._AddressStreet = value;
                this.OnAddressStreetChanged();
                this.OnPropertyChanged("AddressStreet");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressStreet;
        partial void OnAddressStreetChanging(string value);
        partial void OnAddressStreetChanged();
        /// <summary>
        /// There are no comments for Property PersonGender in the schema.
        /// </summary>

        partial void OnPersonGenderChanged();
        /// <summary>
        /// There are no comments for Property DeliveryMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryMode")]
        public string DeliveryMode
        {
            get
            {
                return this._DeliveryMode;
            }
            set
            {
                this.OnDeliveryModeChanging(value);
                this._DeliveryMode = value;
                this.OnDeliveryModeChanged();
                this.OnPropertyChanged("DeliveryMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DeliveryMode;
        partial void OnDeliveryModeChanging(string value);
        partial void OnDeliveryModeChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactPhoneIsMobile in the schema.
        /// </summary>
        /// <summary>
        /// There are no comments for Property IsRFIDCaseTaggingEnabled in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property AddressValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressValidTo")]
        public global::System.DateTimeOffset AddressValidTo
        {
            get
            {
                return this._AddressValidTo;
            }
            set
            {
                this.OnAddressValidToChanging(value);
                this._AddressValidTo = value;
                this.OnAddressValidToChanged();
                this.OnPropertyChanged("AddressValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.DateTimeOffset _AddressValidTo;
        partial void OnAddressValidToChanging(global::System.DateTimeOffset value);
        partial void OnAddressValidToChanged();
        /// <summary>
        /// There are no comments for Property DefaultInventoryStatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultInventoryStatusId")]
        public string DefaultInventoryStatusId
        {
            get
            {
                return this._DefaultInventoryStatusId;
            }
            set
            {
                this.OnDefaultInventoryStatusIdChanging(value);
                this._DefaultInventoryStatusId = value;
                this.OnDefaultInventoryStatusIdChanged();
                this.OnPropertyChanged("DefaultInventoryStatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DefaultInventoryStatusId;
        partial void OnDefaultInventoryStatusIdChanging(string value);
        partial void OnDefaultInventoryStatusIdChanged();
        /// <summary>
        /// There are no comments for Property PaymentDay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentDay")]
        public string PaymentDay
        {
            get
            {
                return this._PaymentDay;
            }
            set
            {
                this.OnPaymentDayChanging(value);
                this._PaymentDay = value;
                this.OnPaymentDayChanged();
                this.OnPropertyChanged("PaymentDay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentDay;
        partial void OnPaymentDayChanging(string value);
        partial void OnPaymentDayChanged();
        /// <summary>
        /// There are no comments for Property RFCNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("RFCNumber")]
        public string RFCNumber
        {
            get
            {
                return this._RFCNumber;
            }
            set
            {
                this.OnRFCNumberChanging(value);
                this._RFCNumber = value;
                this.OnRFCNumberChanged();
                this.OnPropertyChanged("RFCNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _RFCNumber;
        partial void OnRFCNumberChanging(string value);
        partial void OnRFCNumberChanged();
        /// <summary>
        /// There are no comments for Property CreditCardAddressVerificationIsAuthorizationVoidedOnFailure in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property PrimaryContactTelex in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactTelex")]
        public string PrimaryContactTelex
        {
            get
            {
                return this._PrimaryContactTelex;
            }
            set
            {
                this.OnPrimaryContactTelexChanging(value);
                this._PrimaryContactTelex = value;
                this.OnPrimaryContactTelexChanged();
                this.OnPropertyChanged("PrimaryContactTelex");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactTelex;
        partial void OnPrimaryContactTelexChanging(string value);
        partial void OnPrimaryContactTelexChanged();
        /// <summary>
        /// There are no comments for Property GiroTypeFreeTextInvoice in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property DestinationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DestinationCode")]
        public string DestinationCode
        {
            get
            {
                return this._DestinationCode;
            }
            set
            {
                this.OnDestinationCodeChanging(value);
                this._DestinationCode = value;
                this.OnDestinationCodeChanged();
                this.OnPropertyChanged("DestinationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DestinationCode;
        partial void OnDestinationCodeChanging(string value);
        partial void OnDestinationCodeChanged();
        /// <summary>
        /// There are no comments for Property PersonInitials in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonInitials")]
        public string PersonInitials
        {
            get
            {
                return this._PersonInitials;
            }
            set
            {
                this.OnPersonInitialsChanging(value);
                this._PersonInitials = value;
                this.OnPersonInitialsChanged();
                this.OnPropertyChanged("PersonInitials");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PersonInitials;
        partial void OnPersonInitialsChanging(string value);
        partial void OnPersonInitialsChanged();
        /// <summary>
        /// There are no comments for Property PersonMaritalStatus in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property IsSalesTaxIncludedInPrices in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property DataAreaId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("dataAreaId")]
        public string DataAreaId
        {
            get
            {
                return this._DataAreaId;
            }
            set
            {
                this.OnDataAreaIdChanging(value);
                this._DataAreaId = value;
                this.OnDataAreaIdChanged();
                this.OnPropertyChanged("dataAreaId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DataAreaId;
        partial void OnDataAreaIdChanging(string value);
        partial void OnDataAreaIdChanged();
        /// <summary>
        /// There are no comments for Property LanguageId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("LanguageId")]
        public string LanguageId
        {
            get
            {
                return this._LanguageId;
            }
            set
            {
                this.OnLanguageIdChanging(value);
                this._LanguageId = value;
                this.OnLanguageIdChanged();
                this.OnPropertyChanged("LanguageId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _LanguageId;
        partial void OnLanguageIdChanging(string value);
        partial void OnLanguageIdChanged();
        /// <summary>

        /// There are no comments for Property AddressCountryRegionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressCountryRegionId")]
        public string AddressCountryRegionId
        {
            get
            {
                return this._AddressCountryRegionId;
            }
            set
            {
                this.OnAddressCountryRegionIdChanging(value);
                this._AddressCountryRegionId = value;
                this.OnAddressCountryRegionIdChanged();
                this.OnPropertyChanged("AddressCountryRegionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressCountryRegionId;
        partial void OnAddressCountryRegionIdChanging(string value);
        partial void OnAddressCountryRegionIdChanged();
        /// <summary>
        /// There are no comments for Property IdentificationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("IdentificationNumber")]
        public string IdentificationNumber
        {
            get
            {
                return this._IdentificationNumber;
            }
            set
            {
                this.OnIdentificationNumberChanging(value);
                this._IdentificationNumber = value;
                this.OnIdentificationNumberChanged();
                this.OnPropertyChanged("IdentificationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _IdentificationNumber;
        partial void OnIdentificationNumberChanging(string value);
        partial void OnIdentificationNumberChanged();
        /// <summary>
        /// There are no comments for Property ReceiptOption in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property SupplementaryItemGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SupplementaryItemGroupId")]
        public string SupplementaryItemGroupId
        {
            get
            {
                return this._SupplementaryItemGroupId;
            }
            set
            {
                this.OnSupplementaryItemGroupIdChanging(value);
                this._SupplementaryItemGroupId = value;
                this.OnSupplementaryItemGroupIdChanged();
                this.OnPropertyChanged("SupplementaryItemGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SupplementaryItemGroupId;
        partial void OnSupplementaryItemGroupIdChanging(string value);
        partial void OnSupplementaryItemGroupIdChanged();
        /// <summary>
        /// There are no comments for Property CommissionCustomerGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CommissionCustomerGroupId")]
        public string CommissionCustomerGroupId
        {
            get
            {
                return this._CommissionCustomerGroupId;
            }
            set
            {
                this.OnCommissionCustomerGroupIdChanging(value);
                this._CommissionCustomerGroupId = value;
                this.OnCommissionCustomerGroupIdChanged();
                this.OnPropertyChanged("CommissionCustomerGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CommissionCustomerGroupId;
        partial void OnCommissionCustomerGroupIdChanging(string value);
        partial void OnCommissionCustomerGroupIdChanged();
        /// <summary>
        /// There are no comments for Property GiroTypeCollectionletter in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property CustomerTMAGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerTMAGroupId")]
        public string CustomerTMAGroupId
        {
            get
            {
                return this._CustomerTMAGroupId;
            }
            set
            {
                this.OnCustomerTMAGroupIdChanging(value);
                this._CustomerTMAGroupId = value;
                this.OnCustomerTMAGroupIdChanged();
                this.OnPropertyChanged("CustomerTMAGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CustomerTMAGroupId;
        partial void OnCustomerTMAGroupIdChanging(string value);
        partial void OnCustomerTMAGroupIdChanged();
        /// <summary>
        /// There are no comments for Property ForeignCustomer in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property FiscalCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalCode")]
        public string FiscalCode
        {
            get
            {
                return this._FiscalCode;
            }
            set
            {
                this.OnFiscalCodeChanging(value);
                this._FiscalCode = value;
                this.OnFiscalCodeChanged();
                this.OnPropertyChanged("FiscalCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _FiscalCode;
        partial void OnFiscalCodeChanging(string value);
        partial void OnFiscalCodeChanged();
        /// <summary>
        /// There are no comments for Property GiroTypeAccountStatement in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property CustomerAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerAccount")]

        [DataMember]
        public string CustomerAccount
        {
            get
            {
                return this._CustomerAccount;
            }
            set
            {
                this.OnCustomerAccountChanging(value);
                this._CustomerAccount = value;
                this.OnCustomerAccountChanged();
                this.OnPropertyChanged("CustomerAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CustomerAccount;
        partial void OnCustomerAccountChanging(string value);
        partial void OnCustomerAccountChanged();
        /// <summary>
        /// There are no comments for Property OrganizationABCCode in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property CreditLimit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditLimit")]
        public decimal CreditLimit
        {
            get
            {
                return this._CreditLimit;
            }
            set
            {
                this.OnCreditLimitChanging(value);
                this._CreditLimit = value;
                this.OnCreditLimitChanged();
                this.OnPropertyChanged("CreditLimit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private decimal _CreditLimit;
        partial void OnCreditLimitChanging(decimal value);
        partial void OnCreditLimitChanged();
        /// <summary>
        /// There are no comments for Property WarehouseFulfillmentType in the schema.
        /// </summary>

        /// There are no comments for Property OrganizationNumberOfEmployees in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationNumberOfEmployees")]
        public int OrganizationNumberOfEmployees
        {
            get
            {
                return this._OrganizationNumberOfEmployees;
            }
            set
            {
                this.OnOrganizationNumberOfEmployeesChanging(value);
                this._OrganizationNumberOfEmployees = value;
                this.OnOrganizationNumberOfEmployeesChanged();
                this.OnPropertyChanged("OrganizationNumberOfEmployees");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _OrganizationNumberOfEmployees;
        partial void OnOrganizationNumberOfEmployeesChanging(int value);
        partial void OnOrganizationNumberOfEmployeesChanged();
        /// <summary>
        /// There are no comments for Property DAXIntegrationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DAXIntegrationId")]
        public global::System.Guid DAXIntegrationId
        {
            get
            {
                return this._DAXIntegrationId;
            }
            set
            {
                this.OnDAXIntegrationIdChanging(value);
                this._DAXIntegrationId = value;
                this.OnDAXIntegrationIdChanged();
                this.OnPropertyChanged("DAXIntegrationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.Guid _DAXIntegrationId;
        partial void OnDAXIntegrationIdChanging(global::System.Guid value);
        partial void OnDAXIntegrationIdChanged();
        /// <summary>
        /// There are no comments for Property PaymentUseCashDiscount in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property CreditLimitIsMandatory in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property ElectronicInvoiceEAN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ElectronicInvoiceEAN")]
        public string ElectronicInvoiceEAN
        {
            get
            {
                return this._ElectronicInvoiceEAN;
            }
            set
            {
                this.OnElectronicInvoiceEANChanging(value);
                this._ElectronicInvoiceEAN = value;
                this.OnElectronicInvoiceEANChanged();
                this.OnPropertyChanged("ElectronicInvoiceEAN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ElectronicInvoiceEAN;
        partial void OnElectronicInvoiceEANChanging(string value);
        partial void OnElectronicInvoiceEANChanged();
        /// <summary>
        /// There are no comments for Property IsExcludedFromInterestChargeCalculation in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property TaxExemptNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxExemptNumber")]
        public string TaxExemptNumber
        {
            get
            {
                return this._TaxExemptNumber;
            }
            set
            {
                this.OnTaxExemptNumberChanging(value);
                this._TaxExemptNumber = value;
                this.OnTaxExemptNumberChanged();
                this.OnPropertyChanged("TaxExemptNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TaxExemptNumber;
        partial void OnTaxExemptNumberChanging(string value);
        partial void OnTaxExemptNumberChanged();
        /// <summary>
        /// There are no comments for Property IsFreightAccrued in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property PersonChildrenNames in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonChildrenNames")]
        public string PersonChildrenNames
        {
            get
            {
                return this._PersonChildrenNames;
            }
            set
            {
                this.OnPersonChildrenNamesChanging(value);
                this._PersonChildrenNames = value;
                this.OnPersonChildrenNamesChanged();
                this.OnPropertyChanged("PersonChildrenNames");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PersonChildrenNames;
        partial void OnPersonChildrenNamesChanging(string value);
        partial void OnPersonChildrenNamesChanged();
        /// <summary>
        /// There are no comments for Property PackingMaterialFeeLicenseNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PackingMaterialFeeLicenseNumber")]
        public string PackingMaterialFeeLicenseNumber
        {
            get
            {
                return this._PackingMaterialFeeLicenseNumber;
            }
            set
            {
                this.OnPackingMaterialFeeLicenseNumberChanging(value);
                this._PackingMaterialFeeLicenseNumber = value;
                this.OnPackingMaterialFeeLicenseNumberChanged();
                this.OnPropertyChanged("PackingMaterialFeeLicenseNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PackingMaterialFeeLicenseNumber;
        partial void OnPackingMaterialFeeLicenseNumberChanging(string value);
        partial void OnPackingMaterialFeeLicenseNumberChanged();
        /// <summary>
        /// There are no comments for Property IsExpressBillOfLadingAccepted in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property PartyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyType")]
        public string PartyType
        {
            get
            {
                return this._PartyType;
            }
            set
            {
                this.OnPartyTypeChanging(value);
                this._PartyType = value;
                this.OnPartyTypeChanged();
                this.OnPropertyChanged("PartyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PartyType;
        partial void OnPartyTypeChanging(string value);
        partial void OnPartyTypeChanged();
        /// <summary>
        /// There are no comments for Property TaxRegistrationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxRegistrationId")]
        public string TaxRegistrationId
        {
            get
            {
                return this._TaxRegistrationId;
            }
            set
            {
                this.OnTaxRegistrationIdChanging(value);
                this._TaxRegistrationId = value;
                this.OnTaxRegistrationIdChanged();
                this.OnPropertyChanged("TaxRegistrationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TaxRegistrationId;
        partial void OnTaxRegistrationIdChanging(string value);
        partial void OnTaxRegistrationIdChanged();
        /// <summary>
        /// There are no comments for Property PersonPhoneticFirstName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonPhoneticFirstName")]
        public string PersonPhoneticFirstName
        {
            get
            {
                return this._PersonPhoneticFirstName;
            }
            set
            {
                this.OnPersonPhoneticFirstNameChanging(value);
                this._PersonPhoneticFirstName = value;
                this.OnPersonPhoneticFirstNameChanged();
                this.OnPropertyChanged("PersonPhoneticFirstName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PersonPhoneticFirstName;
        partial void OnPersonPhoneticFirstNameChanging(string value);
        partial void OnPersonPhoneticFirstNameChanged();
        /// <summary>
        /// There are no comments for Property PersonAnniversaryYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonAnniversaryYear")]
        public int PersonAnniversaryYear
        {
            get
            {
                return this._PersonAnniversaryYear;
            }
            set
            {
                this.OnPersonAnniversaryYearChanging(value);
                this._PersonAnniversaryYear = value;
                this.OnPersonAnniversaryYearChanged();
                this.OnPropertyChanged("PersonAnniversaryYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _PersonAnniversaryYear;
        partial void OnPersonAnniversaryYearChanging(int value);
        partial void OnPersonAnniversaryYearChanged();
        /// <summary>
        /// There are no comments for Property TDSGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TDSGroup")]
        public string TDSGroup
        {
            get
            {
                return this._TDSGroup;
            }
            set
            {
                this.OnTDSGroupChanging(value);
                this._TDSGroup = value;
                this.OnTDSGroupChanged();
                this.OnPropertyChanged("TDSGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TDSGroup;
        partial void OnTDSGroupChanging(string value);
        partial void OnTDSGroupChanged();
        /// <summary>
        /// There are no comments for Property PersonProfessionalSuffix in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonProfessionalSuffix")]
        public string PersonProfessionalSuffix
        {
            get
            {
                return this._PersonProfessionalSuffix;
            }
            set
            {
                this.OnPersonProfessionalSuffixChanging(value);
                this._PersonProfessionalSuffix = value;
                this.OnPersonProfessionalSuffixChanged();
                this.OnPropertyChanged("PersonProfessionalSuffix");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PersonProfessionalSuffix;
        partial void OnPersonProfessionalSuffixChanging(string value);
        partial void OnPersonProfessionalSuffixChanged();
        /// <summary>
        /// There are no comments for Property PreferentialCustomer in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property NAFCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("NAFCode")]
        public string NAFCode
        {
            get
            {
                return this._NAFCode;
            }
            set
            {
                this.OnNAFCodeChanging(value);
                this._NAFCode = value;
                this.OnNAFCodeChanged();
                this.OnPropertyChanged("NAFCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _NAFCode;
        partial void OnNAFCodeChanging(string value);
        partial void OnNAFCodeChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactEmailPurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactEmailPurpose")]
        public string PrimaryContactEmailPurpose
        {
            get
            {
                return this._PrimaryContactEmailPurpose;
            }
            set
            {
                this.OnPrimaryContactEmailPurposeChanging(value);
                this._PrimaryContactEmailPurpose = value;
                this.OnPrimaryContactEmailPurposeChanged();
                this.OnPropertyChanged("PrimaryContactEmailPurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactEmailPurpose;
        partial void OnPrimaryContactEmailPurposeChanging(string value);
        partial void OnPrimaryContactEmailPurposeChanged();
        /// <summary>
        /// There are no comments for Property FullPrimaryAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FullPrimaryAddress")]
        public string FullPrimaryAddress
        {
            get
            {
                return this._FullPrimaryAddress;
            }
            set
            {
                this.OnFullPrimaryAddressChanging(value);
                this._FullPrimaryAddress = value;
                this.OnFullPrimaryAddressChanged();
                this.OnPropertyChanged("FullPrimaryAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _FullPrimaryAddress;
        partial void OnFullPrimaryAddressChanging(string value);
        partial void OnFullPrimaryAddressChanged();
        /// <summary>
        /// There are no comments for Property CompanyChain in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CompanyChain")]
        public string CompanyChain
        {
            get
            {
                return this._CompanyChain;
            }
            set
            {
                this.OnCompanyChainChanging(value);
                this._CompanyChain = value;
                this.OnCompanyChainChanged();
                this.OnPropertyChanged("CompanyChain");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CompanyChain;
        partial void OnCompanyChainChanging(string value);
        partial void OnCompanyChainChanged();
        /// <summary>
        /// There are no comments for Property AddressValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressValidFrom")]
        public global::System.DateTimeOffset AddressValidFrom
        {
            get
            {
                return this._AddressValidFrom;
            }
            set
            {
                this.OnAddressValidFromChanging(value);
                this._AddressValidFrom = value;
                this.OnAddressValidFromChanged();
                this.OnPropertyChanged("AddressValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private global::System.DateTimeOffset _AddressValidFrom;
        partial void OnAddressValidFromChanging(global::System.DateTimeOffset value);
        partial void OnAddressValidFromChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactURLPurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactURLPurpose")]
        public string PrimaryContactURLPurpose
        {
            get
            {
                return this._PrimaryContactURLPurpose;
            }
            set
            {
                this.OnPrimaryContactURLPurposeChanging(value);
                this._PrimaryContactURLPurpose = value;
                this.OnPrimaryContactURLPurposeChanged();
                this.OnPropertyChanged("PrimaryContactURLPurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactURLPurpose;
        partial void OnPrimaryContactURLPurposeChanging(string value);
        partial void OnPrimaryContactURLPurposeChanged();
        /// <summary>
        /// There are no comments for Property CustomerGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerGroupId")]

        [DataMember]
        public string CustomerGroupId
        {
            get
            {
                return this._CustomerGroupId;
            }
            set
            {
                this.OnCustomerGroupIdChanging(value);
                this._CustomerGroupId = value;
                this.OnCustomerGroupIdChanged();
                this.OnPropertyChanged("CustomerGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CustomerGroupId;
        partial void OnCustomerGroupIdChanging(string value);
        partial void OnCustomerGroupIdChanged();
        /// <summary>
        /// There are no comments for Property MultiLineDiscountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("MultiLineDiscountCode")]
        public string MultiLineDiscountCode
        {
            get
            {
                return this._MultiLineDiscountCode;
            }
            set
            {
                this.OnMultiLineDiscountCodeChanging(value);
                this._MultiLineDiscountCode = value;
                this.OnMultiLineDiscountCodeChanged();
                this.OnPropertyChanged("MultiLineDiscountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _MultiLineDiscountCode;
        partial void OnMultiLineDiscountCodeChanging(string value);
        partial void OnMultiLineDiscountCodeChanged();
        /// <summary>
        /// There are no comments for Property ReceiptEmail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceiptEmail")]
        public string ReceiptEmail
        {
            get
            {
                return this._ReceiptEmail;
            }
            set
            {
                this.OnReceiptEmailChanging(value);
                this._ReceiptEmail = value;
                this.OnReceiptEmailChanged();
                this.OnPropertyChanged("ReceiptEmail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ReceiptEmail;
        partial void OnReceiptEmailChanging(string value);
        partial void OnReceiptEmailChanged();
        /// <summary>
        /// There are no comments for Property PersonHobbies in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonHobbies")]
        public string PersonHobbies
        {
            get
            {
                return this._PersonHobbies;
            }
            set
            {
                this.OnPersonHobbiesChanging(value);
                this._PersonHobbies = value;
                this.OnPersonHobbiesChanged();
                this.OnPropertyChanged("PersonHobbies");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PersonHobbies;
        partial void OnPersonHobbiesChanging(string value);
        partial void OnPersonHobbiesChanged();
        /// <summary>
        /// There are no comments for Property CreditCardCVC in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property AddressDistrictName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressDistrictName")]
        public string AddressDistrictName
        {
            get
            {
                return this._AddressDistrictName;
            }
            set
            {
                this.OnAddressDistrictNameChanging(value);
                this._AddressDistrictName = value;
                this.OnAddressDistrictNameChanged();
                this.OnPropertyChanged("AddressDistrictName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressDistrictName;
        partial void OnAddressDistrictNameChanging(string value);
        partial void OnAddressDistrictNameChanged();
        /// <summary>
        /// There are no comments for Property AddressLocationRoles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressLocationRoles")]
        public string AddressLocationRoles
        {
            get
            {
                return this._AddressLocationRoles;
            }
            set
            {
                this.OnAddressLocationRolesChanging(value);
                this._AddressLocationRoles = value;
                this.OnAddressLocationRolesChanged();
                this.OnPropertyChanged("AddressLocationRoles");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _AddressLocationRoles;
        partial void OnAddressLocationRolesChanging(string value);
        partial void OnAddressLocationRolesChanged();
        /// <summary>
        /// There are no comments for Property CentralBankPurposeNotes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CentralBankPurposeNotes")]
        public string CentralBankPurposeNotes
        {
            get
            {
                return this._CentralBankPurposeNotes;
            }
            set
            {
                this.OnCentralBankPurposeNotesChanging(value);
                this._CentralBankPurposeNotes = value;
                this.OnCentralBankPurposeNotesChanged();
                this.OnPropertyChanged("CentralBankPurposeNotes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CentralBankPurposeNotes;
        partial void OnCentralBankPurposeNotesChanging(string value);
        partial void OnCentralBankPurposeNotesChanged();
        /// <summary>
        /// There are no comments for Property DiscountPriceGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountPriceGroupId")]
        public string DiscountPriceGroupId
        {
            get
            {
                return this._DiscountPriceGroupId;
            }
            set
            {
                this.OnDiscountPriceGroupIdChanging(value);
                this._DiscountPriceGroupId = value;
                this.OnDiscountPriceGroupIdChanged();
                this.OnPropertyChanged("DiscountPriceGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DiscountPriceGroupId;
        partial void OnDiscountPriceGroupIdChanging(string value);
        partial void OnDiscountPriceGroupIdChanged();
        /// <summary>
        /// There are no comments for Property NationalRegistryNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("NationalRegistryNumber")]
        public string NationalRegistryNumber
        {
            get
            {
                return this._NationalRegistryNumber;
            }
            set
            {
                this.OnNationalRegistryNumberChanging(value);
                this._NationalRegistryNumber = value;
                this.OnNationalRegistryNumberChanged();
                this.OnPropertyChanged("NationalRegistryNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _NationalRegistryNumber;
        partial void OnNationalRegistryNumberChanging(string value);
        partial void OnNationalRegistryNumberChanged();
        /// <summary>
        /// There are no comments for Property CollectionsContactPersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CollectionsContactPersonId")]
        public string CollectionsContactPersonId
        {
            get
            {
                return this._CollectionsContactPersonId;
            }
            set
            {
                this.OnCollectionsContactPersonIdChanging(value);
                this._CollectionsContactPersonId = value;
                this.OnCollectionsContactPersonIdChanged();
                this.OnPropertyChanged("CollectionsContactPersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CollectionsContactPersonId;
        partial void OnCollectionsContactPersonIdChanging(string value);
        partial void OnCollectionsContactPersonIdChanged();
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyNumber")]
        public string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property InvoiceAddress in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property FederalAgencyLocationCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FederalAgencyLocationCode")]
        public string FederalAgencyLocationCode
        {
            get
            {
                return this._FederalAgencyLocationCode;
            }
            set
            {
                this.OnFederalAgencyLocationCodeChanging(value);
                this._FederalAgencyLocationCode = value;
                this.OnFederalAgencyLocationCodeChanged();
                this.OnPropertyChanged("FederalAgencyLocationCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _FederalAgencyLocationCode;
        partial void OnFederalAgencyLocationCodeChanging(string value);
        partial void OnFederalAgencyLocationCodeChanged();
        /// <summary>
        /// There are no comments for Property WarehouseIsASNGenerated in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property CompanyType in the schema.
        /// </summary>



        //NAME


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]


        [DataMember]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();



        //NAME





        /// <summary>
        /// There are no comments for Property ReliefGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReliefGroupId")]
        public string ReliefGroupId
        {
            get
            {
                return this._ReliefGroupId;
            }
            set
            {
                this.OnReliefGroupIdChanging(value);
                this._ReliefGroupId = value;
                this.OnReliefGroupIdChanged();
                this.OnPropertyChanged("ReliefGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ReliefGroupId;
        partial void OnReliefGroupIdChanging(string value);
        partial void OnReliefGroupIdChanged();
        /// <summary>
        /// There are no comments for Property FrenchSiret in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("FrenchSiret")]
        public string FrenchSiret
        {
            get
            {
                return this._FrenchSiret;
            }
            set
            {
                this.OnFrenchSiretChanging(value);
                this._FrenchSiret = value;
                this.OnFrenchSiretChanged();
                this.OnPropertyChanged("FrenchSiret");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _FrenchSiret;
        partial void OnFrenchSiretChanging(string value);
        partial void OnFrenchSiretChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactTelexPurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactTelexPurpose")]
        public string PrimaryContactTelexPurpose
        {
            get
            {
                return this._PrimaryContactTelexPurpose;
            }
            set
            {
                this.OnPrimaryContactTelexPurposeChanging(value);
                this._PrimaryContactTelexPurpose = value;
                this.OnPrimaryContactTelexPurposeChanged();
                this.OnPropertyChanged("PrimaryContactTelexPurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactTelexPurpose;
        partial void OnPrimaryContactTelexPurposeChanging(string value);
        partial void OnPrimaryContactTelexPurposeChanged();
        /// <summary>
        /// There are no comments for Property FulfillmentErrorTolerance in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property ReceiptCalendar in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceiptCalendar")]
        public string ReceiptCalendar
        {
            get
            {
                return this._ReceiptCalendar;
            }
            set
            {
                this.OnReceiptCalendarChanging(value);
                this._ReceiptCalendar = value;
                this.OnReceiptCalendarChanged();
                this.OnPropertyChanged("ReceiptCalendar");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ReceiptCalendar;
        partial void OnReceiptCalendarChanging(string value);
        partial void OnReceiptCalendarChanged();
        /// <summary>
        /// There are no comments for Property SalesReturnTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesReturnTaxGroup")]
        public string SalesReturnTaxGroup
        {
            get
            {
                return this._SalesReturnTaxGroup;
            }
            set
            {
                this.OnSalesReturnTaxGroupChanging(value);
                this._SalesReturnTaxGroup = value;
                this.OnSalesReturnTaxGroupChanged();
                this.OnPropertyChanged("SalesReturnTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesReturnTaxGroup;
        partial void OnSalesReturnTaxGroupChanging(string value);
        partial void OnSalesReturnTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property SalesMemo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesMemo")]
        public string SalesMemo
        {
            get
            {
                return this._SalesMemo;
            }
            set
            {
                this.OnSalesMemoChanging(value);
                this._SalesMemo = value;
                this.OnSalesMemoChanged();
                this.OnPropertyChanged("SalesMemo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesMemo;
        partial void OnSalesMemoChanging(string value);
        partial void OnSalesMemoChanged();
        /// <summary>
        /// There are no comments for Property EmployeeResponsibleNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeResponsibleNumber")]
        public string EmployeeResponsibleNumber
        {
            get
            {
                return this._EmployeeResponsibleNumber;
            }
            set
            {
                this.OnEmployeeResponsibleNumberChanging(value);
                this._EmployeeResponsibleNumber = value;
                this.OnEmployeeResponsibleNumberChanged();
                this.OnPropertyChanged("EmployeeResponsibleNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _EmployeeResponsibleNumber;
        partial void OnEmployeeResponsibleNumberChanging(string value);
        partial void OnEmployeeResponsibleNumberChanged();
        /// <summary>
        /// There are no comments for Property ContactPersonId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ContactPersonId")]
        public string ContactPersonId
        {
            get
            {
                return this._ContactPersonId;
            }
            set
            {
                this.OnContactPersonIdChanging(value);
                this._ContactPersonId = value;
                this.OnContactPersonIdChanged();
                this.OnPropertyChanged("ContactPersonId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ContactPersonId;
        partial void OnContactPersonIdChanging(string value);
        partial void OnContactPersonIdChanged();
        /// <summary>
        /// There are no comments for Property CreditRating in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditRating")]
        public string CreditRating
        {
            get
            {
                return this._CreditRating;
            }
            set
            {
                this.OnCreditRatingChanging(value);
                this._CreditRating = value;
                this.OnCreditRatingChanged();
                this.OnPropertyChanged("CreditRating");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CreditRating;
        partial void OnCreditRatingChanging(string value);
        partial void OnCreditRatingChanged();
        /// <summary>
        /// There are no comments for Property PaymentBankAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentBankAccount")]
        public string PaymentBankAccount
        {
            get
            {
                return this._PaymentBankAccount;
            }
            set
            {
                this.OnPaymentBankAccountChanging(value);
                this._PaymentBankAccount = value;
                this.OnPaymentBankAccountChanged();
                this.OnPropertyChanged("PaymentBankAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentBankAccount;
        partial void OnPaymentBankAccountChanging(string value);
        partial void OnPaymentBankAccountChanged();
        /// <summary>
        /// There are no comments for Property ChargesGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ChargesGroupId")]
        public string ChargesGroupId
        {
            get
            {
                return this._ChargesGroupId;
            }
            set
            {
                this.OnChargesGroupIdChanging(value);
                this._ChargesGroupId = value;
                this.OnChargesGroupIdChanged();
                this.OnPropertyChanged("ChargesGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _ChargesGroupId;
        partial void OnChargesGroupIdChanging(string value);
        partial void OnChargesGroupIdChanged();
        /// <summary>
        /// There are no comments for Property OnHoldStatus in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property EnterpriseNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EnterpriseNumber")]
        public string EnterpriseNumber
        {
            get
            {
                return this._EnterpriseNumber;
            }
            set
            {
                this.OnEnterpriseNumberChanging(value);
                this._EnterpriseNumber = value;
                this.OnEnterpriseNumberChanged();
                this.OnPropertyChanged("EnterpriseNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _EnterpriseNumber;
        partial void OnEnterpriseNumberChanging(string value);
        partial void OnEnterpriseNumberChanged();
        /// <summary>
        /// There are no comments for Property GiroTypeProjInvoice in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property NameAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("NameAlias")]
        public string NameAlias
        {
            get
            {
                return this._NameAlias;
            }
            set
            {
                this.OnNameAliasChanging(value);
                this._NameAlias = value;
                this.OnNameAliasChanged();
                this.OnPropertyChanged("NameAlias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _NameAlias;
        partial void OnNameAliasChanging(string value);
        partial void OnNameAliasChanged();
        /// <summary>
        /// There are no comments for Property VendorAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccount")]
        public string VendorAccount
        {
            get
            {
                return this._VendorAccount;
            }
            set
            {
                this.OnVendorAccountChanging(value);
                this._VendorAccount = value;
                this.OnVendorAccountChanged();
                this.OnPropertyChanged("VendorAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _VendorAccount;
        partial void OnVendorAccountChanging(string value);
        partial void OnVendorAccountChanged();
        /// <summary>
        /// There are no comments for Property IsRFIDPalletTaggingEnabled in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property PANNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PANNumber")]
        public string PANNumber
        {
            get
            {
                return this._PANNumber;
            }
            set
            {
                this.OnPANNumberChanging(value);
                this._PANNumber = value;
                this.OnPANNumberChanged();
                this.OnPropertyChanged("PANNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PANNumber;
        partial void OnPANNumberChanging(string value);
        partial void OnPANNumberChanged();
        /// <summary>
        /// There are no comments for Property OrganizationPhoneticName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationPhoneticName")]
        public string OrganizationPhoneticName
        {
            get
            {
                return this._OrganizationPhoneticName;
            }
            set
            {
                this.OnOrganizationPhoneticNameChanging(value);
                this._OrganizationPhoneticName = value;
                this.OnOrganizationPhoneticNameChanged();
                this.OnPropertyChanged("OrganizationPhoneticName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _OrganizationPhoneticName;
        partial void OnOrganizationPhoneticNameChanging(string value);
        partial void OnOrganizationPhoneticNameChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactPhone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactPhone")]
        public string PrimaryContactPhone
        {
            get
            {
                return this._PrimaryContactPhone;
            }
            set
            {
                this.OnPrimaryContactPhoneChanging(value);
                this._PrimaryContactPhone = value;
                this.OnPrimaryContactPhoneChanged();
                this.OnPropertyChanged("PrimaryContactPhone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactPhone;
        partial void OnPrimaryContactPhoneChanging(string value);
        partial void OnPrimaryContactPhoneChanged();
        /// <summary>
        /// There are no comments for Property IsElectronicInvoice in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property SalesDistrict in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesDistrict")]
        public string SalesDistrict
        {
            get
            {
                return this._SalesDistrict;
            }
            set
            {
                this.OnSalesDistrictChanging(value);
                this._SalesDistrict = value;
                this.OnSalesDistrictChanged();
                this.OnPropertyChanged("SalesDistrict");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesDistrict;
        partial void OnSalesDistrictChanging(string value);
        partial void OnSalesDistrictChanged();
        /// <summary>
        /// There are no comments for Property SalesAccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesAccountNumber")]
        public string SalesAccountNumber
        {
            get
            {
                return this._SalesAccountNumber;
            }
            set
            {
                this.OnSalesAccountNumberChanging(value);
                this._SalesAccountNumber = value;
                this.OnSalesAccountNumberChanged();
                this.OnPropertyChanged("SalesAccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesAccountNumber;
        partial void OnSalesAccountNumberChanging(string value);
        partial void OnSalesAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxGroup")]
        public string SalesTaxGroup
        {
            get
            {
                return this._SalesTaxGroup;
            }
            set
            {
                this.OnSalesTaxGroupChanging(value);
                this._SalesTaxGroup = value;
                this.OnSalesTaxGroupChanged();
                this.OnPropertyChanged("SalesTaxGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesTaxGroup;
        partial void OnSalesTaxGroupChanging(string value);
        partial void OnSalesTaxGroupChanged();
        /// <summary>
        /// There are no comments for Property DefaultDimensionDisplayValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultDimensionDisplayValue")]
        public string DefaultDimensionDisplayValue
        {
            get
            {
                return this._DefaultDimensionDisplayValue;
            }
            set
            {
                this.OnDefaultDimensionDisplayValueChanging(value);
                this._DefaultDimensionDisplayValue = value;
                this.OnDefaultDimensionDisplayValueChanged();
                this.OnPropertyChanged("DefaultDimensionDisplayValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DefaultDimensionDisplayValue;
        partial void OnDefaultDimensionDisplayValueChanging(string value);
        partial void OnDefaultDimensionDisplayValueChanged();
        /// <summary>
        /// There are no comments for Property TotalDiscountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalDiscountCode")]
        public string TotalDiscountCode
        {
            get
            {
                return this._TotalDiscountCode;
            }
            set
            {
                this.OnTotalDiscountCodeChanging(value);
                this._TotalDiscountCode = value;
                this.OnTotalDiscountCodeChanged();
                this.OnPropertyChanged("TotalDiscountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _TotalDiscountCode;
        partial void OnTotalDiscountCodeChanging(string value);
        partial void OnTotalDiscountCodeChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactEmail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactEmail")]
        public string PrimaryContactEmail
        {
            get
            {
                return this._PrimaryContactEmail;
            }
            set
            {
                this.OnPrimaryContactEmailChanging(value);
                this._PrimaryContactEmail = value;
                this.OnPrimaryContactEmailChanged();
                this.OnPropertyChanged("PrimaryContactEmail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactEmail;
        partial void OnPrimaryContactEmailChanging(string value);
        partial void OnPrimaryContactEmailChanged();
        /// <summary>
        /// There are no comments for Property PaymentFactoringAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentFactoringAccount")]
        public string PaymentFactoringAccount
        {
            get
            {
                return this._PaymentFactoringAccount;
            }
            set
            {
                this.OnPaymentFactoringAccountChanging(value);
                this._PaymentFactoringAccount = value;
                this.OnPaymentFactoringAccountChanged();
                this.OnPropertyChanged("PaymentFactoringAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentFactoringAccount;
        partial void OnPaymentFactoringAccountChanging(string value);
        partial void OnPaymentFactoringAccountChanged();
        /// <summary>
        /// There are no comments for Property AddressLongitude in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddressLongitude")]
        public decimal AddressLongitude
        {
            get
            {
                return this._AddressLongitude;
            }
            set
            {
                this.OnAddressLongitudeChanging(value);
                this._AddressLongitude = value;
                this.OnAddressLongitudeChanged();
                this.OnPropertyChanged("AddressLongitude");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private decimal _AddressLongitude;
        partial void OnAddressLongitudeChanging(decimal value);
        partial void OnAddressLongitudeChanged();
        /// <summary>
        /// There are no comments for Property CentralBankPurposeCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CentralBankPurposeCode")]
        public string CentralBankPurposeCode
        {
            get
            {
                return this._CentralBankPurposeCode;
            }
            set
            {
                this.OnCentralBankPurposeCodeChanging(value);
                this._CentralBankPurposeCode = value;
                this.OnCentralBankPurposeCodeChanged();
                this.OnPropertyChanged("CentralBankPurposeCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CentralBankPurposeCode;
        partial void OnCentralBankPurposeCodeChanging(string value);
        partial void OnCentralBankPurposeCodeChanged();
        /// <summary>
        /// There are no comments for Property OrganizationNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationNumber")]
        public string OrganizationNumber
        {
            get
            {
                return this._OrganizationNumber;
            }
            set
            {
                this.OnOrganizationNumberChanging(value);
                this._OrganizationNumber = value;
                this.OnOrganizationNumberChanged();
                this.OnPropertyChanged("OrganizationNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _OrganizationNumber;
        partial void OnOrganizationNumberChanging(string value);
        partial void OnOrganizationNumberChanged();
        /// <summary>
        /// There are no comments for Property FederalIndicator in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property PersonPhoneticMiddleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonPhoneticMiddleName")]
        public string PersonPhoneticMiddleName
        {
            get
            {
                return this._PersonPhoneticMiddleName;
            }
            set
            {
                this.OnPersonPhoneticMiddleNameChanging(value);
                this._PersonPhoneticMiddleName = value;
                this.OnPersonPhoneticMiddleNameChanged();
                this.OnPropertyChanged("PersonPhoneticMiddleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PersonPhoneticMiddleName;
        partial void OnPersonPhoneticMiddleNameChanging(string value);
        partial void OnPersonPhoneticMiddleNameChanged();
        /// <summary>
        /// There are no comments for Property DeliveryReason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryReason")]
        public string DeliveryReason
        {
            get
            {
                return this._DeliveryReason;
            }
            set
            {
                this.OnDeliveryReasonChanging(value);
                this._DeliveryReason = value;
                this.OnDeliveryReasonChanged();
                this.OnPropertyChanged("DeliveryReason");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DeliveryReason;
        partial void OnDeliveryReasonChanging(string value);
        partial void OnDeliveryReasonChanged();
        /// <summary>
        /// There are no comments for Property PackingDutyLicense in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PackingDutyLicense")]
        public string PackingDutyLicense
        {
            get
            {
                return this._PackingDutyLicense;
            }
            set
            {
                this.OnPackingDutyLicenseChanging(value);
                this._PackingDutyLicense = value;
                this.OnPackingDutyLicenseChanged();
                this.OnPropertyChanged("PackingDutyLicense");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PackingDutyLicense;
        partial void OnPackingDutyLicenseChanging(string value);
        partial void OnPackingDutyLicenseChanged();
        /// <summary>
        /// There are no comments for Property CalculateWithholdingTax in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property StatisticsGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("StatisticsGroupId")]
        public string StatisticsGroupId
        {
            get
            {
                return this._StatisticsGroupId;
            }
            set
            {
                this.OnStatisticsGroupIdChanging(value);
                this._StatisticsGroupId = value;
                this.OnStatisticsGroupIdChanged();
                this.OnPropertyChanged("StatisticsGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _StatisticsGroupId;
        partial void OnStatisticsGroupIdChanging(string value);
        partial void OnStatisticsGroupIdChanged();
        /// <summary>
        /// There are no comments for Property StateInscription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("StateInscription")]
        public string StateInscription
        {
            get
            {
                return this._StateInscription;
            }
            set
            {
                this.OnStateInscriptionChanging(value);
                this._StateInscription = value;
                this.OnStateInscriptionChanged();
                this.OnPropertyChanged("StateInscription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _StateInscription;
        partial void OnStateInscriptionChanging(string value);
        partial void OnStateInscriptionChanged();
        /// <summary>
        /// There are no comments for Property SalesSubsegmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesSubsegmentId")]
        public string SalesSubsegmentId
        {
            get
            {
                return this._SalesSubsegmentId;
            }
            set
            {
                this.OnSalesSubsegmentIdChanging(value);
                this._SalesSubsegmentId = value;
                this.OnSalesSubsegmentIdChanged();
                this.OnPropertyChanged("SalesSubsegmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesSubsegmentId;
        partial void OnSalesSubsegmentIdChanging(string value);
        partial void OnSalesSubsegmentIdChanged();
        /// <summary>
        /// There are no comments for Property PaymentTermsBaseDays in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTermsBaseDays")]
        public int PaymentTermsBaseDays
        {
            get
            {
                return this._PaymentTermsBaseDays;
            }
            set
            {
                this.OnPaymentTermsBaseDaysChanging(value);
                this._PaymentTermsBaseDays = value;
                this.OnPaymentTermsBaseDaysChanged();
                this.OnPropertyChanged("PaymentTermsBaseDays");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _PaymentTermsBaseDays;
        partial void OnPaymentTermsBaseDaysChanging(int value);
        partial void OnPaymentTermsBaseDaysChanged();
        /// <summary>
        /// There are no comments for Property PrimaryContactFaxPurpose in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactFaxPurpose")]
        public string PrimaryContactFaxPurpose
        {
            get
            {
                return this._PrimaryContactFaxPurpose;
            }
            set
            {
                this.OnPrimaryContactFaxPurposeChanging(value);
                this._PrimaryContactFaxPurpose = value;
                this.OnPrimaryContactFaxPurposeChanged();
                this.OnPropertyChanged("PrimaryContactFaxPurpose");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PrimaryContactFaxPurpose;
        partial void OnPrimaryContactFaxPurposeChanging(string value);
        partial void OnPrimaryContactFaxPurposeChanged();
        /// <summary>
        /// There are no comments for Property KnownAs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("KnownAs")]
        public string KnownAs
        {
            get
            {
                return this._KnownAs;
            }
            set
            {
                this.OnKnownAsChanging(value);
                this._KnownAs = value;
                this.OnKnownAsChanged();
                this.OnPropertyChanged("KnownAs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _KnownAs;
        partial void OnKnownAsChanging(string value);
        partial void OnKnownAsChanged();
        /// <summary>
        /// There are no comments for Property IsFuelSurchargeApplied in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property CommissionSalesGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CommissionSalesGroupId")]
        public string CommissionSalesGroupId
        {
            get
            {
                return this._CommissionSalesGroupId;
            }
            set
            {
                this.OnCommissionSalesGroupIdChanging(value);
                this._CommissionSalesGroupId = value;
                this.OnCommissionSalesGroupIdChanged();
                this.OnPropertyChanged("CommissionSalesGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _CommissionSalesGroupId;
        partial void OnCommissionSalesGroupIdChanging(string value);
        partial void OnCommissionSalesGroupIdChanged();
        /// <summary>
        /// There are no comments for Property SalesSegmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesSegmentId")]
        public string SalesSegmentId
        {
            get
            {
                return this._SalesSegmentId;
            }
            set
            {
                this.OnSalesSegmentIdChanging(value);
                this._SalesSegmentId = value;
                this.OnSalesSegmentIdChanged();
                this.OnPropertyChanged("SalesSegmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _SalesSegmentId;
        partial void OnSalesSegmentIdChanging(string value);
        partial void OnSalesSegmentIdChanged();
        /// <summary>
        /// There are no comments for Property IsWithholdingTaxCalculated in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property PersonPhoneticLastName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonPhoneticLastName")]
        public string PersonPhoneticLastName
        {
            get
            {
                return this._PersonPhoneticLastName;
            }
            set
            {
                this.OnPersonPhoneticLastNameChanging(value);
                this._PersonPhoneticLastName = value;
                this.OnPersonPhoneticLastNameChanged();
                this.OnPropertyChanged("PersonPhoneticLastName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PersonPhoneticLastName;
        partial void OnPersonPhoneticLastNameChanging(string value);
        partial void OnPersonPhoneticLastNameChanged();
        /// <summary>
        /// There are no comments for Property PartyCountry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PartyCountry")]
        public string PartyCountry
        {
            get
            {
                return this._PartyCountry;
            }
            set
            {
                this.OnPartyCountryChanging(value);
                this._PartyCountry = value;
                this.OnPartyCountryChanged();
                this.OnPropertyChanged("PartyCountry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PartyCountry;
        partial void OnPartyCountryChanging(string value);
        partial void OnPartyCountryChanged();
        /// <summary>
        /// There are no comments for Property GiroTypeInterestNote in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property PaymentSpecification in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentSpecification")]
        public string PaymentSpecification
        {
            get
            {
                return this._PaymentSpecification;
            }
            set
            {
                this.OnPaymentSpecificationChanging(value);
                this._PaymentSpecification = value;
                this.OnPaymentSpecificationChanged();
                this.OnPropertyChanged("PaymentSpecification");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentSpecification;
        partial void OnPaymentSpecificationChanging(string value);
        partial void OnPaymentSpecificationChanged();
        /// <summary>
        /// There are no comments for Property ConsolidationDay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ConsolidationDay")]
        public int ConsolidationDay
        {
            get
            {
                return this._ConsolidationDay;
            }
            set
            {
                this.OnConsolidationDayChanging(value);
                this._ConsolidationDay = value;
                this.OnConsolidationDayChanged();
                this.OnPropertyChanged("ConsolidationDay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private int _ConsolidationDay;
        partial void OnConsolidationDayChanging(int value);
        partial void OnConsolidationDayChanged();
        /// <summary>
        /// There are no comments for Property EnterpriseCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EnterpriseCode")]
        public string EnterpriseCode
        {
            get
            {
                return this._EnterpriseCode;
            }
            set
            {
                this.OnEnterpriseCodeChanging(value);
                this._EnterpriseCode = value;
                this.OnEnterpriseCodeChanged();
                this.OnPropertyChanged("EnterpriseCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _EnterpriseCode;
        partial void OnEnterpriseCodeChanging(string value);
        partial void OnEnterpriseCodeChanged();
        /// <summary>
        /// There are no comments for Property DeliveryTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DeliveryTerms")]
        public string DeliveryTerms
        {
            get
            {
                return this._DeliveryTerms;
            }
            set
            {
                this.OnDeliveryTermsChanging(value);
                this._DeliveryTerms = value;
                this.OnDeliveryTermsChanged();
                this.OnPropertyChanged("DeliveryTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _DeliveryTerms;
        partial void OnDeliveryTermsChanging(string value);
        partial void OnDeliveryTermsChanged();
        /// <summary>
        /// There are no comments for Property AccountStatement in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property PaymentIdType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentIdType")]
        public string PaymentIdType
        {
            get
            {
                return this._PaymentIdType;
            }
            set
            {
                this.OnPaymentIdTypeChanging(value);
                this._PaymentIdType = value;
                this.OnPaymentIdTypeChanged();
                this.OnPropertyChanged("PaymentIdType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        private string _PaymentIdType;
        partial void OnPaymentIdTypeChanging(string value);
        partial void OnPaymentIdTypeChanged();
        /// <summary>
        /// There are no comments for Property RetailCallCenter in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property FreeTextInvoiceHeaderInvoiceAccount in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property FreeTextInvoiceHeaderCustAccount in the schema.
        /// </summary>

        /// <summary>
        /// There are no comments for Property OnlineChannel in the schema.
        /// </summary>

        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }






    }
}