using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class NewViewPolicyRegister
{
    public int _ { get; set; }

    public string SchemeName { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string Policy { get; set; } = null!;

    public string? PolicyDate { get; set; }

    public double InterestRate { get; set; }

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public double CommissionsRate { get; set; }

    public string PremiumFrequencyPay { get; set; } = null!;

    public bool Cancelled { get; set; }

    public string Type { get; set; } = null!;

    public string BenefitPayMode { get; set; } = null!;

    public string SumAssured { get; set; } = null!;

    public string? VendorName { get; set; }

    public string? Names { get; set; }

    public string? IdNumber { get; set; }

    public string? Email { get; set; }

    public string UserName { get; set; } = null!;
}
