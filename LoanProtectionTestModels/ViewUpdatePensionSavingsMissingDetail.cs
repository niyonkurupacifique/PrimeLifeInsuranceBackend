using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewUpdatePensionSavingsMissingDetail
{
    public int? IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? Contribution { get; set; }

    public int Term { get; set; }

    public DateTime RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public string Cancelled { get; set; } = null!;

    public int SumAssured { get; set; }

    public string EndorsementMade { get; set; } = null!;

    public string Surrendered { get; set; } = null!;

    public string Suspended { get; set; } = null!;

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public int? SendContract { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }
}
