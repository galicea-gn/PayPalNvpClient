using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Models.DoReferenceTransaction
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
        public string TransactionType { get; set; }

        [JsonProperty("PAYMENTTYPE")]
        public string PaymentType { get; set; }

        [JsonProperty("ORDERTIME")]
        public string OrderTime { get; set; }

        [JsonProperty("AMT")]
        public string Amount { get; set; }

        [JsonProperty("CURRENCYCODE")]
        public string CurrencyCode { get; set; }

        [JsonProperty("FEEAMT")]
        public string FeeAmount { get; set; }

        [JsonProperty("SETTLEAMT")]
        public string SettleAmount { get; set; }

        [JsonProperty("TAXAMT")]
        public string TaxAmount { get; set; }

        [JsonProperty("EXCHANGERATE")]
        public string ExchangeRate { get; set; }

        [JsonProperty("PAYMENTSTATUS")]
        public string PaymentStatus { get; set; }

        [JsonProperty("PENDINGREASON")]
        public string PendingReason { get; set; }

        [JsonProperty("REASONCODE")]
        public string ReasonCode { get; set; }

        [JsonProperty("PROTECTIONELIGIBILITY")]
        public string ProtectionEligibility { get; set; }

        [JsonProperty("PROTECTIONELIGIBILITYTYPE")]
        public string ProtectionEligibilityType { get; set; }

        [JsonProperty("STOREID")]
        public string StoreId { get; set; }

        [JsonProperty("TERMINALID")]
        public string TerminalId { get; set; }

        [JsonProperty("INSTRUMENTCATEGORY")]
        public string IntstrumentCategory { get; set; }

        [JsonProperty("INSTRUMENTID")]
        public string InstrumentId { get; set; }

        [JsonProperty("REQCONFIRMSHIPPING")]
        public string RequiredConfirmedShippingAddress { get; set; }
        #endregion Payment Information Fields
    }
}
