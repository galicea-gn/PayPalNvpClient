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
    public class BAUpdateRequest : IRequest<BAUpdateResponse>
    {
        [JsonProperty("METHOD")]
        public const string Method = "BillAgreementUpdate";

        #region Required Fields
        [JsonProperty("REFERENCEID")]
        [RequiredNameValuePair]
        public string ReferenceId { get; set; }
        #endregion Required Fields

        #region BAUpdate Request Fields
        [JsonProperty("BILLINGAGREEMENTSTATUS")]
        [JsonConverter(typeof(StringEnumConverter))]
        public BillingAgreementStatusEnum BillingAgreementStatus { get; set; }

        [JsonProperty("BILLINGAGREEMENTDESCRIPTION")]
        public string BillingAgreementDescription { get; set; }

        [JsonProperty("BILLINGAGREEMENTCUSTOM")]
        public string BillingAgreementCustom { get; set; }
        #endregion BAUpdate Request Fields

        public BAUpdateRequest() { }

        public BAUpdateRequest(string referenceId)
            : this()
        {
            ReferenceId = referenceId;
        }

        public BAUpdateResponse GenerateResponseObject(string formUrlEncodedString) => FormUrlEncodedHelper.FromKeyValues<BAUpdateResponse>(WebUtility.UrlDecode(formUrlEncodedString));

        public string GetMethod() => Method;
    }
}
