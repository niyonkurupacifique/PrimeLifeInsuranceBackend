using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class NewViewStatement
{
    public string Customer { get; set; } = null!;

    public string Policy { get; set; } = null!;

    public string Scheme { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string PaymentMode { get; set; } = null!;

    public DateTime PolicyEffectDate { get; set; }

    public string SchemeId { get; set; } = null!;

    public bool EndorsementMade { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }
}
