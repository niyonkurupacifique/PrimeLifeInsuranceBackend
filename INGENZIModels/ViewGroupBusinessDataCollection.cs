using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewGroupBusinessDataCollection
{
    public int? Periodyear { get; set; }

    public string CompanyName { get; set; } = null!;

    public string NameOfGroupSchemeCovered { get; set; } = null!;

    public string GroupPolicyNumber { get; set; } = null!;

    public string LifeNumber { get; set; } = null!;

    public string NameOfPolicyholder { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public string? Sex { get; set; }

    public int CriticalIllnessRider { get; set; }

    public int LastExpenseFuneralCoverRider { get; set; }

    public int TotalAndPermanentDisabilityCover { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public double SumsAssuredMainBenefitRwf { get; set; }

    public int SumsAssuredCriticalIllnessCoverRiderBenefitRwf { get; set; }

    public int SumsAssuredLastExpenseFuneralCoverRiderBenefit { get; set; }

    public double SumsAssuredTotalAndPermanentDisabilityRiderRwf { get; set; }

    public double AnnualMainBenefitPremium { get; set; }

    public int ExtraAnnualPremiumMainBenefitForImpairedLives { get; set; }

    public int AnnualPremiumCriticalIllnessCoverRiderBenefit { get; set; }

    public int AnnualPremiumLastExpenseFuneralCoverRider { get; set; }

    public double AnnualPremiumTotalAndPermanentDisabilityRider { get; set; }

    public string? FrequencyOfPremiumPayment { get; set; }

    public int LoanInterestRate { get; set; }

    public DateTime? DateOfBirthOfBirth { get; set; }

    public DateTime CoverStartDateOfPolicy { get; set; }

    public DateTime CoverEndDateOfPolicy { get; set; }

    public DateTime ExitDateOfTheLifeAssuredDate { get; set; }
}
