using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewZamaraActuarialValuationUmurage
{
    public string? SchemeName { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public int? ProfitSharing { get; set; }

    public string LifeAssuredName { get; set; } = null!;

    public string? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public double? EndowmentAmountDuringDifferedPeriod { get; set; }

    public double? EndowmentAmountAfterDifferedPeriod { get; set; }

    public int? Bonus { get; set; }

    public string? PremiumPaymentFrequency { get; set; }

    public double? PremiumAmountAsPerFrequency { get; set; }

    public double? AnnualPremium { get; set; }

    public string? EffectiveDate { get; set; }

    public string? EndDateOfPremiumPayment { get; set; }

    public string? EndDateOfEndowmentPayment { get; set; }

    public int? PolicyTerm { get; set; }

    public int? PremiumPayingTerm { get; set; }

    public int? EndowmentNumberInYear { get; set; }

    public decimal? CommissionRate { get; set; }

    public double? InterestRate { get; set; }

    public int ManagementFee { get; set; }

    public int InstallementFee { get; set; }

    public string? MaxDateFormated { get; set; }

    public double? TotalPaidAmount { get; set; }

    public double? Premiums { get; set; }

    public int OutstandingAmount { get; set; }

    public DateTime? MaxDate { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }
}
