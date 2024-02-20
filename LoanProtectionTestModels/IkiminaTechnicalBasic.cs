using System;
using System.Collections.Generic;

namespace c_.LoanProtectionTestModels;

public partial class IkiminaTechnicalBasic
{
    public int IdRecord { get; set; }

    public double? TechnicalRate { get; set; }

    public double? DailyTechnicalRate { get; set; }

    public double? ManagementFee { get; set; }

    public double? AcquisitionCost { get; set; }

    public double? DeathLoadingRate { get; set; }

    public double? MaxLoandingDepositAmount { get; set; }

    public double? MinLoadingSavingAmount { get; set; }

    public double? PartialSurrenderFee { get; set; }

    public double? TotalSurrenderFee { get; set; }

    public DateTime? RecordedDate { get; set; }

    public bool RateStatus { get; set; }
}
