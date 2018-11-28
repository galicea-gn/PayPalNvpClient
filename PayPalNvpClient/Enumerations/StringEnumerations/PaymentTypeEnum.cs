using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class PaymentTypeEnum : BaseStringEnumeration
    {
        public PaymentTypeEnum(string value) : base(value) { }

        public static PaymentTypeEnum Any => new PaymentTypeEnum("Any");
        public static PaymentTypeEnum InstantOnly => new PaymentTypeEnum("InstantOnly");
        public static PaymentTypeEnum None => new PaymentTypeEnum("none");
        public static PaymentTypeEnum ECheck => new PaymentTypeEnum("echeck");
        public static PaymentTypeEnum Instant => new PaymentTypeEnum("instant");

        public static implicit operator string(PaymentTypeEnum value)
        {
            return value?.Value;
        }

        public static explicit operator PaymentTypeEnum(string value)
        {
            return new PaymentTypeEnum(value);
        }
    }
}
