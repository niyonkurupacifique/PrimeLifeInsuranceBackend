using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewReinsuranceDataGpl
{
    public string? IdDocumentNumber { get; set; }

    public double DeathSumInsured { get; set; }

    public string PolicyNumberDetails { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }
}
