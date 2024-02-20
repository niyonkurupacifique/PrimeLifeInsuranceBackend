using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewUpdatePatmentChannel
{
    public string PolicyNumberChild { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string SchemeId { get; set; } = null!;

    public string SchemeName { get; set; } = null!;

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }
}
