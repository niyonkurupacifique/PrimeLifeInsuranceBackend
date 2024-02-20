using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewPolicyFamilly
{
    public string CustomerCode { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string PolicyNumber { get; set; } = null!;

    public DateTime? EffectiveDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public DateOnly? CreationDate { get; set; }

    public DateOnly? RecordedDate { get; set; }

    public bool Status { get; set; }
}
