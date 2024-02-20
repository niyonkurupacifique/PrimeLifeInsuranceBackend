using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewInvoicingEpi
{
    public int? RecordNumber { get; set; }

    public string? SchemeNumber { get; set; }

    public DateTime? DueDate { get; set; }

    public double? DueAmount { get; set; }

    public string? InsuredName { get; set; }

    public string? InsuredCode { get; set; }
}
