using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionInsuranceCompany
{
    public int IdRecord { get; set; }

    public string IdInsuranceCompany { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string ContactPerson { get; set; } = null!;

    public string ContactPersonNumber { get; set; } = null!;

    public int Fees { get; set; }

    public bool Active { get; set; }

    public double? AcquisitionCoast { get; set; }

    public double? AdministrationFees { get; set; }

    public double? CompanyInterest { get; set; }

    public virtual ICollection<LoanProtectionAccountNumber> LoanProtectionAccountNumbers { get; set; } = new List<LoanProtectionAccountNumber>();
}
