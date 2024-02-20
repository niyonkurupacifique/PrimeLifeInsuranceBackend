using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewBnrAllCustomersPensionSaving
{
    public string Country { get; set; } = null!;

    public string LeBook { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string? Salutation { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Forename1 { get; set; } = null!;

    public string Forename2 { get; set; } = null!;

    public string CustomerAcronym { get; set; } = null!;

    public string VisionOuc { get; set; } = null!;

    public string VisionSbu { get; set; } = null!;

    public DateTime? CustomerOpenDate { get; set; }

    public string? CustomerGender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string PlaceOfBirth { get; set; } = null!;

    public string MaritalStatus { get; set; } = null!;

    public int? SpouseName { get; set; }

    public int SocialEconomicClass { get; set; }

    public int? NextOfKinName { get; set; }

    public int? NextOfKinIdType { get; set; }

    public int? NextOfKinIdNumber { get; set; }

    public int? NextOfKinTelephone { get; set; }

    public int? NextOfKinEmailId { get; set; }

    public int? NumberOfDependants { get; set; }

    public string Nationality { get; set; } = null!;

    public string Residence { get; set; } = null!;

    public int? CommAddress1 { get; set; }

    public int? CommAddress2 { get; set; }

    public string CommVillage { get; set; } = null!;

    public string CommCountry { get; set; } = null!;

    public int? CommResidenceType { get; set; }

    public int? PermAddress1 { get; set; }

    public int? PermAddress2 { get; set; }

    public string PermVillage { get; set; } = null!;

    public string PermCountry { get; set; } = null!;

    public string? EmailId { get; set; }

    public string? WorkTelephone { get; set; }

    public int? HomeTelephone { get; set; }

    public int? FaxNumber1 { get; set; }

    public int? FaxNumber2 { get; set; }

    public int? Education { get; set; }

    public int? CustomerTin { get; set; }

    public int NaicsCode { get; set; }

    public int EconomicSubSectorCodeIsic { get; set; }

    public string RelatedParty { get; set; } = null!;

    public int RelationshipType { get; set; }

    public int? RelatedPartyName { get; set; }

    public int? SsnNumber { get; set; }

    public int NationalIdType { get; set; }

    public string? NationalIdNumber { get; set; }

    public int? HealthInsuranceNumber { get; set; }

    public int Occupation { get; set; }

    public int? EmployerName { get; set; }

    public int? EmployeeId { get; set; }

    public int? EmpAddress1 { get; set; }

    public int? EmpAddress2 { get; set; }

    public int? EmpVillage { get; set; }

    public int? EmpCountry { get; set; }

    public int? Income { get; set; }

    public string IncomeFrequency { get; set; } = null!;

    public int LegalStatus { get; set; }

    public int AccountStatus { get; set; }

    public DateTime? DateLastModified { get; set; }
}
