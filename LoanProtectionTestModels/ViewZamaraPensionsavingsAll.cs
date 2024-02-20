using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewZamaraPensionsavingsAll
{
    public string? SchemeName { get; set; }

    public string? CustomerCode { get; set; }

    public string? FullName { get; set; }

    public string? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? PolicyNumber { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public int? ProfitSharing { get; set; }

    public int? Bonus { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public double Contribution { get; set; }

    public double AnnualPremium { get; set; }

    public double CommissionRate { get; set; }

    public double InterestRate { get; set; }

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public string? MaxDateFormated { get; set; }

    public int? Term { get; set; }

    public double? SumAssured { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Suspended { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? MaxPaymentDate { get; set; }

    public bool EndorsementMade { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string VendorCode { get; set; } = null!;

    public string? VendorName { get; set; }

    public DateTime? LastWithdrawalDate { get; set; }

    public DateTime? NextWithdrawalDate { get; set; }

    public string? UserName { get; set; }

    public double? TotalContibution { get; set; }

    public double? SurrendedAmount { get; set; }

    public double? OutStandingContributions { get; set; }

    public double? SurrenderValue { get; set; }

    public string? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }
}
