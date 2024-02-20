using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCommissionsPensionSavingsMain
{
    public string CustomerCode { get; set; } = null!;

    public string? Names { get; set; }

    public string VendorCode { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? VendorType { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string ReferencePay { get; set; } = null!;

    public DateTime PremiumPaymentDate { get; set; }

    public double PremiumAmountPayed { get; set; }

    public double? CommissionAmountDue { get; set; }

    public DateTime? CommissionPaymentDate { get; set; }

    public double? CommissionAmountPayed { get; set; }

    public bool PaymentStatus { get; set; }

    public string? ReportingMonths { get; set; }

    public string Products { get; set; } = null!;

    public string? Channel { get; set; }

    public int? DifferedTerm { get; set; }

    public int? PolicyAgeMonths { get; set; }

    public double? CommissionRate { get; set; }

    public string? PolicyType { get; set; }

    public string? ProofOfPayment { get; set; }

    public DateTime PolicyDate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public double Contribution { get; set; }

    public DateOnly? DueDate { get; set; }

    public DateTime RecordDate { get; set; }

    public int IdRecord { get; set; }
}
