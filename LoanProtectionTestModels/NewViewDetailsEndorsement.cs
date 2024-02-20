using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class NewViewDetailsEndorsement
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

    public string SchemeId1 { get; set; } = null!;

    public bool Suspended { get; set; }
}
