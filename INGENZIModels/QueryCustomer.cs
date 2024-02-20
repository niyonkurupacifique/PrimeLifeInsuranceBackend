using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class QueryCustomer
{
    public string CustomerCode { get; set; } = null!;

    public string? Salutation { get; set; }

    public string? FullName { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? IdDocumentNumber { get; set; }
}
