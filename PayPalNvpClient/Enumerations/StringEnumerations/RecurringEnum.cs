using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class RecurringEnum : BaseStringEnumeration
    {
        public RecurringEnum(string value) : base(value) { }

        public static RecurringEnum RecurringDisabled => new RecurringEnum("N");
        public static RecurringEnum RecurringEnabled => new RecurringEnum("Y");

        public static implicit operator string(RecurringEnum value)
        {
            return value?.Value;
        }

        public static explicit operator RecurringEnum(string value)
        {
            return new RecurringEnum(value);
        }
    }
}
