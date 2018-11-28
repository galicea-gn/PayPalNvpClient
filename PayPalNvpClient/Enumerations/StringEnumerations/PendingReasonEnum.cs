using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class PendingReasonEnum : BaseStringEnumeration
    {
        public PendingReasonEnum(string value) : base(value) { }

        public static PendingReasonEnum None => new PendingReasonEnum("None");
        public static PendingReasonEnum CanceledReversal => new PendingReasonEnum("Canceled-Reversal");
        public static PendingReasonEnum Completed => new PendingReasonEnum("Completed");
        public static PendingReasonEnum Denied => new PendingReasonEnum("Denied");
        public static PendingReasonEnum Expired => new PendingReasonEnum("Expired");
        public static PendingReasonEnum Failed => new PendingReasonEnum("Failed");
        public static PendingReasonEnum InProgress => new PendingReasonEnum("In-Progress");
        public static PendingReasonEnum PartiallyRefunded => new PendingReasonEnum("Partially-Refunded");
        public static PendingReasonEnum Pending => new PendingReasonEnum("Pending");
        public static PendingReasonEnum Reversed => new PendingReasonEnum("Reversed");
        public static PendingReasonEnum Processed => new PendingReasonEnum("Processed");
        public static PendingReasonEnum Voided => new PendingReasonEnum("Voided");

        public static implicit operator string(PendingReasonEnum value)
        {
            return value?.Value;
        }

        public static explicit operator PendingReasonEnum(string value)
        {
            return new PendingReasonEnum(value);
        }
    }
}
