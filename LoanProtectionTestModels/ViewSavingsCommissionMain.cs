using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSavingsCommissionMain
{
    public int IdRecord { get; set; }

    public int Term { get; set; }

    public string PolicyType { get; set; } = null!;

    public int? PolicyAgeMonths { get; set; }

    public double? CommissionAmountDue { get; set; }

    public decimal? CommissionRate { get; set; }

    public string? SchemeNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public string? UserId { get; set; }

    public bool? IntegratedAcc { get; set; }

    public DateOnly? IntegrationDate { get; set; }

    public string? CustomerCode { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }
}
