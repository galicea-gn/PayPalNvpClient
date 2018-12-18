using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations.StringEnumerations
{
    public class AddressStatusEnum : BaseStringEnumeration
    {
        public AddressStatusEnum(string value) : base(value) { }

        public static AddressStatusEnum None => new AddressStatusEnum("none");
        public static AddressStatusEnum Confirmed => new AddressStatusEnum("Confirmed");
        public static AddressStatusEnum Unconfirmed => new AddressStatusEnum("Unconfirmed");

        public static implicit operator string(AddressStatusEnum value)
        {
            return value?.Value;
        }

        public static explicit operator AddressStatusEnum(string value)
        {
            return new AddressStatusEnum(value);
        }
    }
}
