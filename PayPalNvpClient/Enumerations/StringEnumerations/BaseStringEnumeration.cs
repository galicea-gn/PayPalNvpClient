using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class BaseStringEnumeration : IEquatable<BaseStringEnumeration>, IEquatable<string>
    {
        public BaseStringEnumeration(string value) { Value = value; }

        public string Value { get; }

        public override string ToString()
        {
            return Value.ToString();
        }

        public bool Equals(BaseStringEnumeration other)
        {
            return Value.Equals(other?.Value);
        }

        public bool Equals(string other)
        {
            return Value.Equals(other);
        }

        public static explicit operator string(BaseStringEnumeration value)
        {
            return value?.Value;
        }

        public static explicit operator BaseStringEnumeration(string value)
        {
            return new BaseStringEnumeration(value);
        }
    }
}
