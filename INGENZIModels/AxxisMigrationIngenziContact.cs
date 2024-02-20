using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class AxxisMigrationIngenziContact
{
    public string? MigrationCode { get; set; }

    public string? Name { get; set; }

    public string? MiddleName { get; set; }

    public string? Surname1 { get; set; }

    public string IsPerson { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Title { get; set; }

    public string? Gender { get; set; }

    public DateTime? Birth { get; set; }

    public string? MartialStatus { get; set; }

    public string? Nationality { get; set; }

    public string? IdType { get; set; }

    public string? Nif { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Sector { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }

    public string? ResidenceSector { get; set; }

    public string? ResidenceCell { get; set; }

    public string? ResidenceVillage { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Phone1 { get; set; }

    public string? EmployerName { get; set; }

    public string? EmployerFullAddress { get; set; }

    public string? EmployerPhone { get; set; }

    public string? EmployerContactPerson { get; set; }

    public string? EmployerContactPersonNumber { get; set; }

    public string? Category { get; set; }

    public string? CategoryType { get; set; }

    public int? Zip { get; set; }

    public DateOnly? Created { get; set; }

    public bool Inactive { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? UserId { get; set; }

    public string? BranchName { get; set; }

    public int? BranchId { get; set; }

    public string? StreetNumber { get; set; }

    public string? HouseNumber { get; set; }

    public string? OccupationId { get; set; }

    public int? NumberOfDependents { get; set; }

    public string? Education { get; set; }

    public int? SocialEconomicClass { get; set; }

    public string? RelatedParty { get; set; }

    public int? BankAccount { get; set; }

    public int? ReferenceIfJoint { get; set; }
}
