using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationPolicyWithoutPayment
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? SchemeId { get; set; }

    public string? Expr1 { get; set; }

    public string? Expr2 { get; set; }

    public int? Differed { get; set; }

    public string PolicyComponentType { get; set; } = null!;

    public string Product { get; set; } = null!;

    public string? PaymentFrequency { get; set; }

    public double? Premium { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? DatePolicy { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string? SchemeName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }
}
