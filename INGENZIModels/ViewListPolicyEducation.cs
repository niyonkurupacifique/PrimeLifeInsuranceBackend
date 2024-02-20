using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewListPolicyEducation
{
    public string PolicyNumber { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public double? Premium { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? SchemeId { get; set; }
}
