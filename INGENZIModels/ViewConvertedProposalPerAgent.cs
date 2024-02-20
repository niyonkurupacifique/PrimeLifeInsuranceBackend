using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewConvertedProposalPerAgent
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string ProposalNumber { get; set; } = null!;

    public string? Product { get; set; }

    public double Premium { get; set; }

    public string? PremiumFrequency { get; set; }

    public string? BusinessChannel { get; set; }

    public string? DistributionChannelId { get; set; }

    public string? ChannelName { get; set; }

    public string? PaymentMode { get; set; }

    public string? Institutions { get; set; }

    public string? DateProposal { get; set; }

    public string? DateConverted { get; set; }

    public bool? Converted { get; set; }

    public string? PolicyNumber { get; set; }

    public string? SavingPolicy { get; set; }

    public string? UserName { get; set; }

    public DateTime? ConvertedDate { get; set; }

    public string? UserNamePs { get; set; }
}
