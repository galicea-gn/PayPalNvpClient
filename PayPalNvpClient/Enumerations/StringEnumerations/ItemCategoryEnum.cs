using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class ItemCategoryEnum : BaseStringEnumeration
    {
        public ItemCategoryEnum(string value) : base(value) { }

        public static ItemCategoryEnum Digital => new ItemCategoryEnum("Digital");
        public static ItemCategoryEnum Physical => new ItemCategoryEnum("Physical");

        public static implicit operator string(ItemCategoryEnum value)
        {
            return value?.Value;
        }

        public static explicit operator ItemCategoryEnum(string value)
        {
            return new ItemCategoryEnum(value);
        }
    }
}
