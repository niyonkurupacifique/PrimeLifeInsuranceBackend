﻿using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsPolicyRegisterDetail
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double Contribution { get; set; }

    public int Term { get; set; }

    public DateTime RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public bool Cancelled { get; set; }

    public double SumAssured { get; set; }

    public bool EndorsementMade { get; set; }

    public bool Surrendered { get; set; }

    public bool Suspended { get; set; }

    public string? PaymentChannel { get; set; }

    public string? Channel { get; set; }

    public int? SendContract { get; set; }

    public string? SubProductType { get; set; }

    public string? SubPolicyNumber { get; set; }
}
