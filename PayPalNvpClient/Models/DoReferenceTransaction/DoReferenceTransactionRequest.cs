using Newtonsoft.Json;
using PayPalNvpClient.Enumerations;
using PayPalNvpClient.Exceptions;
using PayPalNvpClient.Helpers;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Web;

namespace PayPalNvpClient.Models
{
    public class DoReferenceTransactionRequest : IRequest<DoReferenceTransactionResponse>
    {
        [JsonProperty("METHOD")]
        public const string Method = "DoReferenceTransaction";

        #region Required Fields
        [JsonProperty("REFERENCEID")]
        [RequiredNameValuePair]
        public string ReferenceId { get; set; }

        [JsonProperty("PAYMENTACTION")]
        [JsonConverter(typeof(StringEnumConverter))]
        [RequiredNameValuePair]
        public PaymentActionEnum PaymentAction { get; set; }

        [JsonProperty("AMT")]
        [RequiredNameValuePair]
        public double Amount { get; set; }
        #endregion Required Fields

        #region DoReferenceTransaction Request Fields
        [JsonProperty("PAYMENTTYPE")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentTypeEnum PaymentType { get; set; }

        [JsonProperty("IPADDRESS")]
        public IPAddress IpAddress { get; set; }

        [JsonProperty("RISKSESSIONCORRELATIONID")]
        public string RiskSessionCorrelationId { get; set; }

        [JsonProperty("MERCHANTSESSIONID")]
        public string MerchantSessionId { get; set; }

        [JsonProperty("RETURNFMFDETAILS")]
        public bool ReturnFmfDetails { get; set; }

        [JsonProperty("SOFTDESCRIPTOR")]
        public string SoftDescriptor { get; set; }

        [JsonProperty("SOFTDESCRIPTORCITY")]
        public string SoftDescriptorCity { get; set; }

        [JsonProperty("PAYMENTREQUEST_n_PAYMENTREASON")]
        public string PaymentRequestAndPaymentReason { get; set; }

        [JsonProperty("MSGSUBID")]
        public string MsgSubId { get; set; }
        #endregion DoReferenceTransaction Request Fields

        #region Ship to Address Fields
        [JsonProperty("SHIPTONAME")]
        public string ShipToName { get; set; }

        [JsonProperty("SHIPTOSTREET")]
        public string ShipToStreet { get; set; }

        [JsonProperty("SHIPTOSTREET2")]
        public string ShipToStreet2 { get; set; }

        [JsonProperty("SHIPTOCITY")]
        public string ShipToCity { get; set; }

        [JsonProperty("SHIPTOSTATE")]
        public string ShipToState { get; set; }

        [JsonProperty("SHIPTOZIP")]
        public string ShipToZip { get; set; }

        [JsonProperty("SHIPTOCOUNTRY")]
        public string ShipToCountry { get; set; }

        [JsonProperty("SHIPTOPHONENUM")]
        public string ShipToPhoneNumber { get; set; }
        #endregion Ship to Address Fields

        #region Payment Details Fields
        [JsonProperty("CURRENCYCODE")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CurrencyCodeEnum CurrencyCode { get; set; }

        [JsonProperty("ITEMAMT")]
        public string ItemAmount { get; set; }

        [JsonProperty("SHIPPINGAMT")]
        public string ShippingAmount { get; set; }

        [JsonProperty("INSURANCEAMT")]
        public string InsuranceAmount { get; set; }

        [JsonProperty("SHIPDISCAMT")]
        public string ShippingDiscountAmount { get; set; }

        [JsonProperty("HANDLINGAMT")]
        public string HandlingAmount { get; set; }

        [JsonProperty("TAXAMT")]
        public string TaxAmount { get; set; }

        [JsonProperty("DESC")]
        public string Description { get; set; }

        [JsonProperty("CUSTOM")]
        public string Custom { get; set; }

        [JsonProperty("INVNUM")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("BUTTONSOURCE")]
        public string ButtonSource { get; set; }

        [JsonProperty("NOTIFYURL")]
        public string NotifyUrl { get; set; }

        [JsonProperty("RECURRING")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RecurringEnum Recurring { get; set; } = RecurringEnum.RecurringDisabled;

        [JsonProperty("BUCKETCATEGORYTYPE")]
        public BucketCategoryTypeEnum BucketCategoryType { get; set; }
        #endregion Payment Details Fields

        #region Payment Details Item Fields
        [JsonProperty("L_ITEMCATEGORYn")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemCategoryEnum ItemCategory { get; set; }

        [JsonProperty("L_NAMEn")]
        public string ItemName { get; set; }

        [JsonProperty("L_DESCn")]
        public string ItemDescription { get; set; }

        [JsonProperty("L_AMTn")]
        public string ItemDetailAmount { get; set; }

        [JsonProperty("L_NUMBERn")]
        public string ItemNumber { get; set; }

        [JsonProperty("L_QTYn")]
        public int ItemQuantity { get; set; }

        [JsonProperty("L_TAXAMTn")]
        public float ItemTaxAmount { get; set; }
        #endregion Payment Details Item Fields

        #region Ebay Item Payment Details Item Fields
        [JsonProperty("L_EBAYITEMNUMBERn")]
        public string EbayItemNumber { get; set; }

        [JsonProperty("L_EBAYITEMAUCTIONTXNIDn")]
        public string EbayItemAuctionTransactionId { get; set; }

        [JsonProperty("L_EBAYITEMORDERIDn")]
        public string EbayItemOrderId { get; set; }
        #endregion Ebay Item Payment Details Item Fields

        #region Reference Credit Card Details Fields
        [JsonProperty("CREDITCARDTYPE")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CreditCardTypeEnum CreditCardType { get; set; }

        [JsonProperty("ACCT")]
        public string CreditCardNumber { get; set; }

        [JsonProperty("EXPDATE")]
        public string ExpirationDate { get; set; }

        [JsonProperty("CVV2")]
        public string Cvv2 { get; set; }

        [JsonProperty("STARTDATE")]
        public string StartDate { get; set; }

        [JsonProperty("ISSUENUMBER")]
        public string IssueNumber { get; set; }
        #endregion Reference Credit Card Details Fields

        #region Payer Information Fields
        [JsonProperty("EMAIL")]
        public string EmailAddress { get; set; }

        [JsonProperty("FIRSTNAME")]
        public string FirstName { get; set; }

        [JsonProperty("LASTNAME")]
        public string LastName { get; set; }
        #endregion Payer Information Fields

        #region Address Fields
        [JsonProperty("STREET")]
        public string Street { get; set; }

        [JsonProperty("STREET2")]
        public string Street2 { get; set; }

        [JsonProperty("CITY")]
        public string City { get; set; }

        [JsonProperty("STATE")]
        public string State { get; set; }

        [JsonProperty("COUNTRYCODE")]
        public string CountryCode { get; set; }

        [JsonProperty("ZIP")]
        public string Zip { get; set; }
        #endregion Address Fields

        public DoReferenceTransactionRequest() { }

        public DoReferenceTransactionRequest(string referenceId)
            : this()
        {
            ReferenceId = referenceId;
        }

        public DoReferenceTransactionRequest(string referenceId, PaymentActionEnum paymentAction)
            : this(referenceId)
        {
            PaymentAction = paymentAction;
        }

        public DoReferenceTransactionRequest(string referenceId, PaymentActionEnum paymentAction, double amount)
            : this(referenceId, paymentAction)
        {
            Amount = amount;
        }

        public DoReferenceTransactionResponse GenerateResponseObject(string formUrlEncodedString) => FormUrlEncodedHelper.FromKeyValues<DoReferenceTransactionResponse>(HttpUtility.UrlDecode(formUrlEncodedString));

        public string GetMethod() => Method;
    }
}
