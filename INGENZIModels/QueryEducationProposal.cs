using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class QueryEducationProposal
{
    public int IdRecord { get; set; }

    public string? CustomerCode { get; set; }

    public string? Product { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime? DatePolicy { get; set; }

    public double? Premium { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Differed { get; set; }

    public string? DistributionChannel { get; set; }

    public string? DistributionPerson { get; set; }

    public string? EndwomentType { get; set; }

    public int? EndwomentNumber { get; set; }

    public string? CycleAssured { get; set; }

    public double? AmtAfterDiffered { get; set; }

    public double? AmtDuringDiffered { get; set; }

    public string? PaymentFrequency { get; set; }

    public double? InterestRate { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? Branch { get; set; }

    public string? UserId { get; set; }

    public bool? Active { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Maturred { get; set; }

    public string? IdNumber { get; set; }
}
