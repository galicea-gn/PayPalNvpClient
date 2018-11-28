using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class ProtectionEligibilityEnum : BaseStringEnumeration
    {
        public ProtectionEligibilityEnum(string value) : base(value) { }

        public static ProtectionEligibilityEnum Eligible => new ProtectionEligibilityEnum("Eligible");
        public static ProtectionEligibilityEnum PartiallyEligible => new ProtectionEligibilityEnum("PartiallyEligible");
        public static ProtectionEligibilityEnum Ineligible => new ProtectionEligibilityEnum("Ineligible");

        public static implicit operator string(ProtectionEligibilityEnum value)
        {
            return value?.Value;
        }

        public static explicit operator ProtectionEligibilityEnum(string value)
        {
            return new ProtectionEligibilityEnum(value);
        }
    }
}
