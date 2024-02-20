using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMomoNotAllocatedEducation
{
    public string? SchemId { get; set; }

    public string AccountNo { get; set; } = null!;

    public string? ReferencePay { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public DateTime RecordedDate { get; set; }

    public double? Amount { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public int IntegratedAcc { get; set; }

    public int? IntegrationDate { get; set; }

    public string CustomerId { get; set; } = null!;

    public int ReportingYear { get; set; }

    public int ReportingMonth { get; set; }

    public string? PhoneNumber1 { get; set; }
}
