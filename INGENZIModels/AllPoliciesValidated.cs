using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class AllPoliciesValidated
{
    public string? CustomerCode { get; set; }

    public string? Names { get; set; }

    public string? Gender { get; set; }

    public string? Product { get; set; }

    public string? PolicyNumber { get; set; }

    public double? Amountpaid { get; set; }

    public DateTime? Paymentdate { get; set; }

    public DateTime? DatePolicy { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? Premium { get; set; }

    public double? Differed { get; set; }

    public string? PolicyStatus { get; set; }
}
