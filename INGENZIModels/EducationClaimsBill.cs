using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EducationClaimsBill
{
    public int IdRecord { get; set; }

    public string ClaimNumber { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? ProductName { get; set; }

    public string? ClaimType { get; set; }

    public string? ClaimBillNumber { get; set; }

    public double? ClaimAmountDue { get; set; }

    public DateTime? BillDueDate { get; set; }

    public DateTime? RecordedDate { get; set; }

    public string? RecordUserName { get; set; }
}
