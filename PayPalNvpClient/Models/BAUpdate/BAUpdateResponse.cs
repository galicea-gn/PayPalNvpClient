using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Models.BAUpdate
{
    public class BAUpdateResponse : IResponse
    {
        #region BAUpdate Response Fields
        [JsonProperty("BILLINGAGREEMENTID")]
        public string BillingAgreementId { get; set; }

        [JsonProperty("BILLINGAGREEMENTDESCRIPTION")]
        public string BillingAgreementDescription { get; set; }

        [JsonProperty("BILLINGAGREEMENTCUSTOM")]
        public string BillingAgreementCustom { get; set; }

        [JsonProperty("BILLINGAGREEMENTSTATUS")]
        public string BillingAgreementStatus { get; set; }

        [JsonProperty("BILLINGAGREEMENTMAX")]
        public string BillingAgreementMax { get; set; }

        [JsonProperty("BILLINGADDRESS")]
        public string BillingAddress { get; set; }
        #endregion BAUpdate Response Fields

        #region Payer Information Fields
        [JsonProperty("EMAIL")]
        public string EmailAddress { get; set; }

        [JsonProperty("PAYERID")]
        public string PayerId { get; set; }

        [JsonProperty("PAYERSTATUS")]
        public string PayerStatus { get; set; }

        [JsonProperty("COUNTRYCODE")]
        public string CountryCode { get; set; }

        [JsonProperty("PAYERBUSINESS")]
        public string PayerBusiness { get; set; }
        #endregion Payer Information Fields

        #region Payer Name Fields
        [JsonProperty("SALUTATION")]
        public string Salutation { get; set; }

        [JsonProperty("FIRSTNAME")]
        public string FirstName { get; set; }

        [JsonProperty("MIDDLENAME")]
        public string MiddleName { get; set; }

        [JsonProperty("LASTNAME")]
        public string LastName { get; set; }

        [JsonProperty("SUFFIX")]
        public string Suffix { get; set; }
        #endregion Payer Name Fields

        #region Bill to Address Fields
        [JsonProperty("BILLINGNAME")]
        public string BillingName { get; set; }

        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("STREET2")]
        public string Street2 { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }

        public string BillingCountryCode => CountryCode;
        #endregion Bill to Address Fields

        #region Payee Information Fields
        [JsonProperty("PAYEEEMAIL")]
        public string PayeeEmail { get; set; }

        [JsonProperty("PAYEEID")]
        public string PayeeId { get; set; }
        #endregion Payee Information Fields
    }
}
