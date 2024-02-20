using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class AuditCustomersInfo
{
    public int IdRecord { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? IdDocumentNumber { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? Comments { get; set; }

    public string? UserName { get; set; }

    public DateTime? RecoredDate { get; set; }
}
