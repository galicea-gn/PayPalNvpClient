using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class ReasonCodeEnum : BaseStringEnumeration
    {
        public ReasonCodeEnum(string value) : base(value) { }

        public static ReasonCodeEnum None => new ReasonCodeEnum("none");
        public static ReasonCodeEnum Chargeback => new ReasonCodeEnum("chargeback");
        public static ReasonCodeEnum Guarantee => new ReasonCodeEnum("guarantee");
        public static ReasonCodeEnum BuyerCompliant => new ReasonCodeEnum("buyer-compliant");
        public static ReasonCodeEnum Refund => new ReasonCodeEnum("refund");
        public static ReasonCodeEnum Other => new ReasonCodeEnum("other");

        public static implicit operator string(ReasonCodeEnum value)
        {
            return value?.Value;
        }

        public static explicit operator ReasonCodeEnum(string value)
        {
            return new ReasonCodeEnum(value);
        }
    }
}
