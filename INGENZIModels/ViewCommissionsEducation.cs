using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCommissionsEducation
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }

    public string? ChannelType { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string ReferencePay { get; set; } = null!;

    public DateTime PremiumPaymentDate { get; set; }

    public double PremiumAmountPayed { get; set; }

    public double? CommissionAmountDue { get; set; }

    public DateTime? CommissionPaymentDate { get; set; }

    public double? CommissionAmountPayed { get; set; }

    public bool PaymentStatus { get; set; }

    public string? ReportingMonths { get; set; }

    public string Product { get; set; } = null!;

    public string? PaymentSource { get; set; }

    public int? DifferedTerm { get; set; }

    public int? PolicyAgeMonths { get; set; }

    public double? CommissionRate { get; set; }

    public string PolicyType { get; set; } = null!;

    public string ProofOfPayment { get; set; } = null!;

    public DateTime? DatePolicy { get; set; }

    public string? PaymentFrequency { get; set; }

    public double? Premium { get; set; }

    public DateTime? PaymentPeriod { get; set; }

    public DateTime? RecordedDate { get; set; }

    public int IdRecord { get; set; }
}
