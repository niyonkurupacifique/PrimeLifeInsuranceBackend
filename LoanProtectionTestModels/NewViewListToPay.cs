using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class NewViewListToPay
{
    public string Customer { get; set; } = null!;

    public string Names { get; set; } = null!;

    public string? SchemeId { get; set; }

    public string Policy { get; set; } = null!;

    public double Contribution { get; set; }

    public string Invoice { get; set; } = null!;

    public DateOnly? DueDate { get; set; }
}
