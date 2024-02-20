using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilySavingsRegisterDetail
{
    public string CustomerCode { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string PolicyNumberBase { get; set; } = null!;

    public string PolicyNumberEndorsement { get; set; } = null!;

    public string? InvoiceNumbers { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime InvoiceDate { get; set; }

    public string? PremiumFrequency { get; set; }

    public double SavingPremium { get; set; }

    public double SavingsAnnualInterestRate { get; set; }

    public double SavingTotalContribution { get; set; }

    public double TotalSavings { get; set; }

    public string UserName { get; set; } = null!;

    public int? Period { get; set; }

    public int IdRecord { get; set; }
}
