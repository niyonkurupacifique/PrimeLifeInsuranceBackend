using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewUsersReview
{
    public int IdRecord { get; set; }

    public string Names { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string? Phone { get; set; }

    public bool Active { get; set; }

    public string BankName { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public bool? AnnualPayement { get; set; }

    public bool? Payements { get; set; }

    public bool? Cancellation { get; set; }

    public bool? Reports { get; set; }

    public bool? Deleting { get; set; }

    public bool? Approval { get; set; }

    public bool? Limit { get; set; }

    public bool? Claims { get; set; }

    public bool Property { get; set; }

    public bool Travel { get; set; }

    public bool? NormalEdit { get; set; }

    public bool? AdvancedEdit { get; set; }

    public bool NormalEditProperty { get; set; }

    public bool AdvancedEditProperty { get; set; }
}
