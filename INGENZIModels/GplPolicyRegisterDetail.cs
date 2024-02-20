using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class GplPolicyRegisterDetail
{
    public int IdRecord { get; set; }

    public string PolicyNumberBase { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string CustomerCodeMember { get; set; } = null!;

    public double Salary { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? CommissionAmount { get; set; }

    public double? ManagementAmount { get; set; }

    public double? DeathTpdamount { get; set; }

    public double? Ppdamount { get; set; }

    public double? LossOfIncomeAmount { get; set; }

    public double? DreadDiseasesAmount { get; set; }

    public double? FuneralFeesAmount { get; set; }

    public double? MedicalExpensesAmount { get; set; }

    public double? AccidentalDeathAmount { get; set; }

    public double? DeathTpdspouseAmount { get; set; }

    public double? PpdspouseAmount { get; set; }

    public double? DreadDiseasesSpouseAmount { get; set; }

    public double? FuneralFeesSpouseAmount { get; set; }

    public double? MedicalExpensesSpouseAmount { get; set; }

    public double? AccidentalDeathSpouseAmount { get; set; }

    public double? FuneralFeesKidsAmount { get; set; }

    public double? MedicalExpensesKidsAmount { get; set; }

    public double? AccidentalDeathKidsAmount { get; set; }

    public double? DeathTpdpremium { get; set; }

    public double? Ppdpremium { get; set; }

    public double? LossOfIncomePremium { get; set; }

    public double? DreadDiseasesPremium { get; set; }

    public double? FuneralFeesPremium { get; set; }

    public double? MedicalExpensesPremium { get; set; }

    public double? AccidentalDeathPremium { get; set; }

    public double? TotalPremium { get; set; }

    public bool? Claimed { get; set; }

    public bool? Cancelled { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? UserName { get; set; }
}
