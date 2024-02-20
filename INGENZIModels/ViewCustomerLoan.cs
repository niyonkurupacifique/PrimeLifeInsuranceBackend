using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewCustomerLoan
{
    public string CustomerCode { get; set; } = null!;

    public string? Salutation { get; set; }

    public string FullName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string IdDocumentNumber { get; set; } = null!;

    public string PhoneNumber1 { get; set; } = null!;

    public string? PhoneNumber2 { get; set; }

    public int AccountStatus { get; set; }

    public string PolicyNumber { get; set; } = null!;
}
