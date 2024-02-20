using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionOldPolicy
{
    public string? CustomerCode { get; set; }

    public string? FirstName { get; set; }

    public string MiddleName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? Salutation { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? MartialStatus { get; set; }

    public string? Nationality { get; set; }

    public string? IdDocumentType { get; set; }

    public string? NationalIdNumber { get; set; }

    public string ResidenceProvince { get; set; } = null!;

    public string ResidenceDistrict { get; set; } = null!;

    public string ResidenceSector { get; set; } = null!;

    public string ResidenceCell { get; set; } = null!;

    public string ResidenceVillage { get; set; } = null!;

    public string PhoneNumber1 { get; set; } = null!;

    public string? IdBankBranch { get; set; }

    public string AccountNumber { get; set; } = null!;

    public string Category { get; set; } = null!;
}
