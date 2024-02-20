using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSingleInvoiceAll
{
    public string CustomerCode { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? FullNames { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public double? Contribution { get; set; }

    public string PolicyType { get; set; } = null!;

    public string IdentityRecord { get; set; } = null!;

    public string? SchemeId { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public DateTime? DueDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDateEndo { get; set; }

    public string? PhoneNumber { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? SchemeName { get; set; }
}
