using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class CreditCardTypeEnum : BaseStringEnumeration
    {
        public CreditCardTypeEnum(string value) : base(value) { }

        public static CreditCardTypeEnum Visa => new CreditCardTypeEnum("Visa");
        public static CreditCardTypeEnum MasterCard => new CreditCardTypeEnum("MasterCard");
        public static CreditCardTypeEnum Discover => new CreditCardTypeEnum("Discover");
        public static CreditCardTypeEnum AmericanExpress => new CreditCardTypeEnum("Amex");
        public static CreditCardTypeEnum Jcb => new CreditCardTypeEnum("JCB");
        public static CreditCardTypeEnum Maestro => new CreditCardTypeEnum("Maestro");

        public static implicit operator string(CreditCardTypeEnum value)
        {
            return value?.Value;
        }

        public static explicit operator CreditCardTypeEnum(string value)
        {
            return new CreditCardTypeEnum(value);
        }
    }
}
