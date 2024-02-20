using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewListOfPoliceEndosmentSavingPension
{
    public int IdRecord { get; set; }

    public string SchemeName { get; set; } = null!;

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

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public int Term { get; set; }

    public DateTime RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool Cancelled { get; set; }

    public double SumAssured { get; set; }

    public bool EndorsementMade { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public string SchemeId { get; set; } = null!;

    public string PolicyType { get; set; } = null!;

    public string? VendorName { get; set; }
}
