using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionUser
{
    public int IdRecord { get; set; }

    public string Names { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public bool Active { get; set; }

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

    public bool? AnnualPayement { get; set; }

    public string? IntacctEmployeeId { get; set; }

    public string? IntacctClassId { get; set; }

    public bool NormalEditProperty { get; set; }

    public bool AdvancedEditProperty { get; set; }

    public virtual ICollection<LoanProtectionUserAccess> LoanProtectionUserAccesses { get; set; } = new List<LoanProtectionUserAccess>();
}
