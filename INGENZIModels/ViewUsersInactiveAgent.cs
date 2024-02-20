using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUsersInactiveAgent
{
    public int IdRecord { get; set; }

    public string Names { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? ChannelId { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelType { get; set; }

    public string? ChannelName { get; set; }
}
