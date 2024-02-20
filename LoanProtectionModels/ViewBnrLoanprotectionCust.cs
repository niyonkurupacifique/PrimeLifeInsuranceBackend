using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewBnrLoanprotectionCust
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

    public string CustomerGender { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string MaritalStatus { get; set; } = null!;

    public int? SpouseName { get; set; }

    public string SocialEconomicClass { get; set; } = null!;

    public int? NextOfKinName { get; set; }

    public int NextOfKinIdType { get; set; }

    public int? NextOfKinIdNumber { get; set; }

    public int? NextOfKinTelephone { get; set; }

    public int? NumberOfDependants { get; set; }

    public string Nationality { get; set; } = null!;

    public string Residence { get; set; } = null!;

    public int? CommAddress1 { get; set; }

    public int? CommAddress2 { get; set; }

    public string? CommVillage { get; set; }

    public string CommCountry { get; set; } = null!;

    public int? CommResidenceType { get; set; }

    public int? PermAddress1 { get; set; }

    public int? PermAddress2 { get; set; }

    public string? PermVillage { get; set; }

    public string PermCountry { get; set; } = null!;

    public int? Expr2 { get; set; }

    public int? Expr3 { get; set; }

    public int? Expr4 { get; set; }

    public int? Expr5 { get; set; }

    public string Expr6 { get; set; } = null!;

    public int? EmailId { get; set; }

    public int? WorkTelephone { get; set; }

    public int? HomeTelephone { get; set; }

    public int? FaxNumber1 { get; set; }

    public int? FaxNumber2 { get; set; }

    public int? Education { get; set; }

    public int? CustomerTin { get; set; }

    public string NaicsCode { get; set; } = null!;

    public string EconomicSubSectorCodeIsic { get; set; } = null!;

    public string RelatedParty { get; set; } = null!;

    public string NationalIdType { get; set; } = null!;

    public string NationalIdNumber { get; set; } = null!;

    public int? HealthInsuranceNumber { get; set; }

    public string Occupation { get; set; } = null!;

    public int? EmployerName { get; set; }

    public int? EmployeeId { get; set; }

    public int? EmpAddress1 { get; set; }

    public int? EmpAddress2 { get; set; }

    public int? EmpVillage { get; set; }

    public int? EmpCountry { get; set; }

    public int? Income { get; set; }

    public int? IncomeFrequency { get; set; }

    public string LegalStatus { get; set; } = null!;

    public int CustomerStatus { get; set; }

    public DateTime DateLastModified { get; set; }
}
