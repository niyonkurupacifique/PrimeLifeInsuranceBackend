using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationPayement
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string? UserId { get; set; }

    public bool? IntegratedAcc { get; set; }

    public DateOnly? IntegrationDate { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? RecordedDate { get; set; }
}
