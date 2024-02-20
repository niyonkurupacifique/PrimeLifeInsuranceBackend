using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewDEletepay
{
    public int IdRecord { get; set; }

    public string PolicyNumber { get; set; } = null!;

    public string IdBankBranch { get; set; } = null!;

    public DateTime DateOfPayement { get; set; }

    public string ReferencePayement { get; set; } = null!;

    public string? AccountNumberAndBank { get; set; }

    public DateTime? RecordDate { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime PolicyDate { get; set; }
}
