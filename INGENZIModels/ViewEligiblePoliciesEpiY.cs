using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEligiblePoliciesEpiY
{
    public string? CustomerCode { get; set; }

    public string? IdDocument { get; set; }

    public string Names { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string EndorsmentNumber { get; set; } = null!;

    public double Premium { get; set; }

    public string Product { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string SchemeId { get; set; } = null!;

    public string? ChannelName { get; set; }

    public string? ReferencePay { get; set; }
}
