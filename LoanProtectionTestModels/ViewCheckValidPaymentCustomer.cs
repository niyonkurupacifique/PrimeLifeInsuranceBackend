using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewCheckValidPaymentCustomer
{
    public string? UniqueKey { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string? IdDocumentNumber { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNumber { get; set; }
}
