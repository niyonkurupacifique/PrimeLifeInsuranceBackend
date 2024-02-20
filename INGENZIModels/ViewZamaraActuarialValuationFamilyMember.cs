using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewZamaraActuarialValuationFamilyMember
{
    public string? SchemeName { get; set; }

    public string? CustomerCode { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public int? ProfitSharing { get; set; }

    public string? LifeAssuredName { get; set; }

    public string? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public double? PolicyholderSumInsured { get; set; }

    public double? TotalSumInsuredForOtherFamilyMembers { get; set; }

    public int? Bonus { get; set; }

    public string? PremiumPaymentFrequency { get; set; }

    public double PremiumAmountAsPerFrequency { get; set; }

    public double AnnualPremium { get; set; }

    public string? EffectiveDate { get; set; }

    public string? MaturityDateFormated { get; set; }

    public int PolicyTerm { get; set; }

    public int CommissionRate { get; set; }

    public int ManagementFee { get; set; }

    public int InstallementFee { get; set; }

    public string? MaxDateFormated { get; set; }

    public double? TotalPaidAmount { get; set; }

    public double? TotalAmounts { get; set; }

    public double? OutstandingAmount { get; set; }

    public DateTime? MaxDate { get; set; }

    public string? ChannelName { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? MemberFullName { get; set; }

    public string? MemberDob { get; set; }

    public string? GenderMember { get; set; }

    public string? Relationship { get; set; }

    public bool? Status { get; set; }

    public double? SumInsured { get; set; }

    public string? NextOfKin { get; set; }

    public string? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }
}
