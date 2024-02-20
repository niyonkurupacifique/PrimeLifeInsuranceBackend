using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewFamilyPolicyWithoutBeneficiary
{
    public string PolicyNumber { get; set; } = null!;

    public DateOnly? CreationDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public string? ProductCategory { get; set; }

    public string PolicyStatus { get; set; } = null!;
}
