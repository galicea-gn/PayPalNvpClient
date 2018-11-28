using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class PaymentActionEnum : BaseStringEnumeration
    {
        public PaymentActionEnum(string value) : base(value) { }

        public static PaymentActionEnum Authorization => new PaymentActionEnum("Authorization");
        public static PaymentActionEnum Sale => new PaymentActionEnum("Sale");
        public static PaymentActionEnum Order => new PaymentActionEnum("Order");

        public static implicit operator string(PaymentActionEnum value)
        {
            return value?.Value;
        }

        public static explicit operator PaymentActionEnum(string value)
        {
            return new PaymentActionEnum(value);
        }
    }
}
