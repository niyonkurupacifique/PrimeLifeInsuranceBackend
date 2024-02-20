using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace c_.INGENZIModels;

public partial class Customer
{
   public int IdRecord{get;set;}

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string FullName { get; set; } = null!;

    public string? Salutation { get; set; }

    public string? Gender { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string? MartialStatus { get; set; }

    public string? Nationality { get; set; }

    public string? IdDocumentType { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? IssuedProvince { get; set; }

    public string? IssuedDistrict { get; set; }

    public string? IssuedSector { get; set; }

    public string? IssuedCell { get; set; }

    public string? IssuedVillage { get; set; }

    public string? ResidenceProvince { get; set; }

    public string? ResidenceDistrict { get; set; }

    public string? ResidenceSector { get; set; }

    public string? ResidenceCell { get; set; }

    public string? ResidenceVillage { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? PhoneNumber2 { get; set; }

    public string? EmployerName { get; set; }

    public string? EmployerFullAdress { get; set; }

    public string? EmployerPhone { get; set; }

    public string? EmployerContactPerson { get; set; }

    public string? EmployerContactPersonNumber { get; set; }

    public string? Category { get; set; }

    public string? CategoryType { get; set; }

    public string CustomerCode { get; set; } = null!;

    public DateTime? CreationDate { get; set; }

    public bool Status { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? UserId { get; set; }

    public string? BranchName { get; set; }

    public string? StreetNumber { get; set; }

    public string? HouseNumber { get; set; }

    public string? Occupation { get; set; }

    public int? NumberOfDependants { get; set; }

    public string? Education { get; set; }

    public int? SocialEconomicClass { get; set; }

    public string? RelatedParty { get; set; }
}
