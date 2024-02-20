using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCommissionsEducationOld
{
    public string? CustomerCode { get; set; }

    public string? Names { get; set; }

    public string? DistributionPerson { get; set; }

    public string? VendorName { get; set; }

    public string? DistributionChannel { get; set; }

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
}
