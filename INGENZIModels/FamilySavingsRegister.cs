using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilySavingsRegister
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string PolicyNumberBase { get; set; } = null!;

    public string PolicyNumberEndorsement { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int PolicyTermYears { get; set; }

    public string? PolicyComponentType { get; set; }

    public string? ProductCategory { get; set; }

    public string? PremiumFrequency { get; set; }

    public double SavingPremium { get; set; }

    public double SavingsAnnualInterestRate { get; set; }

    public double CommissionRate { get; set; }

    public double SumAssured { get; set; }

    public string? BenefitsPaymentsMode { get; set; }

    public double SavingsManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public double PensionRate { get; set; }

    public string? SumAssuredType { get; set; }

    public bool Cancelled { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public string EndorsementMade { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }
}
