using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationUpdateScheme
{
    public string PolicyNumber { get; set; } = null!;

    public string? SchemeId { get; set; }

    public string? PaymentSource { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }

    public bool? Status { get; set; }
}
