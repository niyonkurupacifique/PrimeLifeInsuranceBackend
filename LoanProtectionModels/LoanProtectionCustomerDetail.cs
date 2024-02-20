using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionCustomerDetail
{
    public int IdRecord { get; set; }

    public string IdDocumentNumber { get; set; } = null!;

    public bool WheightChange { get; set; }

    public bool StopWorkFromIllness { get; set; }

    public bool FortDrug { get; set; }

    public bool Hivtest { get; set; }

    public bool Hepatatis { get; set; }

    public bool Sugery { get; set; }

    public bool Cancer { get; set; }

    public bool Diabetes { get; set; }

    public bool HeartIllness { get; set; }

    public string Comments { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public bool? Kidney { get; set; }
}
