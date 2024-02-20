using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewSmsDigitalIkiminaNotConverted
{
    public int IdRecord { get; set; }

    public string FullName { get; set; } = null!;

    public string ProposalNumber { get; set; } = null!;

    public string? CustomerCode { get; set; }

    public string? SchemeId { get; set; }

    public DateTime? ProposalDate { get; set; }

    public double Premium { get; set; }

    public string? ProductCategory { get; set; }

    public string? PaymentMode { get; set; }

    public DateTime? RecordedDate { get; set; }

    public bool? Converted { get; set; }

    public string? Product { get; set; }
}
