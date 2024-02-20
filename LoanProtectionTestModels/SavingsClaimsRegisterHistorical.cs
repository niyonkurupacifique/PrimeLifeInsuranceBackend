﻿using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class SavingsClaimsRegisterHistorical
{
    public double? Numbers { get; set; }

    public string? Assured { get; set; }

    public string? Product { get; set; }

    public string? TypeOfClaims { get; set; }

    public string? PolicyNumber { get; set; }

    public string? PolicyNumberValid { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public double? AmountContributed { get; set; }

    public double? PaidAmount { get; set; }

    public DateTime? DateOfPayment { get; set; }
}
