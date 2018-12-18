using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class PaymentStatusEnum : BaseStringEnumeration
    {
        public PaymentStatusEnum(string value) : base(value) { }

        public static PaymentStatusEnum None => new PaymentStatusEnum("None");
        public static PaymentStatusEnum CanceledReversal => new PaymentStatusEnum("Canceled-Reversal");
        public static PaymentStatusEnum Completed => new PaymentStatusEnum("Completed");
        public static PaymentStatusEnum Denied => new PaymentStatusEnum("Denied");
        public static PaymentStatusEnum Expired => new PaymentStatusEnum("Expired");
        public static PaymentStatusEnum Failed => new PaymentStatusEnum("Failed");
        public static PaymentStatusEnum InProgress => new PaymentStatusEnum("In-Progress");
        public static PaymentStatusEnum PartiallyRefunded => new PaymentStatusEnum("Partially-Refunded");
        public static PaymentStatusEnum Pending => new PaymentStatusEnum("Pending");
        public static PaymentStatusEnum Reversed => new PaymentStatusEnum("Reversed");
        public static PaymentStatusEnum Processed => new PaymentStatusEnum("Processed");
        public static PaymentStatusEnum Voided => new PaymentStatusEnum("Voided");

        public static implicit operator string(PaymentStatusEnum value)
        {
            return value?.Value;
        }

        public static explicit operator PaymentStatusEnum(string value)
        {
            return new PaymentStatusEnum(value);
        }
    }
}
