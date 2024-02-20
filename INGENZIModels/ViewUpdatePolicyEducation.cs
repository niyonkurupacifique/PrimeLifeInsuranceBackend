using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdatePolicyEducation
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double? Premium { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public int? SendContract { get; set; }

    public int IdRecordDetails { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? SchemeId { get; set; }

    public bool? EndorsementMade { get; set; }
}
