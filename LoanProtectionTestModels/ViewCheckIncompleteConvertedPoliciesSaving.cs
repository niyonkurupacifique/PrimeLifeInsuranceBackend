using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewCheckIncompleteConvertedPoliciesSaving
{
    public string? CustomerCode { get; set; }

    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string SchemeId { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public DateTime RecordDate { get; set; }

    public string? SchemeName { get; set; }

    public string ProposalNumber { get; set; } = null!;

    public bool Cancelled { get; set; }
}
