using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class BillingAgreementStatusEnum : BaseStringEnumeration
    {
        public BillingAgreementStatusEnum(string value) : base(value) { }

        public static BillingAgreementStatusEnum Canceled => new BillingAgreementStatusEnum("Canceled");
        public static BillingAgreementStatusEnum Active => new BillingAgreementStatusEnum("Active");

        public static implicit operator string(BillingAgreementStatusEnum value)
        {
            return value?.Value;
        }

        public static explicit operator BillingAgreementStatusEnum(string value)
        {
            return new BillingAgreementStatusEnum(value);
        }
    }
}
