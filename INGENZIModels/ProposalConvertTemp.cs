using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ProposalConvertTemp
{
    public int IdRecord { get; set; }

    public string ProposalNumber { get; set; } = null!;

    public double ProposalAmount { get; set; }

    public DateTime PaymentDate { get; set; }

    public DateTime EffectiveDate { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? RecordedDate { get; set; }
}
