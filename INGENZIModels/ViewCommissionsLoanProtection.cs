using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCommissionsLoanProtection
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? VendorCode { get; set; }

    public string? VendorName { get; set; }

    public string? BusinessChannel { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string ReferencePay { get; set; } = null!;

    public DateTime PremiumPaymentDate { get; set; }

    public double PremiumAmountPayed { get; set; }

    public double CommissionAmountDue { get; set; }

    public DateTime? CommissionPaymentDate { get; set; }

    public double? CommissionAmountPayed { get; set; }

    public bool PaymentStatus { get; set; }

    public string? ReportingMonths { get; set; }

    public string Products { get; set; } = null!;

    public string? PaymentChannel { get; set; }

    public int? DifferedTerm { get; set; }

    public int? PolicyAgeMonths { get; set; }

    public double? CommissionRate { get; set; }

    public string PolicyType { get; set; } = null!;

    public string ProofOfPayment { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public string? PayFrequency { get; set; }

    public double TotalPremium { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime RecordDate { get; set; }

    public int? ControllerId { get; set; }
}
