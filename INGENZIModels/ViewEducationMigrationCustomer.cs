using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationMigrationCustomer
{
    public int? FirstName { get; set; }

    public int? MiddleName { get; set; }

    public int? LastName { get; set; }

    public string? FullName { get; set; }

    public string? Salutation { get; set; }

    public string? Gender { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? MartialStatus { get; set; }

    public int? Nationality { get; set; }

    public string IdDocumentType { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public int? IssuedProvince { get; set; }

    public int? IssuedDistrict { get; set; }

    public int? IssuedSector { get; set; }

    public int? IssuedCell { get; set; }

    public int? IssuedVillage { get; set; }

    public int? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }

    public string? ResidenceSector { get; set; }

    public string? ResidenceCell { get; set; }

    public string? ResidenceVillage { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber1 { get; set; }

    public int? PhoneNumber2 { get; set; }

    public int? EmployerName { get; set; }

    public int? EmployerFullAdress { get; set; }

    public int? EmployerPhone { get; set; }

    public int? EmployerContactPerson { get; set; }

    public int? EmployerContactPersonNumber { get; set; }

    public int? Category { get; set; }

    public int? CategoryType { get; set; }

    public string CustomerCode { get; set; } = null!;

    public int? CreationDate { get; set; }

    public int Status { get; set; }

    public int? PlaceOfBirth { get; set; }

    public int? UserId { get; set; }

    public int? BranchName { get; set; }

    public int? StreetNumber { get; set; }

    public int? HouseNumber { get; set; }

    public string? Occupation { get; set; }

    public int? NumberOfDependants { get; set; }

    public int? Education { get; set; }

    public int? SocialEconomicClass { get; set; }

    public int? RelatedParty { get; set; }
}
