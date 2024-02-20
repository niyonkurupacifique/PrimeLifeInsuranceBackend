﻿using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEligiblePoliciesFamily
{
    public string? CustomerCode { get; set; }

    public string? IdDocument { get; set; }

    public string Names { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string EndorsementNumber { get; set; } = null!;

    public double RiskPremium { get; set; }

    public string Product { get; set; } = null!;

    public string PolicyStatus { get; set; } = null!;

    public string? PaymentMode { get; set; }

    public string? PaymentSource { get; set; }

    public string SchemeId { get; set; } = null!;

    public string? ChannelName { get; set; }

    public double? TotalPremiumDue { get; set; }

    public double? TotalAmountPaid { get; set; }

    public double? Outstanding { get; set; }

    public DateTime? MaxPaymentDate { get; set; }

    public string? PhoneNumber1 { get; set; }
}
