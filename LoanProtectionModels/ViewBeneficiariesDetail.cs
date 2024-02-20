using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewBeneficiariesDetail
{
    public int _ { get; set; }

    public string? Names { get; set; }

    public string? Relationship { get; set; }

    public double Benefit { get; set; }

    public string? UserName { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;
}
