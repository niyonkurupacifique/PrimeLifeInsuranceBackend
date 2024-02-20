using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsPolicyRegister
{
    public int IdRecord { get; set; }

    public string SchemeId { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public double InterestRate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public string BenefitsPaymentsMode { get; set; } = null!;

    public string VendorCode { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool Cancelled { get; set; }

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public string InsuranceBranchCode { get; set; } = null!;

    public double PensionRate { get; set; }

    public string PolicyType { get; set; } = null!;

    public string SumAssuredType { get; set; } = null!;

    public double CommissionRate { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }
}
