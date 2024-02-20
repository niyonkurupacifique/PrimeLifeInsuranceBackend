using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllChannel
{
    public int? InRecord { get; set; }

    public string DistributionChannelId { get; set; } = null!;

    public string? LicenceId { get; set; }

    public string? ChannelType { get; set; }

    public string? ChannelName { get; set; }

    public string? ChannelContactTelephone { get; set; }

    public string? ChannelContactEmail { get; set; }

    public string? ChannelAdress { get; set; }

    public DateTime? CreationDate { get; set; }

    public bool? Status { get; set; }

    public string? Username { get; set; }

    public double? CommissionRate { get; set; }

    public string? ContactPerson { get; set; }

    public string Products { get; set; } = null!;
}
