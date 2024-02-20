using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewAllCustomersTable
{
    public string CustomerCode { get; set; } = null!;

    public string? FullName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string ProductName { get; set; } = null!;
}
