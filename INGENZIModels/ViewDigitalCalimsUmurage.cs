using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewDigitalCalimsUmurage
{
    public string? SchemeId { get; set; }

    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberEndo { get; set; } = null!;

    public bool? EndorsementMade { get; set; }

    public DateTime? DatePolicy { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? Premium { get; set; }

    public double? InitialPremium { get; set; }

    public string? PaymentFrequency { get; set; }

    public int? Differed { get; set; }

    public string? EndwomentType { get; set; }

    public int? EndwomentNumber { get; set; }

    public string? CycleAssured { get; set; }

    public double? AmtAfterDiffered { get; set; }

    public double? AmtDuringDiffered { get; set; }

    public double? InterestRate { get; set; }

    public string? UserName { get; set; }

    public bool? PolicyStatus { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Maturred { get; set; }

    public int? SendContract { get; set; }

    public string FullName { get; set; } = null!;
}
