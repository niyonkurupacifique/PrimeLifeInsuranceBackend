using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsEndorsementRegister
{
    public int IdRecord { get; set; }

    public string SchemeId { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateOnly PolicyDate { get; set; }

    public string PolicyNumberChild { get; set; } = null!;

    public string EndorsementNumber { get; set; } = null!;

    public DateOnly EndorsementDate { get; set; }

    public double InterestRate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public string BenefitsPaymentsMode { get; set; } = null!;

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public string PolicyType { get; set; } = null!;

    public string SumAssuredType { get; set; } = null!;

    public double CommissionRate { get; set; }

    public string EndorsementType { get; set; } = null!;

    public bool IsCancelled { get; set; }

    public double OpeningBalance { get; set; }
}
