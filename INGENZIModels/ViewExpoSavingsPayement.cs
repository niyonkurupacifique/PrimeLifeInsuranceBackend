using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewExpoSavingsPayement
{
    public int IdRecord { get; set; }

    public string SchemeId { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentChannel { get; set; }

    public DateTime PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string? UserId { get; set; }

    public string IntegratedAcc { get; set; } = null!;

    public int? IntegrationDate { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? ReportingYear { get; set; }

    public string? ReportingMonth { get; set; }
}
