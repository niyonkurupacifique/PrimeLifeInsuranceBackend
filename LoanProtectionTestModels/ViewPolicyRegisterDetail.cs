using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPolicyRegisterDetail
{
    public int _ { get; set; }

    public string? CustomerCode { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string? Effective { get; set; }

    public string? Maturity { get; set; }

    public int Term { get; set; }

    public double Contribution { get; set; }

    public double? Rate { get; set; }

    public string? RecordDate { get; set; }

    public bool Cancelled { get; set; }

    public string RecordedBy { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? SchemNumber { get; set; }

    public double? SumAssured { get; set; }

    public string IdDocumentNumber { get; set; } = null!;

    public string? EndorsementType { get; set; }
}
