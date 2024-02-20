using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewUpdateScheme
{
    public string CustomerCode { get; set; } = null!;

    public string? FullName { get; set; }

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public string? PaymentChannelDetails { get; set; }

    public string? ChannelDetails { get; set; }

    public string SchemeIdupd { get; set; } = null!;
}
