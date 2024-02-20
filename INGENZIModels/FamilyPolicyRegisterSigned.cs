using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyPolicyRegisterSigned
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public bool? Signed { get; set; }

    public DateTime? SignedDate { get; set; }
}
