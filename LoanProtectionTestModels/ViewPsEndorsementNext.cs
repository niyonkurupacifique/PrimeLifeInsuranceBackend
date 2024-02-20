using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPsEndorsementNext
{
    public string? NexEndorsement { get; set; }

    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public bool EndorsementMade { get; set; }
}
