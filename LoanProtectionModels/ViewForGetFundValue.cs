﻿using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewForGetFundValue
{
    public string IdentityRecord { get; set; } = null!;

    public int Period { get; set; }

    public string? SchemeNumber { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public double Contribution { get; set; }

    public double ManagementFees { get; set; }

    public double InstallmentFees { get; set; }

    public double Rate { get; set; }

    public double Commission { get; set; }

    public double PensionAmt { get; set; }

    public double InvestedPremium { get; set; }

    public double AcquiredValue { get; set; }

    public DateTime? DueDate { get; set; }
}
