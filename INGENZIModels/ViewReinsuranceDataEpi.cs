using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewReinsuranceDataEpi
{
    public string? IdDocumentNumber { get; set; }

    public double? DeathTpdsi { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }
}
