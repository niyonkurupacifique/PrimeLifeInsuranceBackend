using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class IngenziDbcustomer
{
    public int IdRecord { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string? Salutation { get; set; }

    public string Gender { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string MartialStatus { get; set; } = null!;

    public string Nationality { get; set; } = null!;

    public string IdDocumentType { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public string? IssuedProvince { get; set; }

    public string? IssuedDistrict { get; set; }

    public string? IssuedSector { get; set; }

    public string? IssuedCell { get; set; }

    public string? IssuedVillage { get; set; }

    public string ResidenceProvince { get; set; } = null!;

    public string ResidenceDistrict { get; set; } = null!;

    public string ResidenceSector { get; set; } = null!;

    public string? ResidenceCell { get; set; }

    public string? ResidenceVillage { get; set; }

    public string? Email { get; set; }

    public string PhoneNumber1 { get; set; } = null!;

    public string? PhoneNumber2 { get; set; }

    public string IdBankBranch { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string? EmployerName { get; set; }

    public string? EmployerFullAdress { get; set; }

    public string? EmployerPhone { get; set; }

    public string? EmployerContactPerson { get; set; }

    public string? EmployerContactPersonNumber { get; set; }

    public string Category { get; set; } = null!;

    public string? ReferenceIfJoint { get; set; }

    public string? CustomerCode { get; set; }
}
