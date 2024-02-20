using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdatePolicyPension
{
    public int IdRecord { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? FullName { get; set; }

    public string PolicyNumberChild { get; set; } = null!;

    public double Contribution { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public int? SendContract { get; set; }

    public string? PhoneNumber { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string VendorCode { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public bool EndorsementMade { get; set; }

    public DateTime StartDate { get; set; }

    public string PaymentMode { get; set; } = null!;
}
