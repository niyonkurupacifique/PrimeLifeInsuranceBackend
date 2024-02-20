using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewReinsuranceDataLoanProtection
{
    public string IdDocumentNumber { get; set; } = null!;

    public double LoanAmount { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
