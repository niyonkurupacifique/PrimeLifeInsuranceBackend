using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationClaimsUpdate
{
    public string PolicyNumber { get; set; } = null!;

    public double? ClaimAmountDue { get; set; }

    public double? ClaimSettlementAmount { get; set; }
}
