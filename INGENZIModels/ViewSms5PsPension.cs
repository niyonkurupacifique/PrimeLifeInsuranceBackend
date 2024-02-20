using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSms5PsPension
{
    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public bool Cancelled { get; set; }

    public bool EndorsementMade { get; set; }

    public bool Suspended { get; set; }

    public string? PaymentChannel { get; set; }

    public DateOnly? DueDate { get; set; }

    public string PolicyNumberChild { get; set; } = null!;
}
