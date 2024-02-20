using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class TestMisMachCustomerCode
{
    public string PolicyNumber { get; set; } = null!;

    public string IdDocumentNumber { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? CustomerCodeCust { get; set; }

    public string IdDocCustomer { get; set; } = null!;
}
