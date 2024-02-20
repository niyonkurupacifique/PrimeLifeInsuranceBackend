using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewIkiminaAllPolicy
{
    public string CustomerCode { get; set; } = null!;

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? PhoneNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public DateTime RecordDate { get; set; }

    public string? Channel { get; set; }

    public bool Cancelled { get; set; }

    public string? CreationYearMonths { get; set; }

    public string SchemeId { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }
}
