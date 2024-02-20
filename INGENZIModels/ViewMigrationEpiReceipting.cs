using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMigrationEpiReceipting
{
    public string? CustomerCode { get; set; }

    public string? PolicyNumber { get; set; }

    public string? ReferencePay { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? Branch { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public DateTime? RecordDate { get; set; }

    public string? UserId { get; set; }

    public string? ReportingMonths { get; set; }
}
