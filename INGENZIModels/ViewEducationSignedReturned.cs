using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewEducationSignedReturned
{
    public string PolicyNumberEndo { get; set; } = null!;

    public DateTime? DatePolicy { get; set; }

    public DateTime? StartDate { get; set; }

    public bool? Signed { get; set; }

    public DateTime? SignedDate { get; set; }

    public string PolicyStatus { get; set; } = null!;

    public string Product { get; set; } = null!;
}
