using System;
using System.Collections.Generic;
using System.Text;

namespace PayPalNvpClient.Enumerations
{
    public class PaymentStatusEnum : BaseStringEnumeration
    {
        public PaymentStatusEnum(string value) : base(value) { }

        public static PendingReasonEnum None => new PendingReasonEnum("none");
        public static PendingReasonEnum Address => new PendingReasonEnum("address");
        public static PendingReasonEnum Authorization => new PendingReasonEnum("authorization");
        public static PendingReasonEnum ECheck => new PendingReasonEnum("echeck");
        public static PendingReasonEnum International => new PendingReasonEnum("intl");
        public static PendingReasonEnum MultiCurrency => new PendingReasonEnum("multi-currency");
        public static PendingReasonEnum Order => new PendingReasonEnum("order");
        public static PendingReasonEnum PaymentReview => new PendingReasonEnum("paymentreview");
        public static PendingReasonEnum RegulatoryReview => new PendingReasonEnum("regulatoryreview");
        public static PendingReasonEnum Unilateral => new PendingReasonEnum("unilateral");
        public static PendingReasonEnum Verify => new PendingReasonEnum("verify");
        public static PendingReasonEnum Other => new PendingReasonEnum("other");

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
