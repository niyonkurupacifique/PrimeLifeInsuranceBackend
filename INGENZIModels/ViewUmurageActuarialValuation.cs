using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUmurageActuarialValuation
{
    public string? ChannelName { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public int ProfitSharing { get; set; }

    public string LifeAssuredName { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public double? EndowmentAmountDuringDifferedPeriod { get; set; }

    public double? EndowmentAmountAfterDifferedPeriod { get; set; }

    public int Bonus { get; set; }

    public string? PremiumPaymentFrequency { get; set; }

    public double? PremiumAmountAsPerFrequency { get; set; }

    public int AnnualPremium { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDateOfPremiumPayment { get; set; }

    public DateTime? EndDateOfEndowmentPayment { get; set; }

    public int? PolicyTerm { get; set; }

    public int? Differed { get; set; }

    public int? EndwomentNumber { get; set; }

    public int? CommissionRate { get; set; }

    public decimal InterestRate { get; set; }

    public int ManagementFee { get; set; }

    public int InstallementFee { get; set; }

    public DateTime? MaxDateFormated { get; set; }

    public double? TotalPaidAmount { get; set; }

    public double? Premiums { get; set; }

    public int OutstandingAmount { get; set; }

    public DateTime? MaxDate { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? PhoneNumber1 { get; set; }
}
