using Newtonsoft.Json;
using PayPalNvpClient.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace PayPalNvpClient.Models.BAUpdate
{
    public class BAUpdateRequest : IRequest<BAUpdateResponse>
    {
        [JsonProperty("METHOD")]
        public const string Method = "BillAgreementUpdate";

        #region Required Fields
        [JsonProperty("REFERENCEID")]
        public string ReferenceId { get; set; }
        #endregion Required Fields

        #region BAUpdate Request Fields
        [JsonProperty("BILLINGAGREEMENTSTATUS")]
        public string BillingAgreementStatus { get; set; }

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

        public BAUpdateResponse GenerateResponseObject(string formUrlEncodedString) => FormUrlEncodedHelper.FromKeyValues<BAUpdateResponse>(HttpUtility.UrlDecode(formUrlEncodedString));

        public bool IsValidRequest()
        {
            if (string.IsNullOrEmpty(ReferenceId))
            {
                return false;
            }

            return true;
        }
    }
}
