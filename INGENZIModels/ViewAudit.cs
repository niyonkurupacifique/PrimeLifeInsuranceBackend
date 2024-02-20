using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAudit
{
    public string Expr1 { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public int PolicyTermYears { get; set; }

    public string? PolicyComponentType { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double RiskPremium { get; set; }

    public double? CommissionOnRiskPremium { get; set; }

    public double SavingPremium { get; set; }

    public double TotalPremium { get; set; }

    public string? VendorId { get; set; }

    public DateOnly? CreationDate { get; set; }

    public DateOnly? RecordedDate { get; set; }

    public double? SumInsured { get; set; }

    public double? TotalSumInsured { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string ReferencePay { get; set; } = null!;

    public DateTime PaymentPeriod { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? UserId { get; set; }

    public string? ReportingMonths { get; set; }
}
