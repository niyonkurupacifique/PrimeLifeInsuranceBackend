using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationTempBeneficiary
{
    public int IdRecord { get; set; }

    public string MemberCode { get; set; } = null!;

    public string? MemberFullName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? Relationship { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? MobileNumber { get; set; }

    public string? PaymentMode { get; set; }

    public string? BankAccount { get; set; }

    public string? BankName { get; set; }

    public double? Percentages { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string UserName { get; set; } = null!;
}
