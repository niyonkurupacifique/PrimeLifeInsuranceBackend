﻿using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewPaymentsValidationsAllPayment
{
    public string? Uniquekey { get; set; }

    public int IdRecord { get; set; }

    public string? SchemeNumber { get; set; }

    public string PolicyNumberPayment { get; set; } = null!;

    public string ReferencePay { get; set; } = null!;

    public string PaymentChannel { get; set; } = null!;

    public string PaymentSource { get; set; } = null!;

    public DateTime? PaymentDate { get; set; }

    public double? AmountPayed { get; set; }

    public string? ProofOfPayment { get; set; }

    public string? Comments { get; set; }

    public string? UserId { get; set; }

    public bool? IntegratedAcc { get; set; }

    public DateOnly? IntegrationDate { get; set; }

    public string? CustomerCode { get; set; }

    public int? ReportingYear { get; set; }

    public int? ReportingMonth { get; set; }
}