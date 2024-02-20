using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewFamilySignedReturned
{
    public string PolicyNumber { get; set; } = null!;

    public DateOnly? CreationDate { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public bool? Signed { get; set; }

    public DateTime? SignedDate { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string? ProductCategory { get; set; }
}
