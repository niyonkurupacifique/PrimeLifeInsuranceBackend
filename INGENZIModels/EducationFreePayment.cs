using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationFreePayment
{
    public int IdRecord { get; set; }

    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public DateTime? PaymentDate { get; set; }

    public DateTime? ValueDate { get; set; }

    public double? AmountPayed { get; set; }

    public double? AmtDuringDiffered { get; set; }

    public double? AmtAfterDiffered { get; set; }

    public int? XAge { get; set; }

    public int? NDuration { get; set; }

    public double? Commission { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? UserId { get; set; }

    public bool IntegratedAcc { get; set; }

    public DateTime? IntegrationDate { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }
}
