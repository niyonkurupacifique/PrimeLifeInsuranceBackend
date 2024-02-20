using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class NewViewPolicyDetail
{
    public int _ { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? IdDoc { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string SchemeId { get; set; } = null!;

    public string ParentPolicy { get; set; } = null!;

    public string ChildPolicy { get; set; } = null!;

    public string? Effective { get; set; }

    public string? Maturity { get; set; }

    public double Contribution { get; set; }

    public bool Cancelled { get; set; }

    public double SumAssuredAmount { get; set; }

    public bool EndorsementMade { get; set; }

    public int Term { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public string? Phone { get; set; }

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Sector { get; set; }

    public string? Email { get; set; }

    public string UserName { get; set; } = null!;

    public string? ProposalNumber { get; set; }
}
