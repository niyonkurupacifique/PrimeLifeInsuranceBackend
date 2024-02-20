using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class educationTariffs
{
    public byte Age { get; set; }

    public string PremiumFrequency { get; set; } = null!;

    public byte BenefitYears { get; set; }

    public byte ContributionYears { get; set; }
   

    public double RatePerMille { get; set; }
}
