using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewInvalidSchemeIdSaving
{
    public string SchemeId { get; set; } = null!;

    public string SchemeIdSavings { get; set; } = null!;

    public string? ChannelName { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string BenefitsPaymentsMode { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public bool Cancelled { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string? FirstName { get; set; }

    public string PolicyType { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }
}
