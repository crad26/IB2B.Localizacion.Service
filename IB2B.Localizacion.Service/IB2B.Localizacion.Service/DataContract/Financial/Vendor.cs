using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IB2B.Localizacion.Service.DataContract.Financial
{
   
        [global::Microsoft.OData.Client.Key("VendorAccountNumber", "dataAreaId")]
        [global::Microsoft.OData.Client.EntitySet("Vendors")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Vendor")]
        public partial class Vendor : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Create a new Vendor object.
            /// </summary>
            /// <param name="personBirthYear">Initial value of PersonBirthYear.</param>
            /// <param name="addressLatitude">Initial value of AddressLatitude.</param>
            /// <param name="personAnniversaryDay">Initial value of PersonAnniversaryDay.</param>
            /// <param name="purchaseOrderConsolidationDayOfMonth">Initial value of PurchaseOrderConsolidationDayOfMonth.</param>
            /// <param name="vendorAccountNumber">Initial value of VendorAccountNumber.</param>
            /// <param name="addressValidTo">Initial value of AddressValidTo.</param>
            /// <param name="dataAreaId">Initial value of DataAreaId.</param>
            /// <param name="creditLimit">Initial value of CreditLimit.</param>
            /// <param name="cISVerificationDate">Initial value of CISVerificationDate.</param>
            /// <param name="personAnniversaryYear">Initial value of PersonAnniversaryYear.</param>
            /// <param name="addressValidFrom">Initial value of AddressValidFrom.</param>
            /// <param name="organizationEmployeeAmount">Initial value of OrganizationEmployeeAmount.</param>
            /// <param name="sSIValidityDate">Initial value of SSIValidityDate.</param>
            /// <param name="vendorHoldReleaseDate">Initial value of VendorHoldReleaseDate.</param>
            /// <param name="personBirthDay">Initial value of PersonBirthDay.</param>
            /// <param name="addressLongitude">Initial value of AddressLongitude.</param>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            public static Vendor CreateVendor(int personBirthYear,
                        decimal addressLatitude,
                        int personAnniversaryDay,
                        int purchaseOrderConsolidationDayOfMonth,
                        string vendorAccountNumber,
                        global::System.DateTimeOffset addressValidTo,
                        string dataAreaId,
                        decimal creditLimit,
                        global::System.DateTimeOffset cISVerificationDate,
                        int personAnniversaryYear,
                        global::System.DateTimeOffset addressValidFrom,
                        int organizationEmployeeAmount,
                        global::System.DateTimeOffset sSIValidityDate,
                        global::System.DateTimeOffset vendorHoldReleaseDate,
                        int personBirthDay,
                        decimal addressLongitude)
            {
                Vendor vendor = new Vendor();
                vendor.PersonBirthYear = personBirthYear;
                vendor.AddressLatitude = addressLatitude;
                vendor.PersonAnniversaryDay = personAnniversaryDay;
                vendor.PurchaseOrderConsolidationDayOfMonth = purchaseOrderConsolidationDayOfMonth;
                vendor.VendorAccountNumber = vendorAccountNumber;
                vendor.AddressValidTo = addressValidTo;
                vendor.DataAreaId = dataAreaId;
                vendor.CreditLimit = creditLimit;
                vendor.CISVerificationDate = cISVerificationDate;
                vendor.PersonAnniversaryYear = personAnniversaryYear;
                vendor.AddressValidFrom = addressValidFrom;
                vendor.OrganizationEmployeeAmount = organizationEmployeeAmount;
                vendor.SSIValidityDate = sSIValidityDate;
                vendor.VendorHoldReleaseDate = vendorHoldReleaseDate;
                vendor.PersonBirthDay = personBirthDay;
                vendor.AddressLongitude = addressLongitude;
                return vendor;
            }
            /// <summary>
            /// There are no comments for Property OIDNomineeDetails in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("OIDNomineeDetails")]
            public string OIDNomineeDetails
            {
                get
                {
                    return this._OIDNomineeDetails;
                }
                set
                {
                    this.OnOIDNomineeDetailsChanging(value);
                    this._OIDNomineeDetails = value;
                    this.OnOIDNomineeDetailsChanged();
                    this.OnPropertyChanged("OIDNomineeDetails");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _OIDNomineeDetails;
            partial void OnOIDNomineeDetailsChanging(string value);
            partial void OnOIDNomineeDetailsChanged();
            /// <summary>
            /// There are no comments for Property PaymentFeeGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentFeeGroupId")]
            public string PaymentFeeGroupId
            {
                get
                {
                    return this._PaymentFeeGroupId;
                }
                set
                {
                    this.OnPaymentFeeGroupIdChanging(value);
                    this._PaymentFeeGroupId = value;
                    this.OnPaymentFeeGroupIdChanged();
                    this.OnPropertyChanged("PaymentFeeGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PaymentFeeGroupId;
            partial void OnPaymentFeeGroupIdChanging(string value);
            partial void OnPaymentFeeGroupIdChanged();
            /// <summary>
            /// There are no comments for Property PaymentId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentId")]
            public string PaymentId
            {
                get
                {
                    return this._PaymentId;
                }
                set
                {
                    this.OnPaymentIdChanging(value);
                    this._PaymentId = value;
                    this.OnPaymentIdChanged();
                    this.OnPropertyChanged("PaymentId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PaymentId;
            partial void OnPaymentIdChanging(string value);
            partial void OnPaymentIdChanged();
            /// <summary>
            /// There are no comments for Property VendorInvoiceDeclarationId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorInvoiceDeclarationId")]
            public string VendorInvoiceDeclarationId
            {
                get
                {
                    return this._VendorInvoiceDeclarationId;
                }
                set
                {
                    this.OnVendorInvoiceDeclarationIdChanging(value);
                    this._VendorInvoiceDeclarationId = value;
                    this.OnVendorInvoiceDeclarationIdChanged();
                    this.OnPropertyChanged("VendorInvoiceDeclarationId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorInvoiceDeclarationId;
            partial void OnVendorInvoiceDeclarationIdChanging(string value);
            partial void OnVendorInvoiceDeclarationIdChanged();
            /// <summary>
            /// There are no comments for Property AddressStateId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("AddressStateId")]
            public string AddressStateId
            {
                get
                {
                    return this._AddressStateId;
                }
                set
                {
                    this.OnAddressStateIdChanging(value);
                    this._AddressStateId = value;
                    this.OnAddressStateIdChanged();
                    this.OnPropertyChanged("AddressStateId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _AddressStateId;
            partial void OnAddressStateIdChanging(string value);
            partial void OnAddressStateIdChanged();
            /// <summary>
            /// There are no comments for Property DefaultPaymentDayName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultPaymentDayName")]
            public string DefaultPaymentDayName
            {
                get
                {
                    return this._DefaultPaymentDayName;
                }
                set
                {
                    this.OnDefaultPaymentDayNameChanging(value);
                    this._DefaultPaymentDayName = value;
                    this.OnDefaultPaymentDayNameChanged();
                    this.OnPropertyChanged("DefaultPaymentDayName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultPaymentDayName;
            partial void OnDefaultPaymentDayNameChanging(string value);
            partial void OnDefaultPaymentDayNameChanged();
            /// <summary>
            /// There are no comments for Property VendorName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorName")]
            public string VendorName
            {
                get
                {
                    return this._VendorName;
                }
                set
                {
                    this.OnVendorNameChanging(value);
                    this._VendorName = value;
                    this.OnVendorNameChanged();
                    this.OnPropertyChanged("VendorName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorName;
            partial void OnVendorNameChanging(string value);
            partial void OnVendorNameChanged();
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
            /// There are no comments for Property PurchaseWorkCalendarId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseWorkCalendarId")]
            public string PurchaseWorkCalendarId
            {
                get
                {
                    return this._PurchaseWorkCalendarId;
                }
                set
                {
                    this.OnPurchaseWorkCalendarIdChanging(value);
                    this._PurchaseWorkCalendarId = value;
                    this.OnPurchaseWorkCalendarIdChanged();
                    this.OnPropertyChanged("PurchaseWorkCalendarId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PurchaseWorkCalendarId;
            partial void OnPurchaseWorkCalendarIdChanging(string value);
            partial void OnPurchaseWorkCalendarIdChanged();
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
            /// There are no comments for Property IsMinorityOwned in the schema.
            /// </summary>
           
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorExceptionGroupId")]
            public string VendorExceptionGroupId
            {
                get
                {
                    return this._VendorExceptionGroupId;
                }
                set
                {
                    this.OnVendorExceptionGroupIdChanging(value);
                    this._VendorExceptionGroupId = value;
                    this.OnVendorExceptionGroupIdChanged();
                    this.OnPropertyChanged("VendorExceptionGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorExceptionGroupId;
            partial void OnVendorExceptionGroupIdChanging(string value);
            partial void OnVendorExceptionGroupIdChanged();
            /// <summary>
            /// There are no comments for Property PersonBirthYear in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PersonBirthYear")]
            public int PersonBirthYear
            {
                get
                {
                    return this._PersonBirthYear;
                }
                set
                {
                    this.OnPersonBirthYearChanging(value);
                    this._PersonBirthYear = value;
                    this.OnPersonBirthYearChanged();
                    this.OnPropertyChanged("PersonBirthYear");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private int _PersonBirthYear;
            partial void OnPersonBirthYearChanging(int value);
            partial void OnPersonBirthYearChanged();
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
            /// There are no comments for Property DefaultPurchaseOrderPoolId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultPurchaseOrderPoolId")]
            public string DefaultPurchaseOrderPoolId
            {
                get
                {
                    return this._DefaultPurchaseOrderPoolId;
                }
                set
                {
                    this.OnDefaultPurchaseOrderPoolIdChanging(value);
                    this._DefaultPurchaseOrderPoolId = value;
                    this.OnDefaultPurchaseOrderPoolIdChanged();
                    this.OnPropertyChanged("DefaultPurchaseOrderPoolId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultPurchaseOrderPoolId;
            partial void OnDefaultPurchaseOrderPoolIdChanging(string value);
            partial void OnDefaultPurchaseOrderPoolIdChanged();
            /// <summary>
            /// There are no comments for Property IsChangeMangementOverrideByVendorAllowed in the schema.
            /// </summary>
            
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
            /// There are no comments for Property IsVendorLocatedInHUBZone in the schema.
            /// </summary>
           
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
            /// There are no comments for Property MainContactPersonnelNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("MainContactPersonnelNumber")]
            public string MainContactPersonnelNumber
            {
                get
                {
                    return this._MainContactPersonnelNumber;
                }
                set
                {
                    this.OnMainContactPersonnelNumberChanging(value);
                    this._MainContactPersonnelNumber = value;
                    this.OnMainContactPersonnelNumberChanged();
                    this.OnPropertyChanged("MainContactPersonnelNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _MainContactPersonnelNumber;
            partial void OnMainContactPersonnelNumberChanging(string value);
            partial void OnMainContactPersonnelNumberChanged();
            /// <summary>
            /// There are no comments for Property SiretNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("SiretNumber")]
            public string SiretNumber
            {
                get
                {
                    return this._SiretNumber;
                }
                set
                {
                    this.OnSiretNumberChanging(value);
                    this._SiretNumber = value;
                    this.OnSiretNumberChanged();
                    this.OnPropertyChanged("SiretNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _SiretNumber;
            partial void OnSiretNumberChanging(string value);
            partial void OnSiretNumberChanged();
            /// <summary>
            /// There are no comments for Property IsIncomingFiscalDocumentGenerated in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property PersonPersonalSuffix in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PersonPersonalSuffix")]
            public string PersonPersonalSuffix
            {
                get
                {
                    return this._PersonPersonalSuffix;
                }
                set
                {
                    this.OnPersonPersonalSuffixChanging(value);
                    this._PersonPersonalSuffix = value;
                    this.OnPersonPersonalSuffixChanged();
                    this.OnPropertyChanged("PersonPersonalSuffix");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PersonPersonalSuffix;
            partial void OnPersonPersonalSuffixChanging(string value);
            partial void OnPersonPersonalSuffixChanged();
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
            /// There are no comments for Property IsW9Received in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property PurchaseOrderConsolidationDayOfMonth in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseOrderConsolidationDayOfMonth")]
            public int PurchaseOrderConsolidationDayOfMonth
            {
                get
                {
                    return this._PurchaseOrderConsolidationDayOfMonth;
                }
                set
                {
                    this.OnPurchaseOrderConsolidationDayOfMonthChanging(value);
                    this._PurchaseOrderConsolidationDayOfMonth = value;
                    this.OnPurchaseOrderConsolidationDayOfMonthChanged();
                    this.OnPropertyChanged("PurchaseOrderConsolidationDayOfMonth");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private int _PurchaseOrderConsolidationDayOfMonth;
            partial void OnPurchaseOrderConsolidationDayOfMonthChanging(int value);
            partial void OnPurchaseOrderConsolidationDayOfMonthChanged();
            /// <summary>
            /// There are no comments for Property CUSIPIdentificationNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CUSIPIdentificationNumber")]
            public string CUSIPIdentificationNumber
            {
                get
                {
                    return this._CUSIPIdentificationNumber;
                }
                set
                {
                    this.OnCUSIPIdentificationNumberChanging(value);
                    this._CUSIPIdentificationNumber = value;
                    this.OnCUSIPIdentificationNumberChanged();
                    this.OnPropertyChanged("CUSIPIdentificationNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CUSIPIdentificationNumber;
            partial void OnCUSIPIdentificationNumberChanging(string value);
            partial void OnCUSIPIdentificationNumberChanged();
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
            /// There are no comments for Property BusinessSegmentCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessSegmentCode")]
            public string BusinessSegmentCode
            {
                get
                {
                    return this._BusinessSegmentCode;
                }
                set
                {
                    this.OnBusinessSegmentCodeChanging(value);
                    this._BusinessSegmentCode = value;
                    this.OnBusinessSegmentCodeChanged();
                    this.OnPropertyChanged("BusinessSegmentCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BusinessSegmentCode;
            partial void OnBusinessSegmentCodeChanging(string value);
            partial void OnBusinessSegmentCodeChanged();
            /// <summary>
            /// There are no comments for Property DefaultTotalDiscountVendorGroupCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultTotalDiscountVendorGroupCode")]
            public string DefaultTotalDiscountVendorGroupCode
            {
                get
                {
                    return this._DefaultTotalDiscountVendorGroupCode;
                }
                set
                {
                    this.OnDefaultTotalDiscountVendorGroupCodeChanging(value);
                    this._DefaultTotalDiscountVendorGroupCode = value;
                    this.OnDefaultTotalDiscountVendorGroupCodeChanged();
                    this.OnPropertyChanged("DefaultTotalDiscountVendorGroupCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultTotalDiscountVendorGroupCode;
            partial void OnDefaultTotalDiscountVendorGroupCodeChanging(string value);
            partial void OnDefaultTotalDiscountVendorGroupCodeChanged();
            /// <summary>
            /// There are no comments for Property DefaultDeliveryModeId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultDeliveryModeId")]
            public string DefaultDeliveryModeId
            {
                get
                {
                    return this._DefaultDeliveryModeId;
                }
                set
                {
                    this.OnDefaultDeliveryModeIdChanging(value);
                    this._DefaultDeliveryModeId = value;
                    this.OnDefaultDeliveryModeIdChanged();
                    this.OnPropertyChanged("DefaultDeliveryModeId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultDeliveryModeId;
            partial void OnDefaultDeliveryModeIdChanging(string value);
            partial void OnDefaultDeliveryModeIdChanged();
            /// <summary>
            /// There are no comments for Property PrimaryPhoneNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryPhoneNumber")]
            public string PrimaryPhoneNumber
            {
                get
                {
                    return this._PrimaryPhoneNumber;
                }
                set
                {
                    this.OnPrimaryPhoneNumberChanging(value);
                    this._PrimaryPhoneNumber = value;
                    this.OnPrimaryPhoneNumberChanged();
                    this.OnPropertyChanged("PrimaryPhoneNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryPhoneNumber;
            partial void OnPrimaryPhoneNumberChanging(string value);
            partial void OnPrimaryPhoneNumberChanged();
            /// <summary>
            /// There are no comments for Property Notes in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("Notes")]
            public string Notes
            {
                get
                {
                    return this._Notes;
                }
                set
                {
                    this.OnNotesChanging(value);
                    this._Notes = value;
                    this.OnNotesChanged();
                    this.OnPropertyChanged("Notes");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _Notes;
            partial void OnNotesChanging(string value);
            partial void OnNotesChanged();
            /// <summary>
            /// There are no comments for Property PrimaryURLPurpose in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryURLPurpose")]
            public string PrimaryURLPurpose
            {
                get
                {
                    return this._PrimaryURLPurpose;
                }
                set
                {
                    this.OnPrimaryURLPurposeChanging(value);
                    this._PrimaryURLPurpose = value;
                    this.OnPrimaryURLPurposeChanged();
                    this.OnPropertyChanged("PrimaryURLPurpose");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryURLPurpose;
            partial void OnPrimaryURLPurposeChanging(string value);
            partial void OnPrimaryURLPurposeChanged();
            /// <summary>
            /// There are no comments for Property NumberSequenceGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("NumberSequenceGroupId")]
            public string NumberSequenceGroupId
            {
                get
                {
                    return this._NumberSequenceGroupId;
                }
                set
                {
                    this.OnNumberSequenceGroupIdChanging(value);
                    this._NumberSequenceGroupId = value;
                    this.OnNumberSequenceGroupIdChanged();
                    this.OnPropertyChanged("NumberSequenceGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _NumberSequenceGroupId;
            partial void OnNumberSequenceGroupIdChanging(string value);
            partial void OnNumberSequenceGroupIdChanged();
            /// <summary>
            /// There are no comments for Property ForeignVendor in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property IsServiceVeteranOwned in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property PrimaryTelexPurpose in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryTelexPurpose")]
            public string PrimaryTelexPurpose
            {
                get
                {
                    return this._PrimaryTelexPurpose;
                }
                set
                {
                    this.OnPrimaryTelexPurposeChanging(value);
                    this._PrimaryTelexPurpose = value;
                    this.OnPrimaryTelexPurposeChanged();
                    this.OnPropertyChanged("PrimaryTelexPurpose");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryTelexPurpose;
            partial void OnPrimaryTelexPurposeChanging(string value);
            partial void OnPrimaryTelexPurposeChanged();
            /// <summary>
            /// There are no comments for Property BrazilianCCM in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilianCCM")]
            public string BrazilianCCM
            {
                get
                {
                    return this._BrazilianCCM;
                }
                set
                {
                    this.OnBrazilianCCMChanging(value);
                    this._BrazilianCCM = value;
                    this.OnBrazilianCCMChanged();
                    this.OnPropertyChanged("BrazilianCCM");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BrazilianCCM;
            partial void OnBrazilianCCMChanging(string value);
            partial void OnBrazilianCCMChanged();
            /// <summary>
            /// There are no comments for Property CISStatus in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property VendorInvoiceLineMatchingPolicy in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property VendorPriceToleranceGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPriceToleranceGroupId")]
            public string VendorPriceToleranceGroupId
            {
                get
                {
                    return this._VendorPriceToleranceGroupId;
                }
                set
                {
                    this.OnVendorPriceToleranceGroupIdChanging(value);
                    this._VendorPriceToleranceGroupId = value;
                    this.OnVendorPriceToleranceGroupIdChanged();
                    this.OnPropertyChanged("VendorPriceToleranceGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorPriceToleranceGroupId;
            partial void OnVendorPriceToleranceGroupIdChanging(string value);
            partial void OnVendorPriceToleranceGroupIdChanged();
            /// <summary>
            /// There are no comments for Property IsICMSContributor in the schema.
            /// </summary>
            
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
            /// There are no comments for Property Tax1099NameToUse in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property CompositionScheme in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property VendorPortalAdministratorContactPersonId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPortalAdministratorContactPersonId")]
            public string VendorPortalAdministratorContactPersonId
            {
                get
                {
                    return this._VendorPortalAdministratorContactPersonId;
                }
                set
                {
                    this.OnVendorPortalAdministratorContactPersonIdChanging(value);
                    this._VendorPortalAdministratorContactPersonId = value;
                    this.OnVendorPortalAdministratorContactPersonIdChanged();
                    this.OnPropertyChanged("VendorPortalAdministratorContactPersonId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorPortalAdministratorContactPersonId;
            partial void OnVendorPortalAdministratorContactPersonIdChanging(string value);
            partial void OnVendorPortalAdministratorContactPersonIdChanged();
            /// <summary>
            /// There are no comments for Property Tax1099Type in the schema.
            /// </summary>
            
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
            /// There are no comments for Property PersonAnniversaryMonth in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property MultilineDiscountVendorGroupCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("MultilineDiscountVendorGroupCode")]
            public string MultilineDiscountVendorGroupCode
            {
                get
                {
                    return this._MultilineDiscountVendorGroupCode;
                }
                set
                {
                    this.OnMultilineDiscountVendorGroupCodeChanging(value);
                    this._MultilineDiscountVendorGroupCode = value;
                    this.OnMultilineDiscountVendorGroupCodeChanged();
                    this.OnPropertyChanged("MultilineDiscountVendorGroupCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _MultilineDiscountVendorGroupCode;
            partial void OnMultilineDiscountVendorGroupCodeChanging(string value);
            partial void OnMultilineDiscountVendorGroupCodeChanged();
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
            /// There are no comments for Property PurchaseRebateVendorGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PurchaseRebateVendorGroupId")]
            public string PurchaseRebateVendorGroupId
            {
                get
                {
                    return this._PurchaseRebateVendorGroupId;
                }
                set
                {
                    this.OnPurchaseRebateVendorGroupIdChanging(value);
                    this._PurchaseRebateVendorGroupId = value;
                    this.OnPurchaseRebateVendorGroupIdChanged();
                    this.OnPropertyChanged("PurchaseRebateVendorGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PurchaseRebateVendorGroupId;
            partial void OnPurchaseRebateVendorGroupIdChanging(string value);
            partial void OnPurchaseRebateVendorGroupIdChanged();
            /// <summary>
            /// There are no comments for Property IsSmallBusiness in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property CompanyChainName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CompanyChainName")]
            public string CompanyChainName
            {
                get
                {
                    return this._CompanyChainName;
                }
                set
                {
                    this.OnCompanyChainNameChanging(value);
                    this._CompanyChainName = value;
                    this.OnCompanyChainNameChanged();
                    this.OnPropertyChanged("CompanyChainName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CompanyChainName;
            partial void OnCompanyChainNameChanging(string value);
            partial void OnCompanyChainNameChanged();
            /// <summary>
            /// There are no comments for Property PersonGender in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property IsVendorPayingBankPaymentFee in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property ChargeVendorGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("ChargeVendorGroupId")]
            public string ChargeVendorGroupId
            {
                get
                {
                    return this._ChargeVendorGroupId;
                }
                set
                {
                    this.OnChargeVendorGroupIdChanging(value);
                    this._ChargeVendorGroupId = value;
                    this.OnChargeVendorGroupIdChanged();
                    this.OnPropertyChanged("ChargeVendorGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _ChargeVendorGroupId;
            partial void OnChargeVendorGroupIdChanging(string value);
            partial void OnChargeVendorGroupIdChanged();
            /// <summary>
            /// There are no comments for Property VendorAccountNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorAccountNumber")]
            public string VendorAccountNumber
            {
                get
                {
                    return this._VendorAccountNumber;
                }
                set
                {
                    this.OnVendorAccountNumberChanging(value);
                    this._VendorAccountNumber = value;
                    this.OnVendorAccountNumberChanged();
                    this.OnPropertyChanged("VendorAccountNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorAccountNumber;
            partial void OnVendorAccountNumberChanging(string value);
            partial void OnVendorAccountNumberChanged();
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
            /// There are no comments for Property IsVendorLocallyOwned in the schema.
            /// </summary>
           
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
            /// There are no comments for Property AddressCountyId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("AddressCountyId")]
            public string AddressCountyId
            {
                get
                {
                    return this._AddressCountyId;
                }
                set
                {
                    this.OnAddressCountyIdChanging(value);
                    this._AddressCountyId = value;
                    this.OnAddressCountyIdChanged();
                    this.OnPropertyChanged("AddressCountyId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _AddressCountyId;
            partial void OnAddressCountyIdChanging(string value);
            partial void OnAddressCountyIdChanged();
            /// <summary>
            /// There are no comments for Property PrimaryEmailAddressPurpose in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryEmailAddressPurpose")]
            public string PrimaryEmailAddressPurpose
            {
                get
                {
                    return this._PrimaryEmailAddressPurpose;
                }
                set
                {
                    this.OnPrimaryEmailAddressPurposeChanging(value);
                    this._PrimaryEmailAddressPurpose = value;
                    this.OnPrimaryEmailAddressPurposeChanged();
                    this.OnPropertyChanged("PrimaryEmailAddressPurpose");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryEmailAddressPurpose;
            partial void OnPrimaryEmailAddressPurposeChanging(string value);
            partial void OnPrimaryEmailAddressPurposeChanged();
            /// <summary>
            /// There are no comments for Property CommercialRegisterInsetNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CommercialRegisterInsetNumber")]
            public string CommercialRegisterInsetNumber
            {
                get
                {
                    return this._CommercialRegisterInsetNumber;
                }
                set
                {
                    this.OnCommercialRegisterInsetNumberChanging(value);
                    this._CommercialRegisterInsetNumber = value;
                    this.OnCommercialRegisterInsetNumberChanged();
                    this.OnPropertyChanged("CommercialRegisterInsetNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CommercialRegisterInsetNumber;
            partial void OnCommercialRegisterInsetNumberChanging(string value);
            partial void OnCommercialRegisterInsetNumberChanged();
            /// <summary>
            /// There are no comments for Property DefaultOffsetAccountType in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property FiscalOperationPresenceType in the schema.
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
            /// There are no comments for Property ForeignerId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("ForeignerId")]
            public string ForeignerId
            {
                get
                {
                    return this._ForeignerId;
                }
                set
                {
                    this.OnForeignerIdChanging(value);
                    this._ForeignerId = value;
                    this.OnForeignerIdChanged();
                    this.OnPropertyChanged("ForeignerId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _ForeignerId;
            partial void OnForeignerIdChanging(string value);
            partial void OnForeignerIdChanged();
            /// <summary>
            /// There are no comments for Property AddressTimeZone in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property ForeignVendorTaxRegistrationId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("ForeignVendorTaxRegistrationId")]
            public string ForeignVendorTaxRegistrationId
            {
                get
                {
                    return this._ForeignVendorTaxRegistrationId;
                }
                set
                {
                    this.OnForeignVendorTaxRegistrationIdChanging(value);
                    this._ForeignVendorTaxRegistrationId = value;
                    this.OnForeignVendorTaxRegistrationIdChanged();
                    this.OnPropertyChanged("ForeignVendorTaxRegistrationId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _ForeignVendorTaxRegistrationId;
            partial void OnForeignVendorTaxRegistrationIdChanging(string value);
            partial void OnForeignVendorTaxRegistrationIdChanged();
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
            /// There are no comments for Property CompanyRegistrationNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CompanyRegistrationNumber")]
            public string CompanyRegistrationNumber
            {
                get
                {
                    return this._CompanyRegistrationNumber;
                }
                set
                {
                    this.OnCompanyRegistrationNumberChanging(value);
                    this._CompanyRegistrationNumber = value;
                    this.OnCompanyRegistrationNumberChanged();
                    this.OnPropertyChanged("CompanyRegistrationNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CompanyRegistrationNumber;
            partial void OnCompanyRegistrationNumberChanging(string value);
            partial void OnCompanyRegistrationNumberChanged();
            /// <summary>
            /// There are no comments for Property CommercialRegisterName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CommercialRegisterName")]
            public string CommercialRegisterName
            {
                get
                {
                    return this._CommercialRegisterName;
                }
                set
                {
                    this.OnCommercialRegisterNameChanging(value);
                    this._CommercialRegisterName = value;
                    this.OnCommercialRegisterNameChanged();
                    this.OnPropertyChanged("CommercialRegisterName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CommercialRegisterName;
            partial void OnCommercialRegisterNameChanging(string value);
            partial void OnCommercialRegisterNameChanged();
            /// <summary>
            /// There are no comments for Property RFCFederalTaxNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("RFCFederalTaxNumber")]
            public string RFCFederalTaxNumber
            {
                get
                {
                    return this._RFCFederalTaxNumber;
                }
                set
                {
                    this.OnRFCFederalTaxNumberChanging(value);
                    this._RFCFederalTaxNumber = value;
                    this.OnRFCFederalTaxNumberChanged();
                    this.OnPropertyChanged("RFCFederalTaxNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _RFCFederalTaxNumber;
            partial void OnRFCFederalTaxNumberChanging(string value);
            partial void OnRFCFederalTaxNumberChanged();
            /// <summary>
            /// There are no comments for Property CUSIPDetails in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CUSIPDetails")]
            public string CUSIPDetails
            {
                get
                {
                    return this._CUSIPDetails;
                }
                set
                {
                    this.OnCUSIPDetailsChanging(value);
                    this._CUSIPDetails = value;
                    this.OnCUSIPDetailsChanged();
                    this.OnPropertyChanged("CUSIPDetails");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CUSIPDetails;
            partial void OnCUSIPDetailsChanging(string value);
            partial void OnCUSIPDetailsChanged();
            /// <summary>
            /// There are no comments for Property PaymentTransactionCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTransactionCode")]
            public string PaymentTransactionCode
            {
                get
                {
                    return this._PaymentTransactionCode;
                }
                set
                {
                    this.OnPaymentTransactionCodeChanging(value);
                    this._PaymentTransactionCode = value;
                    this.OnPaymentTransactionCodeChanged();
                    this.OnPropertyChanged("PaymentTransactionCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PaymentTransactionCode;
            partial void OnPaymentTransactionCodeChanging(string value);
            partial void OnPaymentTransactionCodeChanged();
            /// <summary>
            /// There are no comments for Property IsPurchaseOrderChangeRequestOverrideAllowed in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property OurAccountNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("OurAccountNumber")]
            public string OurAccountNumber
            {
                get
                {
                    return this._OurAccountNumber;
                }
                set
                {
                    this.OnOurAccountNumberChanging(value);
                    this._OurAccountNumber = value;
                    this.OnOurAccountNumberChanged();
                    this.OnPropertyChanged("OurAccountNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _OurAccountNumber;
            partial void OnOurAccountNumberChanging(string value);
            partial void OnOurAccountNumberChanged();
            /// <summary>
            /// There are no comments for Property FormattedPrimaryAddress in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("FormattedPrimaryAddress")]
            public string FormattedPrimaryAddress
            {
                get
                {
                    return this._FormattedPrimaryAddress;
                }
                set
                {
                    this.OnFormattedPrimaryAddressChanging(value);
                    this._FormattedPrimaryAddress = value;
                    this.OnFormattedPrimaryAddressChanged();
                    this.OnPropertyChanged("FormattedPrimaryAddress");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _FormattedPrimaryAddress;
            partial void OnFormattedPrimaryAddressChanging(string value);
            partial void OnFormattedPrimaryAddressChanged();
            /// <summary>
            /// There are no comments for Property Tax1099BoxId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("Tax1099BoxId")]
            public string Tax1099BoxId
            {
                get
                {
                    return this._Tax1099BoxId;
                }
                set
                {
                    this.OnTax1099BoxIdChanging(value);
                    this._Tax1099BoxId = value;
                    this.OnTax1099BoxIdChanged();
                    this.OnPropertyChanged("Tax1099BoxId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _Tax1099BoxId;
            partial void OnTax1099BoxIdChanging(string value);
            partial void OnTax1099BoxIdChanged();
            /// <summary>
            /// There are no comments for Property CISCompanyRegistrationNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CISCompanyRegistrationNumber")]
            public string CISCompanyRegistrationNumber
            {
                get
                {
                    return this._CISCompanyRegistrationNumber;
                }
                set
                {
                    this.OnCISCompanyRegistrationNumberChanging(value);
                    this._CISCompanyRegistrationNumber = value;
                    this.OnCISCompanyRegistrationNumberChanged();
                    this.OnPropertyChanged("CISCompanyRegistrationNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CISCompanyRegistrationNumber;
            partial void OnCISCompanyRegistrationNumberChanging(string value);
            partial void OnCISCompanyRegistrationNumberChanged();
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
            /// There are no comments for Property DefaultDeliveryTermsCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultDeliveryTermsCode")]
            public string DefaultDeliveryTermsCode
            {
                get
                {
                    return this._DefaultDeliveryTermsCode;
                }
                set
                {
                    this.OnDefaultDeliveryTermsCodeChanging(value);
                    this._DefaultDeliveryTermsCode = value;
                    this.OnDefaultDeliveryTermsCodeChanged();
                    this.OnPropertyChanged("DefaultDeliveryTermsCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultDeliveryTermsCode;
            partial void OnDefaultDeliveryTermsCodeChanging(string value);
            partial void OnDefaultDeliveryTermsCodeChanged();
            /// <summary>
            /// There are no comments for Property BusinessSubsegmentCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessSubsegmentCode")]
            public string BusinessSubsegmentCode
            {
                get
                {
                    return this._BusinessSubsegmentCode;
                }
                set
                {
                    this.OnBusinessSubsegmentCodeChanging(value);
                    this._BusinessSubsegmentCode = value;
                    this.OnBusinessSubsegmentCodeChanged();
                    this.OnPropertyChanged("BusinessSubsegmentCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BusinessSubsegmentCode;
            partial void OnBusinessSubsegmentCodeChanging(string value);
            partial void OnBusinessSubsegmentCodeChanged();
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
            /// There are no comments for Property CISUniqueTaxPayerReference in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CISUniqueTaxPayerReference")]
            public string CISUniqueTaxPayerReference
            {
                get
                {
                    return this._CISUniqueTaxPayerReference;
                }
                set
                {
                    this.OnCISUniqueTaxPayerReferenceChanging(value);
                    this._CISUniqueTaxPayerReference = value;
                    this.OnCISUniqueTaxPayerReferenceChanged();
                    this.OnPropertyChanged("CISUniqueTaxPayerReference");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CISUniqueTaxPayerReference;
            partial void OnCISUniqueTaxPayerReferenceChanging(string value);
            partial void OnCISUniqueTaxPayerReferenceChanged();
            /// <summary>
            /// There are no comments for Property PrimaryTelex in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryTelex")]
            public string PrimaryTelex
            {
                get
                {
                    return this._PrimaryTelex;
                }
                set
                {
                    this.OnPrimaryTelexChanging(value);
                    this._PrimaryTelex = value;
                    this.OnPrimaryTelexChanged();
                    this.OnPropertyChanged("PrimaryTelex");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryTelex;
            partial void OnPrimaryTelexChanging(string value);
            partial void OnPrimaryTelexChanged();
            /// <summary>
            /// There are no comments for Property HasOnlyTakenBids in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property CISVerificationDate in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CISVerificationDate")]
            public global::System.DateTimeOffset CISVerificationDate
            {
                get
                {
                    return this._CISVerificationDate;
                }
                set
                {
                    this.OnCISVerificationDateChanging(value);
                    this._CISVerificationDate = value;
                    this.OnCISVerificationDateChanged();
                    this.OnPropertyChanged("CISVerificationDate");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private global::System.DateTimeOffset _CISVerificationDate;
            partial void OnCISVerificationDateChanging(global::System.DateTimeOffset value);
            partial void OnCISVerificationDateChanged();
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
            /// There are no comments for Property BrazilianINSSCEI in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilianINSSCEI")]
            public string BrazilianINSSCEI
            {
                get
                {
                    return this._BrazilianINSSCEI;
                }
                set
                {
                    this.OnBrazilianINSSCEIChanging(value);
                    this._BrazilianINSSCEI = value;
                    this.OnBrazilianINSSCEIChanged();
                    this.OnPropertyChanged("BrazilianINSSCEI");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BrazilianINSSCEI;
            partial void OnBrazilianINSSCEIChanging(string value);
            partial void OnBrazilianINSSCEIChanged();
            /// <summary>
            /// There are no comments for Property OIDInvestorType in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property VendorGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorGroupId")]
            public string VendorGroupId
            {
                get
                {
                    return this._VendorGroupId;
                }
                set
                {
                    this.OnVendorGroupIdChanging(value);
                    this._VendorGroupId = value;
                    this.OnVendorGroupIdChanged();
                    this.OnPropertyChanged("VendorGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorGroupId;
            partial void OnVendorGroupIdChanging(string value);
            partial void OnVendorGroupIdChanged();
            /// <summary>
            /// There are no comments for Property PrimaryFaxNumberPurpose in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryFaxNumberPurpose")]
            public string PrimaryFaxNumberPurpose
            {
                get
                {
                    return this._PrimaryFaxNumberPurpose;
                }
                set
                {
                    this.OnPrimaryFaxNumberPurposeChanging(value);
                    this._PrimaryFaxNumberPurpose = value;
                    this.OnPrimaryFaxNumberPurposeChanged();
                    this.OnPropertyChanged("PrimaryFaxNumberPurpose");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryFaxNumberPurpose;
            partial void OnPrimaryFaxNumberPurposeChanging(string value);
            partial void OnPrimaryFaxNumberPurposeChanged();
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
            /// There are no comments for Property BuyerGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BuyerGroupId")]
            public string BuyerGroupId
            {
                get
                {
                    return this._BuyerGroupId;
                }
                set
                {
                    this.OnBuyerGroupIdChanging(value);
                    this._BuyerGroupId = value;
                    this.OnBuyerGroupIdChanged();
                    this.OnPropertyChanged("BuyerGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BuyerGroupId;
            partial void OnBuyerGroupIdChanging(string value);
            partial void OnBuyerGroupIdChanged();
            /// <summary>
            /// There are no comments for Property BankAccountId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BankAccountId")]
            public string BankAccountId
            {
                get
                {
                    return this._BankAccountId;
                }
                set
                {
                    this.OnBankAccountIdChanging(value);
                    this._BankAccountId = value;
                    this.OnBankAccountIdChanged();
                    this.OnPropertyChanged("BankAccountId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BankAccountId;
            partial void OnBankAccountIdChanging(string value);
            partial void OnBankAccountIdChanged();
            /// <summary>
            /// There are no comments for Property UniquePopulationRegistryCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("UniquePopulationRegistryCode")]
            public string UniquePopulationRegistryCode
            {
                get
                {
                    return this._UniquePopulationRegistryCode;
                }
                set
                {
                    this.OnUniquePopulationRegistryCodeChanging(value);
                    this._UniquePopulationRegistryCode = value;
                    this.OnUniquePopulationRegistryCodeChanged();
                    this.OnPropertyChanged("UniquePopulationRegistryCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _UniquePopulationRegistryCode;
            partial void OnUniquePopulationRegistryCodeChanging(string value);
            partial void OnUniquePopulationRegistryCodeChanged();
            /// <summary>
            /// There are no comments for Property FactoringVendorAccountNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("FactoringVendorAccountNumber")]
            public string FactoringVendorAccountNumber
            {
                get
                {
                    return this._FactoringVendorAccountNumber;
                }
                set
                {
                    this.OnFactoringVendorAccountNumberChanging(value);
                    this._FactoringVendorAccountNumber = value;
                    this.OnFactoringVendorAccountNumberChanged();
                    this.OnPropertyChanged("FactoringVendorAccountNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _FactoringVendorAccountNumber;
            partial void OnFactoringVendorAccountNumberChanging(string value);
            partial void OnFactoringVendorAccountNumberChanged();
            /// <summary>
            /// There are no comments for Property CashDiscountCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CashDiscountCode")]
            public string CashDiscountCode
            {
                get
                {
                    return this._CashDiscountCode;
                }
                set
                {
                    this.OnCashDiscountCodeChanging(value);
                    this._CashDiscountCode = value;
                    this.OnCashDiscountCodeChanged();
                    this.OnPropertyChanged("CashDiscountCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CashDiscountCode;
            partial void OnCashDiscountCodeChanging(string value);
            partial void OnCashDiscountCodeChanged();
            /// <summary>
            /// There are no comments for Property VendorPartyType in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPartyType")]
            public string VendorPartyType
            {
                get
                {
                    return this._VendorPartyType;
                }
                set
                {
                    this.OnVendorPartyTypeChanging(value);
                    this._VendorPartyType = value;
                    this.OnVendorPartyTypeChanged();
                    this.OnPropertyChanged("VendorPartyType");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorPartyType;
            partial void OnVendorPartyTypeChanging(string value);
            partial void OnVendorPartyTypeChanged();
            /// <summary>
            /// There are no comments for Property IsPrimaryPhoneNumberMobile in the schema.
            /// </summary>
           
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
            /// There are no comments for Property CISVerificationNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CISVerificationNumber")]
            public string CISVerificationNumber
            {
                get
                {
                    return this._CISVerificationNumber;
                }
                set
                {
                    this.OnCISVerificationNumberChanging(value);
                    this._CISVerificationNumber = value;
                    this.OnCISVerificationNumberChanged();
                    this.OnPropertyChanged("CISVerificationNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CISVerificationNumber;
            partial void OnCISVerificationNumberChanging(string value);
            partial void OnCISVerificationNumberChanged();
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
            /// There are no comments for Property DefaultPaymentScheduleName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultPaymentScheduleName")]
            public string DefaultPaymentScheduleName
            {
                get
                {
                    return this._DefaultPaymentScheduleName;
                }
                set
                {
                    this.OnDefaultPaymentScheduleNameChanging(value);
                    this._DefaultPaymentScheduleName = value;
                    this.OnDefaultPaymentScheduleNameChanged();
                    this.OnPropertyChanged("DefaultPaymentScheduleName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultPaymentScheduleName;
            partial void OnDefaultPaymentScheduleNameChanging(string value);
            partial void OnDefaultPaymentScheduleNameChanged();
            /// <summary>
            /// There are no comments for Property CurrencyCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CurrencyCode")]
            public string CurrencyCode
            {
                get
                {
                    return this._CurrencyCode;
                }
                set
                {
                    this.OnCurrencyCodeChanging(value);
                    this._CurrencyCode = value;
                    this.OnCurrencyCodeChanged();
                    this.OnPropertyChanged("CurrencyCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CurrencyCode;
            partial void OnCurrencyCodeChanging(string value);
            partial void OnCurrencyCodeChanged();
            /// <summary>
            /// There are no comments for Property PersonBirthMonth in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property NatureOfAssessee in the schema.
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
            /// There are no comments for Property ArePricesIncludingSalesTax in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property DefaultOffsetLedgerAccountDisplayValue in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultOffsetLedgerAccountDisplayValue")]
            public string DefaultOffsetLedgerAccountDisplayValue
            {
                get
                {
                    return this._DefaultOffsetLedgerAccountDisplayValue;
                }
                set
                {
                    this.OnDefaultOffsetLedgerAccountDisplayValueChanging(value);
                    this._DefaultOffsetLedgerAccountDisplayValue = value;
                    this.OnDefaultOffsetLedgerAccountDisplayValueChanged();
                    this.OnPropertyChanged("DefaultOffsetLedgerAccountDisplayValue");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultOffsetLedgerAccountDisplayValue;
            partial void OnDefaultOffsetLedgerAccountDisplayValueChanging(string value);
            partial void OnDefaultOffsetLedgerAccountDisplayValueChanged();
            /// <summary>
            /// There are no comments for Property NationalRegistryNumberId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("NationalRegistryNumberId")]
            public string NationalRegistryNumberId
            {
                get
                {
                    return this._NationalRegistryNumberId;
                }
                set
                {
                    this.OnNationalRegistryNumberIdChanging(value);
                    this._NationalRegistryNumberId = value;
                    this.OnNationalRegistryNumberIdChanged();
                    this.OnPropertyChanged("NationalRegistryNumberId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _NationalRegistryNumberId;
            partial void OnNationalRegistryNumberIdChanging(string value);
            partial void OnNationalRegistryNumberIdChanged();
            /// <summary>
            /// There are no comments for Property CentralBankPurposeText in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CentralBankPurposeText")]
            public string CentralBankPurposeText
            {
                get
                {
                    return this._CentralBankPurposeText;
                }
                set
                {
                    this.OnCentralBankPurposeTextChanging(value);
                    this._CentralBankPurposeText = value;
                    this.OnCentralBankPurposeTextChanged();
                    this.OnPropertyChanged("CentralBankPurposeText");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CentralBankPurposeText;
            partial void OnCentralBankPurposeTextChanging(string value);
            partial void OnCentralBankPurposeTextChanged();
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
            /// There are no comments for Property Tax1099IdType in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property DefaultPaymentTermsName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultPaymentTermsName")]
            public string DefaultPaymentTermsName
            {
                get
                {
                    return this._DefaultPaymentTermsName;
                }
                set
                {
                    this.OnDefaultPaymentTermsNameChanging(value);
                    this._DefaultPaymentTermsName = value;
                    this.OnDefaultPaymentTermsNameChanged();
                    this.OnPropertyChanged("DefaultPaymentTermsName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultPaymentTermsName;
            partial void OnDefaultPaymentTermsNameChanging(string value);
            partial void OnDefaultPaymentTermsNameChanged();
            /// <summary>
            /// There are no comments for Property OrganizationEmployeeAmount in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationEmployeeAmount")]
            public int OrganizationEmployeeAmount
            {
                get
                {
                    return this._OrganizationEmployeeAmount;
                }
                set
                {
                    this.OnOrganizationEmployeeAmountChanging(value);
                    this._OrganizationEmployeeAmount = value;
                    this.OnOrganizationEmployeeAmountChanged();
                    this.OnPropertyChanged("OrganizationEmployeeAmount");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private int _OrganizationEmployeeAmount;
            partial void OnOrganizationEmployeeAmountChanging(int value);
            partial void OnOrganizationEmployeeAmountChanged();
            /// <summary>
            /// There are no comments for Property VendorPortalCollaborationMethod in the schema.
            /// </summary>
            
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
            /// There are no comments for Property InvoiceVendorAccountNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceVendorAccountNumber")]
            public string InvoiceVendorAccountNumber
            {
                get
                {
                    return this._InvoiceVendorAccountNumber;
                }
                set
                {
                    this.OnInvoiceVendorAccountNumberChanging(value);
                    this._InvoiceVendorAccountNumber = value;
                    this.OnInvoiceVendorAccountNumberChanged();
                    this.OnPropertyChanged("InvoiceVendorAccountNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _InvoiceVendorAccountNumber;
            partial void OnInvoiceVendorAccountNumberChanging(string value);
            partial void OnInvoiceVendorAccountNumberChanged();
            /// <summary>
            /// There are no comments for Property WillPurchaseOrderIncludePricesAndAmounts in the schema.
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
            /// There are no comments for Property CommercialRegisterSection in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CommercialRegisterSection")]
            public string CommercialRegisterSection
            {
                get
                {
                    return this._CommercialRegisterSection;
                }
                set
                {
                    this.OnCommercialRegisterSectionChanging(value);
                    this._CommercialRegisterSection = value;
                    this.OnCommercialRegisterSectionChanged();
                    this.OnPropertyChanged("CommercialRegisterSection");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CommercialRegisterSection;
            partial void OnCommercialRegisterSectionChanging(string value);
            partial void OnCommercialRegisterSectionChanged();
            /// <summary>
            /// There are no comments for Property SSIValidityDate in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("SSIValidityDate")]
            public global::System.DateTimeOffset SSIValidityDate
            {
                get
                {
                    return this._SSIValidityDate;
                }
                set
                {
                    this.OnSSIValidityDateChanging(value);
                    this._SSIValidityDate = value;
                    this.OnSSIValidityDateChanged();
                    this.OnPropertyChanged("SSIValidityDate");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private global::System.DateTimeOffset _SSIValidityDate;
            partial void OnSSIValidityDateChanging(global::System.DateTimeOffset value);
            partial void OnSSIValidityDateChanged();
            /// <summary>
            /// There are no comments for Property ProductDescriptionVendorGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("ProductDescriptionVendorGroupId")]
            public string ProductDescriptionVendorGroupId
            {
                get
                {
                    return this._ProductDescriptionVendorGroupId;
                }
                set
                {
                    this.OnProductDescriptionVendorGroupIdChanging(value);
                    this._ProductDescriptionVendorGroupId = value;
                    this.OnProductDescriptionVendorGroupIdChanged();
                    this.OnPropertyChanged("ProductDescriptionVendorGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _ProductDescriptionVendorGroupId;
            partial void OnProductDescriptionVendorGroupIdChanging(string value);
            partial void OnProductDescriptionVendorGroupIdChanged();
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
            /// There are no comments for Property ISNationalRegistryNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("ISNationalRegistryNumber")]
            public string ISNationalRegistryNumber
            {
                get
                {
                    return this._ISNationalRegistryNumber;
                }
                set
                {
                    this.OnISNationalRegistryNumberChanging(value);
                    this._ISNationalRegistryNumber = value;
                    this.OnISNationalRegistryNumberChanged();
                    this.OnPropertyChanged("ISNationalRegistryNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _ISNationalRegistryNumber;
            partial void OnISNationalRegistryNumberChanging(string value);
            partial void OnISNationalRegistryNumberChanged();
            /// <summary>
            /// There are no comments for Property PrimaryEmailAddress in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryEmailAddress")]
            public string PrimaryEmailAddress
            {
                get
                {
                    return this._PrimaryEmailAddress;
                }
                set
                {
                    this.OnPrimaryEmailAddressChanging(value);
                    this._PrimaryEmailAddress = value;
                    this.OnPrimaryEmailAddressChanged();
                    this.OnPropertyChanged("PrimaryEmailAddress");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryEmailAddress;
            partial void OnPrimaryEmailAddressChanging(string value);
            partial void OnPrimaryEmailAddressChanged();
            /// <summary>
            /// There are no comments for Property NameControl in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("NameControl")]
            public string NameControl
            {
                get
                {
                    return this._NameControl;
                }
                set
                {
                    this.OnNameControlChanging(value);
                    this._NameControl = value;
                    this.OnNameControlChanged();
                    this.OnPropertyChanged("NameControl");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _NameControl;
            partial void OnNameControlChanging(string value);
            partial void OnNameControlChanged();
            /// <summary>
            /// There are no comments for Property DefaultProcumentWarehouseId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultProcumentWarehouseId")]
            public string DefaultProcumentWarehouseId
            {
                get
                {
                    return this._DefaultProcumentWarehouseId;
                }
                set
                {
                    this.OnDefaultProcumentWarehouseIdChanging(value);
                    this._DefaultProcumentWarehouseId = value;
                    this.OnDefaultProcumentWarehouseIdChanged();
                    this.OnPropertyChanged("DefaultProcumentWarehouseId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultProcumentWarehouseId;
            partial void OnDefaultProcumentWarehouseIdChanging(string value);
            partial void OnDefaultProcumentWarehouseIdChanged();
            /// <summary>
            /// There are no comments for Property Nationality in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("Nationality")]
            public string Nationality
            {
                get
                {
                    return this._Nationality;
                }
                set
                {
                    this.OnNationalityChanging(value);
                    this._Nationality = value;
                    this.OnNationalityChanged();
                    this.OnPropertyChanged("Nationality");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _Nationality;
            partial void OnNationalityChanging(string value);
            partial void OnNationalityChanged();
            /// <summary>
            /// There are no comments for Property PrimaryPhoneNumberPurpose in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryPhoneNumberPurpose")]
            public string PrimaryPhoneNumberPurpose
            {
                get
                {
                    return this._PrimaryPhoneNumberPurpose;
                }
                set
                {
                    this.OnPrimaryPhoneNumberPurposeChanging(value);
                    this._PrimaryPhoneNumberPurpose = value;
                    this.OnPrimaryPhoneNumberPurposeChanged();
                    this.OnPropertyChanged("PrimaryPhoneNumberPurpose");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryPhoneNumberPurpose;
            partial void OnPrimaryPhoneNumberPurposeChanging(string value);
            partial void OnPrimaryPhoneNumberPurposeChanged();
            /// <summary>
            /// There are no comments for Property SalesTaxGroupCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxGroupCode")]
            public string SalesTaxGroupCode
            {
                get
                {
                    return this._SalesTaxGroupCode;
                }
                set
                {
                    this.OnSalesTaxGroupCodeChanging(value);
                    this._SalesTaxGroupCode = value;
                    this.OnSalesTaxGroupCodeChanged();
                    this.OnPropertyChanged("SalesTaxGroupCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _SalesTaxGroupCode;
            partial void OnSalesTaxGroupCodeChanging(string value);
            partial void OnSalesTaxGroupCodeChanged();
            /// <summary>
            /// There are no comments for Property CompanyType in the schema.
            /// </summary>
          
            /// <summary>
            /// There are no comments for Property DIOTCountryCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DIOTCountryCode")]
            public string DIOTCountryCode
            {
                get
                {
                    return this._DIOTCountryCode;
                }
                set
                {
                    this.OnDIOTCountryCodeChanging(value);
                    this._DIOTCountryCode = value;
                    this.OnDIOTCountryCodeChanged();
                    this.OnPropertyChanged("DIOTCountryCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DIOTCountryCode;
            partial void OnDIOTCountryCodeChanging(string value);
            partial void OnDIOTCountryCodeChanged();
            /// <summary>
            /// There are no comments for Property DefaultSupplementaryProductVendorGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultSupplementaryProductVendorGroupId")]
            public string DefaultSupplementaryProductVendorGroupId
            {
                get
                {
                    return this._DefaultSupplementaryProductVendorGroupId;
                }
                set
                {
                    this.OnDefaultSupplementaryProductVendorGroupIdChanging(value);
                    this._DefaultSupplementaryProductVendorGroupId = value;
                    this.OnDefaultSupplementaryProductVendorGroupIdChanged();
                    this.OnPropertyChanged("DefaultSupplementaryProductVendorGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultSupplementaryProductVendorGroupId;
            partial void OnDefaultSupplementaryProductVendorGroupIdChanging(string value);
            partial void OnDefaultSupplementaryProductVendorGroupIdChanged();
            /// <summary>
            /// There are no comments for Property PrimaryContactPersonId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryContactPersonId")]
            public string PrimaryContactPersonId
            {
                get
                {
                    return this._PrimaryContactPersonId;
                }
                set
                {
                    this.OnPrimaryContactPersonIdChanging(value);
                    this._PrimaryContactPersonId = value;
                    this.OnPrimaryContactPersonIdChanged();
                    this.OnPropertyChanged("PrimaryContactPersonId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryContactPersonId;
            partial void OnPrimaryContactPersonIdChanging(string value);
            partial void OnPrimaryContactPersonIdChanged();
            /// <summary>
            /// There are no comments for Property PersonPersonalTitle in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PersonPersonalTitle")]
            public string PersonPersonalTitle
            {
                get
                {
                    return this._PersonPersonalTitle;
                }
                set
                {
                    this.OnPersonPersonalTitleChanging(value);
                    this._PersonPersonalTitle = value;
                    this.OnPersonPersonalTitleChanged();
                    this.OnPropertyChanged("PersonPersonalTitle");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PersonPersonalTitle;
            partial void OnPersonPersonalTitleChanging(string value);
            partial void OnPersonPersonalTitleChanged();
            /// <summary>
            /// There are no comments for Property DIOTVendorType in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property DIOTOperationType in the schema.
            /// </summary>
          
           
            /// <summary>
            /// There are no comments for Property BrazilianCNAE in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilianCNAE")]
            public string BrazilianCNAE
            {
                get
                {
                    return this._BrazilianCNAE;
                }
                set
                {
                    this.OnBrazilianCNAEChanging(value);
                    this._BrazilianCNAE = value;
                    this.OnBrazilianCNAEChanged();
                    this.OnPropertyChanged("BrazilianCNAE");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BrazilianCNAE;
            partial void OnBrazilianCNAEChanging(string value);
            partial void OnBrazilianCNAEChanged();
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
            /// There are no comments for Property IsOwnerDisabled in the schema.
            /// </summary>
           
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
            /// There are no comments for Property IsFlaggedWithSecondTIN in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property VendorKnownAsName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorKnownAsName")]
            public string VendorKnownAsName
            {
                get
                {
                    return this._VendorKnownAsName;
                }
                set
                {
                    this.OnVendorKnownAsNameChanging(value);
                    this._VendorKnownAsName = value;
                    this.OnVendorKnownAsNameChanged();
                    this.OnPropertyChanged("VendorKnownAsName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorKnownAsName;
            partial void OnVendorKnownAsNameChanging(string value);
            partial void OnVendorKnownAsNameChanged();
            /// <summary>
            /// There are no comments for Property SSIVendor in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property IsForeignEntity in the schema.
            /// </summary>
           
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
            /// There are no comments for Property PaymentSpecificationId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentSpecificationId")]
            public string PaymentSpecificationId
            {
                get
                {
                    return this._PaymentSpecificationId;
                }
                set
                {
                    this.OnPaymentSpecificationIdChanging(value);
                    this._PaymentSpecificationId = value;
                    this.OnPaymentSpecificationIdChanged();
                    this.OnPropertyChanged("PaymentSpecificationId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PaymentSpecificationId;
            partial void OnPaymentSpecificationIdChanging(string value);
            partial void OnPaymentSpecificationIdChanged();
            /// <summary>
            /// There are no comments for Property DefaultVendorPaymentMethodName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultVendorPaymentMethodName")]
            public string DefaultVendorPaymentMethodName
            {
                get
                {
                    return this._DefaultVendorPaymentMethodName;
                }
                set
                {
                    this.OnDefaultVendorPaymentMethodNameChanging(value);
                    this._DefaultVendorPaymentMethodName = value;
                    this.OnDefaultVendorPaymentMethodNameChanged();
                    this.OnPropertyChanged("DefaultVendorPaymentMethodName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultVendorPaymentMethodName;
            partial void OnDefaultVendorPaymentMethodNameChanging(string value);
            partial void OnDefaultVendorPaymentMethodNameChanged();
            /// <summary>
            /// There are no comments for Property PrimaryURL in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryURL")]
            public string PrimaryURL
            {
                get
                {
                    return this._PrimaryURL;
                }
                set
                {
                    this.OnPrimaryURLChanging(value);
                    this._PrimaryURL = value;
                    this.OnPrimaryURLChanged();
                    this.OnPropertyChanged("PrimaryURL");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryURL;
            partial void OnPrimaryURLChanging(string value);
            partial void OnPrimaryURLChanged();
            /// <summary>
            /// There are no comments for Property CISNationalInsuranceNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("CISNationalInsuranceNumber")]
            public string CISNationalInsuranceNumber
            {
                get
                {
                    return this._CISNationalInsuranceNumber;
                }
                set
                {
                    this.OnCISNationalInsuranceNumberChanging(value);
                    this._CISNationalInsuranceNumber = value;
                    this.OnCISNationalInsuranceNumberChanged();
                    this.OnPropertyChanged("CISNationalInsuranceNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _CISNationalInsuranceNumber;
            partial void OnCISNationalInsuranceNumberChanging(string value);
            partial void OnCISNationalInsuranceNumberChanged();
            /// <summary>
            /// There are no comments for Property VendorHoldReleaseDate in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorHoldReleaseDate")]
            public global::System.DateTimeOffset VendorHoldReleaseDate
            {
                get
                {
                    return this._VendorHoldReleaseDate;
                }
                set
                {
                    this.OnVendorHoldReleaseDateChanging(value);
                    this._VendorHoldReleaseDate = value;
                    this.OnVendorHoldReleaseDateChanged();
                    this.OnPropertyChanged("VendorHoldReleaseDate");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private global::System.DateTimeOffset _VendorHoldReleaseDate;
            partial void OnVendorHoldReleaseDateChanging(global::System.DateTimeOffset value);
            partial void OnVendorHoldReleaseDateChanged();
            /// <summary>
            /// There are no comments for Property VendorSearchName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorSearchName")]
            public string VendorSearchName
            {
                get
                {
                    return this._VendorSearchName;
                }
                set
                {
                    this.OnVendorSearchNameChanging(value);
                    this._VendorSearchName = value;
                    this.OnVendorSearchNameChanged();
                    this.OnPropertyChanged("VendorSearchName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorSearchName;
            partial void OnVendorSearchNameChanging(string value);
            partial void OnVendorSearchNameChanged();
            /// <summary>
            /// There are no comments for Property DefaultLedgerDimensionDisplayValue in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultLedgerDimensionDisplayValue")]
            public string DefaultLedgerDimensionDisplayValue
            {
                get
                {
                    return this._DefaultLedgerDimensionDisplayValue;
                }
                set
                {
                    this.OnDefaultLedgerDimensionDisplayValueChanging(value);
                    this._DefaultLedgerDimensionDisplayValue = value;
                    this.OnDefaultLedgerDimensionDisplayValueChanged();
                    this.OnPropertyChanged("DefaultLedgerDimensionDisplayValue");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultLedgerDimensionDisplayValue;
            partial void OnDefaultLedgerDimensionDisplayValueChanging(string value);
            partial void OnDefaultLedgerDimensionDisplayValueChanged();
            /// <summary>
            /// There are no comments for Property Tax1099DoingBusinessAsName in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("Tax1099DoingBusinessAsName")]
            public string Tax1099DoingBusinessAsName
            {
                get
                {
                    return this._Tax1099DoingBusinessAsName;
                }
                set
                {
                    this.OnTax1099DoingBusinessAsNameChanging(value);
                    this._Tax1099DoingBusinessAsName = value;
                    this.OnTax1099DoingBusinessAsNameChanged();
                    this.OnPropertyChanged("Tax1099DoingBusinessAsName");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _Tax1099DoingBusinessAsName;
            partial void OnTax1099DoingBusinessAsNameChanging(string value);
            partial void OnTax1099DoingBusinessAsNameChanged();
            /// <summary>
            /// There are no comments for Property PersonBirthDay in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PersonBirthDay")]
            public int PersonBirthDay
            {
                get
                {
                    return this._PersonBirthDay;
                }
                set
                {
                    this.OnPersonBirthDayChanging(value);
                    this._PersonBirthDay = value;
                    this.OnPersonBirthDayChanged();
                    this.OnPropertyChanged("PersonBirthDay");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private int _PersonBirthDay;
            partial void OnPersonBirthDayChanging(int value);
            partial void OnPersonBirthDayChanged();
            /// <summary>
            /// There are no comments for Property IsReportingTax1099 in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property PreferentialVendor in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property DefaultPurchaseSiteId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultPurchaseSiteId")]
            public string DefaultPurchaseSiteId
            {
                get
                {
                    return this._DefaultPurchaseSiteId;
                }
                set
                {
                    this.OnDefaultPurchaseSiteIdChanging(value);
                    this._DefaultPurchaseSiteId = value;
                    this.OnDefaultPurchaseSiteIdChanged();
                    this.OnPropertyChanged("DefaultPurchaseSiteId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _DefaultPurchaseSiteId;
            partial void OnDefaultPurchaseSiteIdChanging(string value);
            partial void OnDefaultPurchaseSiteIdChanged();
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
            /// There are no comments for Property PriceVendorGroupId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PriceVendorGroupId")]
            public string PriceVendorGroupId
            {
                get
                {
                    return this._PriceVendorGroupId;
                }
                set
                {
                    this.OnPriceVendorGroupIdChanging(value);
                    this._PriceVendorGroupId = value;
                    this.OnPriceVendorGroupIdChanged();
                    this.OnPropertyChanged("PriceVendorGroupId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PriceVendorGroupId;
            partial void OnPriceVendorGroupIdChanging(string value);
            partial void OnPriceVendorGroupIdChanged();
            /// <summary>
            /// There are no comments for Property ClearingPeriodPaymentTermsId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("ClearingPeriodPaymentTermsId")]
            public string ClearingPeriodPaymentTermsId
            {
                get
                {
                    return this._ClearingPeriodPaymentTermsId;
                }
                set
                {
                    this.OnClearingPeriodPaymentTermsIdChanging(value);
                    this._ClearingPeriodPaymentTermsId = value;
                    this.OnClearingPeriodPaymentTermsIdChanged();
                    this.OnPropertyChanged("ClearingPeriodPaymentTermsId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _ClearingPeriodPaymentTermsId;
            partial void OnClearingPeriodPaymentTermsIdChanging(string value);
            partial void OnClearingPeriodPaymentTermsIdChanged();
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
            /// There are no comments for Property BrazilianIE in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilianIE")]
            public string BrazilianIE
            {
                get
                {
                    return this._BrazilianIE;
                }
                set
                {
                    this.OnBrazilianIEChanging(value);
                    this._BrazilianIE = value;
                    this.OnBrazilianIEChanged();
                    this.OnPropertyChanged("BrazilianIE");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BrazilianIE;
            partial void OnBrazilianIEChanging(string value);
            partial void OnBrazilianIEChanged();
            /// <summary>
            /// There are no comments for Property DefaultCashDiscountUsage in the schema.
            /// </summary>
           
            /// There are no comments for Property IsOneTimeVendor in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property IsW9CheckingEnabled in the schema.
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
            /// There are no comments for Property WillReceiptsListProcessingSummaryUpdatePurchaseOrder in the schema.
            /// </summary>
           
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
            /// There are no comments for Property PANStatus in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property IsWomanOwner in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property VendorPartyNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("VendorPartyNumber")]
            public string VendorPartyNumber
            {
                get
                {
                    return this._VendorPartyNumber;
                }
                set
                {
                    this.OnVendorPartyNumberChanging(value);
                    this._VendorPartyNumber = value;
                    this.OnVendorPartyNumberChanged();
                    this.OnPropertyChanged("VendorPartyNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _VendorPartyNumber;
            partial void OnVendorPartyNumberChanging(string value);
            partial void OnVendorPartyNumberChanged();
            /// <summary>
            /// There are no comments for Property WillPurchaseOrderProcessingSummaryUpdatePurchaseOrder in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property BrazilianCNPJOrCPF in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilianCNPJOrCPF")]
            public string BrazilianCNPJOrCPF
            {
                get
                {
                    return this._BrazilianCNPJOrCPF;
                }
                set
                {
                    this.OnBrazilianCNPJOrCPFChanging(value);
                    this._BrazilianCNPJOrCPF = value;
                    this.OnBrazilianCNPJOrCPFChanged();
                    this.OnPropertyChanged("BrazilianCNPJOrCPF");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BrazilianCNPJOrCPF;
            partial void OnBrazilianCNPJOrCPFChanging(string value);
            partial void OnBrazilianCNPJOrCPFChanged();
            /// <summary>
            /// There are no comments for Property BrazilianNIT in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilianNIT")]
            public string BrazilianNIT
            {
                get
                {
                    return this._BrazilianNIT;
                }
                set
                {
                    this.OnBrazilianNITChanging(value);
                    this._BrazilianNIT = value;
                    this.OnBrazilianNITChanged();
                    this.OnPropertyChanged("BrazilianNIT");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _BrazilianNIT;
            partial void OnBrazilianNITChanging(string value);
            partial void OnBrazilianNITChanged();
            /// <summary>
            /// There are no comments for Property IsPrimaryEmailAddressIMEnabled in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property PrimaryFaxNumber in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryFaxNumber")]
            public string PrimaryFaxNumber
            {
                get
                {
                    return this._PrimaryFaxNumber;
                }
                set
                {
                    this.OnPrimaryFaxNumberChanging(value);
                    this._PrimaryFaxNumber = value;
                    this.OnPrimaryFaxNumberChanged();
                    this.OnPropertyChanged("PrimaryFaxNumber");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _PrimaryFaxNumber;
            partial void OnPrimaryFaxNumberChanging(string value);
            partial void OnPrimaryFaxNumberChanged();
            /// <summary>
            /// There are no comments for Property WillProductReceiptProcessingSummaryUpdatePurchaseOrder in the schema.
            /// </summary>
           
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
            /// There are no comments for Property IsServiceDeliveryAddressBased in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property IsPurchaseConsumed in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property WillInvoiceProcessingSummaryUpdatePurchaseOrder in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property GTAVendor in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property IsCUSIPIdentificationNumberApplicable in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property LineDiscountVendorGroupCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("LineDiscountVendorGroupCode")]
            public string LineDiscountVendorGroupCode
            {
                get
                {
                    return this._LineDiscountVendorGroupCode;
                }
                set
                {
                    this.OnLineDiscountVendorGroupCodeChanging(value);
                    this._LineDiscountVendorGroupCode = value;
                    this.OnLineDiscountVendorGroupCodeChanged();
                    this.OnPropertyChanged("LineDiscountVendorGroupCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _LineDiscountVendorGroupCode;
            partial void OnLineDiscountVendorGroupCodeChanging(string value);
            partial void OnLineDiscountVendorGroupCodeChanged();
            /// <summary>
            /// There are no comments for Property WithholdingTaxGroupCode in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("WithholdingTaxGroupCode")]
            public string WithholdingTaxGroupCode
            {
                get
                {
                    return this._WithholdingTaxGroupCode;
                }
                set
                {
                    this.OnWithholdingTaxGroupCodeChanging(value);
                    this._WithholdingTaxGroupCode = value;
                    this.OnWithholdingTaxGroupCodeChanged();
                    this.OnPropertyChanged("WithholdingTaxGroupCode");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _WithholdingTaxGroupCode;
            partial void OnWithholdingTaxGroupCodeChanging(string value);
            partial void OnWithholdingTaxGroupCodeChanged();
            /// <summary>
            /// There are no comments for Property Tax1099FederalTaxId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("Tax1099FederalTaxId")]
            public string Tax1099FederalTaxId
            {
                get
                {
                    return this._Tax1099FederalTaxId;
                }
                set
                {
                    this.OnTax1099FederalTaxIdChanging(value);
                    this._Tax1099FederalTaxId = value;
                    this.OnTax1099FederalTaxIdChanged();
                    this.OnPropertyChanged("Tax1099FederalTaxId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _Tax1099FederalTaxId;
            partial void OnTax1099FederalTaxIdChanging(string value);
            partial void OnTax1099FederalTaxIdChanged();
            /// <summary>
            /// There are no comments for Property EthnicOriginId in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("EthnicOriginId")]
            public string EthnicOriginId
            {
                get
                {
                    return this._EthnicOriginId;
                }
                set
                {
                    this.OnEthnicOriginIdChanging(value);
                    this._EthnicOriginId = value;
                    this.OnEthnicOriginIdChanged();
                    this.OnPropertyChanged("EthnicOriginId");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _EthnicOriginId;
            partial void OnEthnicOriginIdChanging(string value);
            partial void OnEthnicOriginIdChanged();
            /// <summary>
            /// There are no comments for Property UPSFreightZone in the schema.
            /// </summary>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            [global::Microsoft.OData.Client.OriginalNameAttribute("UPSFreightZone")]
            public string UPSFreightZone
            {
                get
                {
                    return this._UPSFreightZone;
                }
                set
                {
                    this.OnUPSFreightZoneChanging(value);
                    this._UPSFreightZone = value;
                    this.OnUPSFreightZoneChanged();
                    this.OnPropertyChanged("UPSFreightZone");
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.4.0")]
            private string _UPSFreightZone;
            partial void OnUPSFreightZoneChanging(string value);
            partial void OnUPSFreightZoneChanged();
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
            /// There are no comments for Property WithholdingTaxVendorType in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property IsChangeManagementActivated in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property BillOfMaterialsLines in the schema.
            /// </summary>
            
            /// <summary>
            /// There are no comments for Property PurchaseAgreement in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property DepreciationBooksVendors in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property DimensionCombination in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property DimensionSet in the schema.
            /// </summary>
           
            /// <summary>
            /// There are no comments for Property ValueModelVendors in the schema.
            /// </summary>
            
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