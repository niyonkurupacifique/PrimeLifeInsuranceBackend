using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class OccupationsClass
{
    public double OccupationId { get; set; }

    public string OccupationDescription { get; set; } = null!;

    public string OccupationClassId { get; set; } = null!;

    public bool? OccupationStatus { get; set; }
}
