using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewListOfPoliciesContract
{
    public int _ { get; set; }

    public string Policy { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string Bank { get; set; } = null!;

    public string? DatePolicy { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public double LoanAmount { get; set; }

    public double Rate { get; set; }

    public double Fees { get; set; }

    public double DiscountIn { get; set; }

    public double Premium { get; set; }

    public double TotalPremium { get; set; }

    public bool Cancelled { get; set; }

    public string InsuranceCo { get; set; } = null!;

    public string? Reference { get; set; }

    public int? LoanPeriod { get; set; }

    public string? LoanEndDate { get; set; }

    public int? CoverPeriod { get; set; }

    public bool? Retrenchment { get; set; }

    public bool? Approved { get; set; }

    public string? PayChannel { get; set; }

    public string? SalesChannel { get; set; }

    public string? SalesChannelType { get; set; }

    public string? PayFrequency { get; set; }

    public bool? Paid { get; set; }

    public string? LoanType { get; set; }

    public string UserName { get; set; } = null!;

    public double? RetrRate { get; set; }

    public double? LoadedRate { get; set; }

    public string ContactType { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string IdBank { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string PhoneNumber1 { get; set; } = null!;

    public string? Email { get; set; }

    public string Nationality { get; set; } = null!;

    public int? Age { get; set; }

    public DateTime DateOfBirth { get; set; }
}
