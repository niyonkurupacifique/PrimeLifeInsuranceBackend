using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewUpdateSchemeMain
{
    public string CustomerCode { get; set; } = null!;

    public string? FullName { get; set; }

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public string? PaymentChannel { get; set; }

    public string? ChannelInDetails { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string SchemeIdUpd { get; set; } = null!;

    public string? PaymentChannelMain { get; set; }

    public string? ChannelMain { get; set; }
}
