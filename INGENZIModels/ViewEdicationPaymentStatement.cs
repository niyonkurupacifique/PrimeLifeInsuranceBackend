using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEdicationPaymentStatement
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string? SchemeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Differed { get; set; }

    public string? EndwomentType { get; set; }

    public string? CycleAssured { get; set; }

    public string? PaymentFrequency { get; set; }

    public double? Premium { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? DatePolicy { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string ReferencePay { get; set; } = null!;

    public DateTime PaymentPeriod { get; set; }

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public double? Premiums { get; set; }

    public string? Comments { get; set; }
}
