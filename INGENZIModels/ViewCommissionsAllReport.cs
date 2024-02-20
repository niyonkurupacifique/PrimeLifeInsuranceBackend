using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCommissionsAllReport
{
    public string? CustomerCode { get; set; }

    public string? FullName { get; set; }

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? BusinessChannel { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string? EffectiveDate { get; set; }

    public string? MaturityDate { get; set; }

    public string? Expr1 { get; set; }

    public string ReferencePay { get; set; } = null!;

    public string? PremiumPaymentDate { get; set; }

    public double PremiumAmountPayed { get; set; }

    public double? CommissionAmountDue { get; set; }

    public string? CommissionPaymentDate { get; set; }

    public double? CommissionAmountPayed { get; set; }

    public bool PaymentStatus { get; set; }

    public string? ReportingMonths { get; set; }

    public string Products { get; set; } = null!;

    public string? PaymentSource { get; set; }

    public int? DifferedTerm { get; set; }

    public int? PolicyAgeMonths { get; set; }

    public double? CommissionRate { get; set; }

    public string? PolicyType { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? RiskPremium { get; set; }

    public DateTime? PaymentDueDate { get; set; }

    public DateTime? PolicyRecordedDate { get; set; }

    public int? IdRecord { get; set; }
}
