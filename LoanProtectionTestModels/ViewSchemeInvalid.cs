using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSchemeInvalid
{
    public int IdRecord { get; set; }

    public string SchemeId { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime PolicyDate { get; set; }

    public string VendorCode { get; set; } = null!;

    public DateTime RecordDate { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }
}
