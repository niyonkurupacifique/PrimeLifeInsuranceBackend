using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewTransUnionCustomersAll
{
    public string CustomerType { get; set; } = null!;

    public string? Salutation { get; set; }

    public string? SurnameInstitutionName { get; set; }

    public string? FirstNameTradingName { get; set; }

    public string? MiddleName { get; set; }

    public string? IdentificationDocumentType { get; set; }

    public string? IdentificationDocumentNumber { get; set; }

    public string? MaritalStatus { get; set; }

    public string Gender { get; set; } = null!;

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

    public int? EmployerName { get; set; }

    public int? EmployerAddressLine1 { get; set; }

    public int? EmployerTown { get; set; }

    public int? EmployerCountry { get; set; }

    public int? EmployerDurationYears { get; set; }

    public int? EmployerDurationMonths { get; set; }

    public int? Income { get; set; }

    public int? IncomeFrequency { get; set; }
}
