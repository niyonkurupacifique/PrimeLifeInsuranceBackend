using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewTransUnionCustomerLoan
{
    public string? CustomerType { get; set; }

    public string? Salutation { get; set; }

    public string SurnameInstitutionName { get; set; } = null!;

    public string FirstNameTradingName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string IdentificationDocumentType { get; set; } = null!;

    public string IdentificationDocumentNumber { get; set; } = null!;

    public string? MaritalStatus { get; set; }

    public string? Gender { get; set; }

    public string? DateOfBirthOrRegistration { get; set; }

    public int? PlaceOfBirthRegistration { get; set; }

    public int? PhysicalAddress { get; set; }

    public int? EmailAddress { get; set; }

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Sector { get; set; }

    public string? Cell { get; set; }

    public string Country { get; set; } = null!;

    public int? WorkTelephone { get; set; }

    public int? HomeTelephone { get; set; }

    public string? MobileTelephone { get; set; }

    public int? FascimileFax { get; set; }

    public string EmployerName { get; set; } = null!;

    public string EmployerAddressLine1 { get; set; } = null!;

    public string EmployerTown { get; set; } = null!;

    public string EmployerCountry { get; set; } = null!;

    public int? EmployerDurationYears { get; set; }

    public int? EmployerDurationMonths { get; set; }

    public int? Income { get; set; }

    public int? IncomeFrequency { get; set; }
}
