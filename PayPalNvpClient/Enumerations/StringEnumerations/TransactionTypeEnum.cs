using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class TransactionTypeEnum : BaseStringEnumeration
    {
        public TransactionTypeEnum(string value) : base(value) { }

        public static TransactionTypeEnum Cart => new TransactionTypeEnum("cart");
        public static TransactionTypeEnum ExpressCheckout => new TransactionTypeEnum("express-checkout");

        public static implicit operator string(TransactionTypeEnum value)
        {
            return value?.Value;
        }

        public static explicit operator TransactionTypeEnum(string value)
        {
            return new TransactionTypeEnum(value);
        }
    }
}
