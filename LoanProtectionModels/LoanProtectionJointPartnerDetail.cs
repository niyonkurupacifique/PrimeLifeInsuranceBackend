using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionJointPartnerDetail
{
    public int IdRecord { get; set; }

    public string IdDocumentNumber { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PartnerId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string SpouseName { get; set; } = null!;

    public string? PhoneNumber { get; set; }
}
