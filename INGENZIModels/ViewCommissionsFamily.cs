using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCommissionsFamily
{
    public string? CustomerCode { get; set; }

    public string? FullName { get; set; }

    public string? VendorId { get; set; }

    public string? ChannelName { get; set; }

    public string? BusinessChannel { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string ReferencePay { get; set; } = null!;

    public DateTime PremiumPaymentDate { get; set; }

    public double PremiumAmountPayed { get; set; }

    public double CommissionAmountDue { get; set; }

    public DateTime? CommissionPaymentDate { get; set; }

    public double? CommissionAmountPayed { get; set; }

    public bool PaymentStatus { get; set; }

    public string? ReportingMonths { get; set; }

    public string Products { get; set; } = null!;

    public string? PaymentSource { get; set; }

    public int? DifferedTerm { get; set; }

    public int? PolicyAgeMonths { get; set; }

    public double? CommissionRate { get; set; }

    public string PolicyType { get; set; } = null!;

    public string ProofOfPayment { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public string? PremiumFrequency { get; set; }

    public double? RiskPremium { get; set; }

    public DateTime? PaymentPeriod { get; set; }

    public DateTime? RecordedDate { get; set; }

    public int IdRecord { get; set; }
}
