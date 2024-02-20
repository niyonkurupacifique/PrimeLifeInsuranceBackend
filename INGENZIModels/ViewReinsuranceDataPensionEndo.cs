using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewReinsuranceDataPensionEndo
{
    public string? IdDocumentNumber { get; set; }

    public double SumAssured { get; set; }

    public string PolicyNumberChild { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
