using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSchemeUpdateName
{
    public string SchemeId { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string? PaymentChannelMain { get; set; }

    public string? PaymentChannelDetails { get; set; }

    public string? ChannelMain { get; set; }

    public string? ChannelDetails { get; set; }
}
