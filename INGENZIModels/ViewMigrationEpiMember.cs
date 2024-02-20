using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewMigrationEpiMember
{
    public string? PolicyNumber { get; set; }

    public string? CustomerCode { get; set; }

    public string MemberCode { get; set; } = null!;

    public string MemberFullName { get; set; } = null!;

    public int? FirstName { get; set; }

    public int? MiddleName { get; set; }

    public int? LastName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? Gender { get; set; }

    public string? Relationship { get; set; }

    public int? MobileNumber { get; set; }

    public int? IdDocumentType { get; set; }

    public int? IdDocumentNumber { get; set; }

    public int SumInsured { get; set; }

    public int Status { get; set; }

    public string NextOfKin { get; set; } = null!;

    public int Percentages { get; set; }
}
