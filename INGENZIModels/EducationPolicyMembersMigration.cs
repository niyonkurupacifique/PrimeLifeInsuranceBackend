using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationPolicyMembersMigration
{
    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public string? MemberCode { get; set; }

    public string? MemberFullName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? Relationship { get; set; }

    public string? MobileNumber { get; set; }

    public string? IdDocumentType { get; set; }

    public string? IdDocumentNumber { get; set; }

    public double? SumInsured { get; set; }

    public bool Status { get; set; }

    public string? NextOfKin { get; set; }

    public double? Percentages { get; set; }

    public double? DuringDeferredPeriod { get; set; }
}
