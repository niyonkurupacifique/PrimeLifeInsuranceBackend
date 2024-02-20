using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationPolicyRegisterMain
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string? SchemeId { get; set; }

    public DateTime? StartDate { get; set; }

    public string? ChannelType { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? PrimeBranch { get; set; }

    public string? UserName { get; set; }

    public bool? PolicyStatus { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Maturred { get; set; }

    public string? SubscriberId { get; set; }

    public string? Relationship { get; set; }

    public DateTime? RecordedDate { get; set; }
}
