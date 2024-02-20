using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewLoanCleanCustomer
{
    public string IdDocumentNumber { get; set; } = null!;

    public string IdDocumentNumber1 { get; set; } = null!;

    public string? Salutation { get; set; }

    public string Gender { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string MartialStatus { get; set; } = null!;

    public string? IssuedProvince { get; set; }

    public string? IssuedDistrict { get; set; }

    public string? IssuedSector { get; set; }

    public string? IssuedCell { get; set; }

    public string? IssuedVillage { get; set; }

    public string? Salutation1 { get; set; }

    public string? Gender1 { get; set; }

    public string? MaritalStatus { get; set; }

    public DateOnly? DateOfBirth1 { get; set; }

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Sector { get; set; }

    public string? Cell { get; set; }

    public string? Village { get; set; }
}
