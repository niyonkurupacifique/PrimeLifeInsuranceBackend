using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationMember
{
    public string FullName { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string Expr2 { get; set; } = null!;

    public string PolicyNumberEndo { get; set; } = null!;

    public string Expr1 { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string MemberCode { get; set; } = null!;

    public string? MemberFullName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? Relationship { get; set; }

    public bool? Status { get; set; }

    public string? NextOfKin { get; set; }

    public double? Percentages { get; set; }
}
