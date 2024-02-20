using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSavingsPaymentEndoDdg
{
    public string? PhoneNumber { get; set; }

    public string SchemeName { get; set; } = null!;

    public string ProductType { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public DateOnly? DateOfBirth { get; set; }

    public string PolicyNumberMain { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public DateTime EffectiveDate { get; set; }

    public DateTime MaturityDate { get; set; }

    public int PolicyTermInYear { get; set; }

    public double PolicyTotalSumInsured { get; set; }

    public string PremiumFrequency { get; set; } = null!;

    public DateTime? PremiumPaymentDate { get; set; }

    public double? TotalPremium { get; set; }

    public int PrimeNetInvesti { get; set; }

    public double TauxGaranti { get; set; }

    public int TaxeOuQuitancemet { get; set; }

    public double TxFraisGestContrat { get; set; }

    public double XFraisFractionnement { get; set; }

    public double TxFraisAcquisition { get; set; }

    public int TxFraisSurEncours { get; set; }
}
