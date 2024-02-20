using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewAllInvoicesPsMainEndoDetail
{
    public string? NexEndorsement { get; set; }

    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDateEndo { get; set; }

    public double Contribution { get; set; }

    public double ContributionInvoice { get; set; }

    public bool EndorsementMade { get; set; }

    public bool Cancelled { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public DateOnly? DueDate { get; set; }

    public string IdentityRecord { get; set; } = null!;
}
