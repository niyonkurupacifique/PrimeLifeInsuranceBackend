using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationCommission
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public DateTime PremiumPaymentDate { get; set; }

    public double PremiumAmountPayed { get; set; }

    public double? CommissionAmountDue { get; set; }

    public DateTime? CommissionPaymentDate { get; set; }

    public double? CommissionAmountPayed { get; set; }

    public bool PaymentStatus { get; set; }

    public DateTime RecordDate { get; set; }

    public string? UserId { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }

    public int? ControllerId { get; set; }

    public int? DifferedTerm { get; set; }

    public int? PolicyAgeMonths { get; set; }

    public double? CommissionRate { get; set; }
}
