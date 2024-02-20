using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewUpdateCustomerEducation
{
    public int? IdRecord { get; set; }

    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public string? Names { get; set; }

    public string? IdNumber { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string FullName { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Title { get; set; }

    public DateTime? DoB { get; set; }

    public string? IssuedPlace { get; set; }

    public string? ResidenceDistrict { get; set; }

    public string? ResidenceSector { get; set; }

    public string? ResidenceCell { get; set; }

    public string? ResidenceVillage { get; set; }

    public string? Salutation { get; set; }

    public string? GenderNida { get; set; }

    public string? MaritalStatus { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? Sector { get; set; }

    public string? Cell { get; set; }

    public string? Village { get; set; }

    public string? VillageId { get; set; }
}
