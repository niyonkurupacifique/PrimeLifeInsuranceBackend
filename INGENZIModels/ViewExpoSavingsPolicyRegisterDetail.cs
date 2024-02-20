using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewExpoSavingsPolicyRegisterDetail
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double SavingPremium { get; set; }

    public int PolicyTermYears { get; set; }

    public DateTime RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool Cancelled { get; set; }

    public double SumAssured { get; set; }

    public string EndorsementMade { get; set; } = null!;

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }
}
