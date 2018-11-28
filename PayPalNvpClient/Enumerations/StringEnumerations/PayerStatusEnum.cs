using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class PayerStatusEnum : BaseStringEnumeration
    {
        public PayerStatusEnum(string value) : base(value) { }

        public static PayerStatusEnum Verified => new PayerStatusEnum("verified");
        public static PayerStatusEnum Unverified => new PayerStatusEnum("unverified");

        public static implicit operator string(PayerStatusEnum value)
        {
            return value?.Value;
        }

        public static explicit operator PayerStatusEnum(string value)
        {
            return new PayerStatusEnum(value);
        }
    }
}
