using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilySavingsDatum
{
    public string? SchemeName { get; set; }

    public string? PolicyNumberBase { get; set; }

    public string? PolicyNumberEndorsement { get; set; }

    public string? CustomerCode { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? SavingPremium { get; set; }

    public double? PolicyTermYears { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string? Source { get; set; }

    public DateTime? PaymentDate { get; set; }
}
