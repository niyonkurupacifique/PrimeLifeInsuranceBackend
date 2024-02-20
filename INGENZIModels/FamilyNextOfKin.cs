using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class FamilyNextOfKin
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string NextOfKinCode { get; set; } = null!;

    public string? NextOfKinFullName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? Relationship { get; set; }

    public string? MobileNumber { get; set; }

    public string? IdDocumentType { get; set; }

    public string? IdDocumentNumber { get; set; }

    public double? Percentages { get; set; }

    public bool? Status { get; set; }
}
