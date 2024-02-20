using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllUsedChannel
{
    public string DistributionChannelId { get; set; } = null!;

    public string? ChannelType { get; set; }

    public string? ChannelName { get; set; }

    public bool? Status { get; set; }

    public string Products { get; set; } = null!;

    public string? Codevendors { get; set; }
}
