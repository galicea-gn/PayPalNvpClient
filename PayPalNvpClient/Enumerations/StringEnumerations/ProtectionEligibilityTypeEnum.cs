using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class ProtectionEligibilityTypeEnum : BaseStringEnumeration
    {
        public ProtectionEligibilityTypeEnum(string value) : base(value) { }

        public static ProtectionEligibilityTypeEnum ItemNotReceivedEligible => new ProtectionEligibilityTypeEnum("ItemNotReceivedEligible");
        public static ProtectionEligibilityTypeEnum UnauthorizedPaymentEligible => new ProtectionEligibilityTypeEnum("UnauthorizedPaymentEligible");
        public static ProtectionEligibilityTypeEnum Ineligible => new ProtectionEligibilityTypeEnum("Ineligible");

        public static implicit operator string(ProtectionEligibilityTypeEnum value)
        {
            return value?.Value;
        }

        public static explicit operator ProtectionEligibilityTypeEnum(string value)
        {
            return new ProtectionEligibilityTypeEnum(value);
        }
    }
}
