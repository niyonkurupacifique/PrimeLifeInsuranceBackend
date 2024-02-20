using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateSchemeEpi
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string? ChannelName { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? SchemeIdn { get; set; }
}
