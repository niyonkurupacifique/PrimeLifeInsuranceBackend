using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewBeneFiciary
{
    public int _ { get; set; }

    public string Policy { get; set; } = null!;

    public string PolicyHolderId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Relationship { get; set; } = null!;

    public double BenefitPercentage { get; set; }

    public DateTime RecordDate { get; set; }

    public string RecordedBy { get; set; } = null!;
}
