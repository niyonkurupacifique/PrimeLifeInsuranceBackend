using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class CustomerIdentification
{
    public int IdRecord { get; set; }

    public string? CustomerType { get; set; }

    public string? IdDocumentType { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Salutation { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Nationality { get; set; }

    public string? IssuedProvince { get; set; }

    public string? IssuedDistrict { get; set; }

    public string? IssuedSector { get; set; }

    public string? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }

    public string? ResidenceSector { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string CustomerCode { get; set; } = null!;
}
