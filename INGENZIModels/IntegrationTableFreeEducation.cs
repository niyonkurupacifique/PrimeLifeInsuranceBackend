using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class IntegrationTableFreeEducation
{
    public int IdRecord { get; set; }

    public string ExternalTransaction { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public DateTime CreationDate { get; set; }
}
