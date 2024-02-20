using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateSchemeEpiRegister
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string? ChannelName { get; set; }
}
