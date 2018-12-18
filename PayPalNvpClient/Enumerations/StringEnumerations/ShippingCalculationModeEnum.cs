using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations.StringEnumerations
{
    public class ShippingCalculationModeEnum : BaseStringEnumeration
    {
        public ShippingCalculationModeEnum(string value) : base(value) { }

        public static ShippingCalculationModeEnum Callback => new ShippingCalculationModeEnum("Callback");
        public static ShippingCalculationModeEnum FlatRate => new ShippingCalculationModeEnum("FlatRate");

        public static implicit operator string(ShippingCalculationModeEnum value)
        {
            return value?.Value;
        }

        public static explicit operator ShippingCalculationModeEnum(string value)
        {
            return new ShippingCalculationModeEnum(value);
        }
    }
}
