using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllPolicyWithoutBeneficiariesAndProposalP
{
    public string PolicyNumber { get; set; } = null!;

    public DateTime? DatePolicy { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Product { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string? ProposalNumber { get; set; }
}
