using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewExpoSavingsPolicyRegister
{
    public int IdRecord { get; set; }

    public string SchemeId { get; set; } = null!;

    public string? ChannelName { get; set; }

    public string PolicyNumberBase { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public double SavingsAnnualInterestRate { get; set; }

    public string? PremiumFrequency { get; set; }

    public string? BenefitsPaymentsMode { get; set; }

    public string? VendorCode { get; set; }

    public DateTime RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool Cancelled { get; set; }

    public double SavingsManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public string InsuranceBranchCode { get; set; } = null!;

    public double PensionRate { get; set; }

    public string PolicyType { get; set; } = null!;

    public string? SumAssuredType { get; set; }

    public double CommissionRate { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }
}
