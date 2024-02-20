using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEpiPolicyWithoutBeneficiary
{
    public string PolicyNumber { get; set; } = null!;

    public DateOnly? CreationDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string Product { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;
}
