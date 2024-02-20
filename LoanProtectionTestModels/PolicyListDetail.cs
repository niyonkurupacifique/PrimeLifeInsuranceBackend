using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class PolicyListDetail
{
    public string? SchemNumber { get; set; }

    public string? PolicyNumber { get; set; }

    public string? IdDocumentNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? Contribution { get; set; }

    public double? Term { get; set; }

    public double? Rate { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? UserName { get; set; }

    public double? Cancelled { get; set; }

    public double? SumAssured { get; set; }

    public string? CustomerCode { get; set; }

    public double? EndorsementMade { get; set; }

    public string? EndorsementType { get; set; }
}
