using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewDigitalNotConvertedReminder
{
    public string FullName { get; set; } = null!;

    public string? PhoneNumber1 { get; set; }

    public int IdRecord { get; set; }

    public string ProposalNumber { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? SchemeId { get; set; }

    public double Premium { get; set; }

    public DateTime? RecordedDate { get; set; }

    public bool? Converted { get; set; }

    public DateTime? ConvertedDate { get; set; }

    public string? Product { get; set; }
}
