using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class EpbeneficiaryNextOfKin
{
    public int AutoId { get; set; }

    public string SchemeNumber { get; set; } = null!;

    public string? InsuredName { get; set; }

    public string InsuredCode { get; set; } = null!;

    public string BeneficiaryCode { get; set; } = null!;

    public string BeneficiaryName { get; set; } = null!;

    public DateTime? DateOfBirth { get; set; }

    public string? Relationship { get; set; }
}
