using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewListSalesAgent
{
    public int InRecord { get; set; }

    public string DistributionChannelId { get; set; } = null!;

    public string? Idnumber { get; set; }

    public string? ChannelName { get; set; }

    public string? ChannelContactTelephone { get; set; }

    public string? ChannelContactEmail { get; set; }

    public string? DocId { get; set; }

    public string? DocumentRequired { get; set; }

    public DateTime? SubmisionDate { get; set; }

    public DateTime? DueRenewalDate { get; set; }

    public bool? DocumentStatus { get; set; }

    public bool Status { get; set; }
}
