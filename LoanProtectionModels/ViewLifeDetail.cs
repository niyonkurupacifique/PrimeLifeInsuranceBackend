using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewLifeDetail
{
    public string IdDocumentNumber { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string IdDoc { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? CustCode { get; set; }
}
