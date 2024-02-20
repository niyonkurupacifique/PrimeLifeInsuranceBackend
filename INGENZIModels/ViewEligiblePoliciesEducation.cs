using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEligiblePoliciesEducation
{
    public string CustomerCode { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberEndo { get; set; } = null!;

    public double? Premium { get; set; }

    public string Product { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }

    public double? TotalPremiumDue { get; set; }

    public double? TotalAmountPaid { get; set; }

    public double? Outstanding { get; set; }

    public DateTime? MaxPaymentDate { get; set; }

    public string? PhoneNumber1 { get; set; }
}
