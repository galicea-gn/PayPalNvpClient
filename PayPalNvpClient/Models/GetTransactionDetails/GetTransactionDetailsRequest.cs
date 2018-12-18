using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using PayPalNvpClient.Helpers;

namespace PayPalNvpClient.Models
{
    public class GetTransactionDetailsRequest : IRequest<GetTransactionDetailsResponse>
    {
        [JsonProperty("METHOD")]
        public const string Method = "GetTransactionDetails";

        public GetTransactionDetailsResponse GenerateResponseObject(string formUrlEncodedString) => FormUrlEncodedHelper.FromKeyValues<GetTransactionDetailsResponse>(WebUtility.UrlDecode(formUrlEncodedString));

        public string GetMethod() => Method;

        #region Required Fields

        [JsonProperty("TRANSACTIONID")]
        [RequiredNameValuePair]
        public string TransactionId { get; set; }

        #endregion Required Fields

        public GetTransactionDetailsRequest(string transactionId)
        {
            TransactionId = transactionId;
        }
    }
}
