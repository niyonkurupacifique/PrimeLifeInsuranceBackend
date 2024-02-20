using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewToApprouve
{
    public string PolicyNumber { get; set; } = null!;

    public string? PolicyDate { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public string? Names { get; set; }

    public string IdDoc { get; set; } = null!;

    public string? LoanAmount { get; set; }

    public double InsuranceRate { get; set; }

    public double FeesAmount { get; set; }

    public string? PremiumAmount { get; set; }

    public string? TotalPremium { get; set; }

    public string IdBranch { get; set; } = null!;

    public string User { get; set; } = null!;

    public bool Cancelled { get; set; }

    public DateTime SearchDate { get; set; }

    public bool? Approved { get; set; }

    public double Amt { get; set; }

    public string CustomerCode { get; set; } = null!;

    public double NetPremium { get; set; }

    public double? Bancassurance { get; set; }

    public double? AgentComm { get; set; }

    public string? AgentId { get; set; }

    public string? AgentName { get; set; }
}
