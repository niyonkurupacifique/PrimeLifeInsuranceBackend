using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewSearchCustomerAndPolDetail
{
    public string CustomerCode { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string PaymentMode { get; set; } = null!;

    public string? PolicyDate { get; set; }

    public string Salutation { get; set; } = null!;
}
