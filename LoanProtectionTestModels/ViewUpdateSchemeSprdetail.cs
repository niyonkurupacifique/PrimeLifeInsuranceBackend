using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class ViewUpdateSchemeSprdetail
{
    public string PolicyNumber { get; set; } = null!;

    public string PolicyNumberChild { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string? Channel { get; set; }

    public string SchemeIdOfChannel { get; set; } = null!;

    public string SchemeIdInRegister { get; set; } = null!;
}
