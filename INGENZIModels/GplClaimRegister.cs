using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class GplClaimRegister
{
    public int AutoId { get; set; }

    public string? ClaimNumber { get; set; }

    public DateTime? ClaimDate { get; set; }

    public DateTime? PolicyEffectDate { get; set; }

    public DateTime? PolicyMaturityDate { get; set; }

    public string? SchemeNumber { get; set; }

    public string? SchemeName { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimReason { get; set; }

    public int ClaimPercentage { get; set; }

    public double GrossAmount { get; set; }

    public double ClaimAmount { get; set; }

    public bool Closed { get; set; }
}
