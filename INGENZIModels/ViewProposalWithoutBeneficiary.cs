using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewProposalWithoutBeneficiary
{
    public string ProposalNumber { get; set; } = null!;

    public DateTime? ProposalDate { get; set; }

    public DateOnly? DueDate { get; set; }
}
