using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyEpiCommission
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public DateTime PremiumPaymentDate { get; set; }

    public double PremiumAmountPayed { get; set; }

    public double CommissionAmountDue { get; set; }

    public DateTime? CommissionPaymentDate { get; set; }

    public double? CommissionAmountPayed { get; set; }

    public bool PaymentStatus { get; set; }

    public DateTime RecordDate { get; set; }

    public string? UserId { get; set; }

    public string? ReportingMonths { get; set; }

    public int? ControllerId { get; set; }

    public int? DifferedTerm { get; set; }

    public int? PolicyAgeMonths { get; set; }

    public double? CommissionRate { get; set; }
}
