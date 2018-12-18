using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using PayPalNvpClient.Enumerations;
using PayPalNvpClient.Enumerations.StringEnumerations;

namespace PayPalNvpClient.Models
{
    public class GetTransactionDetailsResponse
    {
        #region GetTransactionDetails Response Fields
        [JsonProperty("SHIPPINGCALCULATIONMODE")]
        public ShippingCalculationModeEnum ShippingCalculationMode { get; set; }

        [JsonProperty("INSURANCEOPTIONSELECTED")]
        public string InsuranceOptionSelected { get; set; }

        //[JsonProperty("L_SHIPPINGOPTIONISDEFAULTn")]
        //public bool ShippingOptionIsDefault { get; set; }

        //[JsonProperty("L_SHIPPINGOPTIONNAMEn")]
        //public string ShippingOptionName { get; set; }

        //[JsonProperty("L_SHIPPINGOPTIONAMOUNTn")]
        //public double ShippingOptionAmount { get; set; }

        [JsonProperty("GIFTMESSAGE")]
        public string GiftMessage { get; set; }

        [JsonProperty("GIFTRECEIPTENABLE")]
        public GiftReceiptEnableEnum GiftReceiptEnable { get; set; }

        [JsonProperty("GIFTWRAPNAME")]
        public string GiftWrapName { get; set; }

        [JsonProperty("GIFTWRAPAMOUNT")]
        public double GiftWrapAmount { get; set; }

        [JsonProperty("BUYERMARKETINGEMAIL")]
        public string BuyerMarketingEmail { get; set; }

        [JsonProperty("SURVEYQUESTION")]
        public string SurveyQuestion { get; set; }

        [JsonProperty("SURVEYCHOICESELECTED")]
        public string SurveyChoiceSelected { get; set; }
        #endregion GetTransactionDetails Response Fields

        #region Receiver Information Fields
        [JsonProperty("RECEIVERBUSINESS")]
        public string ReceiverBusiness { get; set; }

        [JsonProperty("RECEIVEREMAIL")]
        public string ReceiverEmail { get; set; }

        [JsonProperty("RECEIVERID	")]
        public string ReceiverId { get; set; }
        #endregion Receiver Information Fields

        #region Payer Information Fields
        [JsonProperty("EMAIL")]
        public string Email { get; set; }

        [JsonProperty("PAYERID")]
        public string PayerId { get; set; }

        [JsonProperty("PAYERSTATUS")]
        public PayerStatusEnum PayerStatus { get; set; }

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

        #region Address Fields
        [JsonProperty("ADDRESSOWNER")]
        public string AddressOwner { get; set; }

        [JsonProperty("ADDRESSSTATUS")]
        public AddressStatusEnum AddressStatus { get; set; }

        [JsonProperty("SHIPTOSECONDARYNAME")]
        public string ShipToSecondaryName { get; set; }

        [JsonProperty("SHIPTONAME")]
        public string ShipToName { get; set; }

        [JsonProperty("SHIPTOSTREET")]
        public string ShipToStreet { get; set; }

        [JsonProperty("SHIPTOSECONDARYADDRESSLINE1")]
        public string ShipToSecondaryAddressLine1 { get; set; }

        [JsonProperty("SHIPTOSTREET2")]
        public string ShipToStreet2 { get; set; }

        [JsonProperty("SHIPTOSECONDARYADDRESSLINE2")]
        public string ShipToSecondaryAddressLine2 { get; set; }

        [JsonProperty("SHIPTOCITY")]
        public string ShipToCity { get; set; }

        [JsonProperty("SHIPTOSECONDARYCITY")]
        public string ShipToSecondaryCity { get; set; }

        [JsonProperty("SHIPTOSTATE")]
        public string ShipToState { get; set; }

        [JsonProperty("SHIPTOSECONDARYSTATE")]
        public string ShipToSecondaryState { get; set; }

        [JsonProperty("SHIPTOZIP")]
        public string ShipToZip { get; set; }

        [JsonProperty("SHIPTOSECONDARYZIP")]
        public string ShipToSecondaryZip { get; set; }

        [JsonProperty("SHIPTOCOUNTRYCODE")]
        public string ShipToCountryCode { get; set; }

        [JsonProperty("SHIPTOSECONDARYCOUNTRYCODE")]
        public string ShipToSecondaryCountryCode { get; set; }

        [JsonProperty("SHIPTOPHONENUM")]
        public string ShipToPhoneNum { get; set; }

        [JsonProperty("SHIPTOSECONDARYPHONENUM")]
        public string ShipToSecondaryPhoneNum { get; set; }
        #endregion Address Fields

        #region Payment Information Fields
        [JsonProperty("TRANSACTIONID")]
        public string TransactionId { get; set; }

        [JsonProperty("PARENTTRANSACTIONID")]
        public string ParentTransactionId { get; set; }

        [JsonProperty("RECEIPTID")]
        public string ReceiptId { get; set; }

        [JsonProperty("TRANSACTIONTYPE")]
        public TransactionTypeEnum TransactionType { get; set; }

        [JsonProperty("PAYMENTTYPE")]
        public PaymentTypeEnum PaymentType { get; set; }

        [JsonProperty("ORDERTIME")]
        public DateTime OrderTime { get; set; }

        [JsonProperty("AMT")]
        public double Amount { get; set; }

        [JsonProperty("CURRENCYCODE")]
        public CurrencyCodeEnum CurrencyCode { get; set; }

        [JsonProperty("FEEAMT")]
        public double FeeAmount { get; set; }

        [JsonProperty("SETTLEAMT")]
        public double SettleAmount { get; set; }

        [JsonProperty("TAXAMT")]
        public double TaxAmount { get; set; }

        [JsonProperty("EXCHANGERATE")]
        public double ExchangeRate { get; set; }

        [JsonProperty("PAYMENTSTATUS")]
        public PaymentStatusEnum PaymentStatus { get; set; }

        [JsonProperty("PENDINGREASON")]
        public PendingReasonEnum PendingReason { get; set; }

        [JsonProperty("REASONCODE")]
        public ReasonCodeEnum ReasonCode { get; set; }

        [JsonProperty("PROTECTIONELIGIBILITY")]
        public ProtectionEligibilityEnum ProtectionEligibility { get; set; }

        [JsonProperty("PROTECTIONELIGIBILITYTYPE")]
        public ProtectionEligibilityTypeEnum ProtectionEligibilityType { get; set; }

        [JsonProperty("STOREID")]
        public string StoreId { get; set; }

        [JsonProperty("SUBJECT")]
        public string Subject { get; set; }

        [JsonProperty("TERMINALID")]
        public string TerminalId { get; set; }
        #endregion Payment Information Fields

        #region Payment Item Information Fields
        [JsonProperty("INVNUM")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("CUSTOM")]
        public string Custom { get; set; }

        [JsonProperty("NOTE")]
        public string Note { get; set; }

        [JsonProperty("SALESTAX")]
        public double SalesTax { get; set; }

        [JsonProperty("SOFTDESCRIPTOR")]
        public string SoftDescriptionFor { get; set; }
        #endregion Payment Item Information Fields

        #region Payment Item Fields
        //TODO
        #endregion Payment Item Fields

        #region Auction Information Fields
        [JsonProperty("BUYERID")]
        public string BuyerId { get; set; }

        [JsonProperty("CLOSINGDATE")]
        public DateTime ClosingDate { get; set; }

        [JsonProperty("MULTIITEM")]
        public int MultiItemCounter { get; set; }
        #endregion Auction Information Fields

        #region SubscriptionInfo Type Fields
        [JsonProperty("SUBSCRIPTIONID")]
        public string SubscriptionId { get; set; }

        [JsonProperty("SUBSCRIPTIONDATE")]
        public DateTime SubscriptionDate { get; set; }

        [JsonProperty("EFFECTIVEDATE")]
        public DateTime EffectiveDate { get; set; }

        [JsonProperty("RETRYTIME")]
        public DateTime RetryTime { get; set; }

        [JsonProperty("USERNAME")]
        public string Username { get; set; }

        [JsonProperty("PASSWORD")]
        public string Password { get; set; }

        [JsonProperty("RECURRENCES")]
        public int Recurrences { get; set; }

        [JsonProperty("REATTEMPT")]
        public bool Reattempt { get; set; }

        [JsonProperty("RECURRING")]
        public int Recurring { get; set; }
        #endregion SubscriptionInfo Type Fields

        #region Subscription Term Fields
        [JsonProperty("AMOUNT")]
        public double SubscriptionAmount { get; set; }
        
        [JsonProperty("PERIOD")]
        public string Period { get; set; }
        #endregion Subscription Term Fields
    }
}
