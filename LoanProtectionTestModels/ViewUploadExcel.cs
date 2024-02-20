using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewUploadExcel
{
    public int? IntegrationDate { get; set; }

    public string? SchemeNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string? PaymentChannel { get; set; }

    public string? PaymentSource { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string Comments { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string IntegratedAcc { get; set; } = null!;

    public int? Expr1 { get; set; }

    public string? CustomerCode { get; set; }

    public string ReportingYear { get; set; } = null!;

    public string ReportingMonth { get; set; } = null!;
}
