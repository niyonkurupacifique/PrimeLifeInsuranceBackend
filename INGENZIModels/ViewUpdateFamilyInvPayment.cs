using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateFamilyInvPayment
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberInv { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string ReferencePayInv { get; set; } = null!;

    public DateTime PaymentDate { get; set; }

    public DateTime PaymentPeriod { get; set; }

    public double AmountPayed { get; set; }
}
