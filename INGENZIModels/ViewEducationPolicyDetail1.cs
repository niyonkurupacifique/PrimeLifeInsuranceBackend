using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationPolicyDetail1
{
    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberEndo { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public bool? EndorsementMade { get; set; }

    public DateTime? DatePolicy { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? Premium { get; set; }

    public double? InitialPremium { get; set; }

    public string? PaymentFrequency { get; set; }

    public string? SchemeId { get; set; }

    public string? PaymentSource { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? IdDocumentNumber { get; set; }

    public int? Differed { get; set; }

    public int? EndwomentNumber { get; set; }

    public string? Gender { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public bool? Surrendered { get; set; }

    public bool? Maturred { get; set; }
}
