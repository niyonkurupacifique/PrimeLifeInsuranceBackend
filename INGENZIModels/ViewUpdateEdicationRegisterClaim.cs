using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateEdicationRegisterClaim
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime? PolicyDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public bool? PolicyStatus { get; set; }

    public bool? Surrendered { get; set; }

    public bool? Maturred { get; set; }

    public double? Premium { get; set; }
}
