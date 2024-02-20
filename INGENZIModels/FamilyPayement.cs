using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyPayement
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public string Branch { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string ProofOfPayment { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public string? UserId { get; set; }

    public string? ReportingMonths { get; set; }
}
