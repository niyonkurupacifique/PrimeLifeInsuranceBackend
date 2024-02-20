using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMomoNotAllocatedIkimina
{
    public int? IdRecord { get; set; }

    public string SchemeNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string? ReferencePay { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public DateTime RecordedDate { get; set; }

    public double? Amount { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public int IntegratedAcc { get; set; }

    public int? IntegrationDate { get; set; }

    public string CustomerCode { get; set; } = null!;

    public int ReportingYear { get; set; }

    public int ReportingMonth { get; set; }
}
