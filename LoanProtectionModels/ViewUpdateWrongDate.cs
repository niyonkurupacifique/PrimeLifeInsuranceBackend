using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewUpdateWrongDate
{
    public string PolicyNumber { get; set; } = null!;

    public DateTime WrongStartDate { get; set; }

    public DateTime WrongEndDate { get; set; }

    public DateTime CorrectStartDate { get; set; }

    public DateTime CorrectEndDate { get; set; }

    public DateTime? WrongLoanEndDate { get; set; }

    public DateTime? CorrectLoanEndDate { get; set; }
}
