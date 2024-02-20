using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdatePolicyFamily
{
    public int IdRecord { get; set; }

    public string? CustomerCode { get; set; }

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public double TotalPremium { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public int? SendContract { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? VendorId { get; set; }
}
