using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEligiblePoliciesSavingsEndoY
{
    public string? CustomerCode { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Names { get; set; }

    public string? PolicyNumber { get; set; }

    public string EndorsementNumber { get; set; } = null!;

    public double? Contribution { get; set; }

    public string? PolicyType { get; set; }

    public string? PolicyStatus { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public string? SchemeId { get; set; }

    public string? SchemeName { get; set; }

    public string? IdentityRecord { get; set; }
}
