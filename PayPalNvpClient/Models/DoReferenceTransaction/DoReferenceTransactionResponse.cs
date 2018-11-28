using Newtonsoft.Json;
using PayPalNvpClient.Enumerations;
using PayPalNvpClient.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Models
{
    public class DoReferenceTransactionResponse
    {
        #region DoReferenceTransaction Response Fields
        [JsonProperty("AVSCODE")]
        public string AvsCode { get; set; }

        [JsonProperty("CVV2MATCH")]
        public string Cvv2Match { get; set; }

        [JsonProperty("BILLINGAGREEMENTID")]
        public string BillingAgreementId { get; set; }

        [JsonProperty("L_FMFfilterIDn")]
        public string FmfFilterId { get; set; }

        [JsonProperty("L_FMFfilterNAMEn")]
        public string FmfFilterName { get; set; }

        [JsonProperty("PAYMENTADVICECODE")]
        public string PaymentAdviceCode { get; set; }

        [JsonProperty("MSGSUBID")]
        public string MsgSubId { get; set; }
        #endregion DoReferenceTransaction Response Fields

        #region Payment Information Fields
        [JsonProperty("TRANSACTIONID")]
        public string TransactionId { get; set; }

        [JsonProperty("PARENTTRANSACTIONID")]
        public string ParentTransactionId { get; set; }

        [JsonProperty("RECEIPTID")]
        public string ReceiptId { get; set; }

        [JsonProperty("TRANSACTIONTYPE")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TransactionTypeEnum TransactionType { get; set; }

        [JsonProperty("PAYMENTTYPE")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentTypeEnum PaymentType { get; set; }

        [JsonProperty("ORDERTIME")]
        public string OrderTime { get; set; }

        [JsonProperty("AMT")]
        public string Amount { get; set; }

        [JsonProperty("CURRENCYCODE")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CurrencyCodeEnum CurrencyCode { get; set; }

        [JsonProperty("FEEAMT")]
        public string FeeAmount { get; set; }

        [JsonProperty("SETTLEAMT")]
        public string SettleAmount { get; set; }

        [JsonProperty("TAXAMT")]
        public string TaxAmount { get; set; }

        [JsonProperty("EXCHANGERATE")]
        public string ExchangeRate { get; set; }

        [JsonProperty("PAYMENTSTATUS")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PaymentStatusEnum PaymentStatus { get; set; }

        [JsonProperty("PENDINGREASON")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PendingReasonEnum PendingReason { get; set; }

        [JsonProperty("REASONCODE")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ReasonCodeEnum ReasonCode { get; set; }

        [JsonProperty("PROTECTIONELIGIBILITY")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProtectionEligibilityEnum ProtectionEligibility { get; set; }

        [JsonProperty("PROTECTIONELIGIBILITYTYPE")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ProtectionEligibilityTypeEnum ProtectionEligibilityType { get; set; }

        [JsonProperty("STOREID")]
        public string StoreId { get; set; }

        [JsonProperty("TERMINALID")]
        public string TerminalId { get; set; }

        [JsonProperty("INSTRUMENTCATEGORY")]
        public InstrumentCategoryEnum IntstrumentCategory { get; set; }

        [JsonProperty("INSTRUMENTID")]
        public string InstrumentId { get; set; }

        [JsonProperty("REQCONFIRMSHIPPING")]
        public string RequiredConfirmedShippingAddress { get; set; }
        #endregion Payment Information Fields
    }
}
