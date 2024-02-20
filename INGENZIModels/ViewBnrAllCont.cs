using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewBnrAllCont
{
    public string Country { get; set; } = null!;

    public string LeBook { get; set; } = null!;

    public string ContractId { get; set; } = null!;

    public string? CustomerId { get; set; }

    public string VisionOuc { get; set; } = null!;

    public string VisionSbu { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public DateTime? MaturityDate { get; set; }

    public string DealType { get; set; } = null!;

    public string DealSubType { get; set; } = null!;

    public int ContractApplicationFee { get; set; }

    public double ContractAdministrativeFee { get; set; }

    public string Currency { get; set; } = null!;

    public string PrincipalGl { get; set; } = null!;

    public double? PrincipalAmountFcy { get; set; }

    public double? PrincipalAmountLcy { get; set; }

    public int ContractStatus { get; set; }

    public string PolicyType { get; set; } = null!;

    public int? NumOfCoveredPersons { get; set; }

    public double SumInsured { get; set; }

    public string? Assured { get; set; }

    public DateTime? CommenceDate { get; set; }

    public DateTime? BenefitExpiryDate { get; set; }

    public string PremiumPaymentFreq { get; set; } = null!;

    public double SumReassured { get; set; }

    public DateTime? DateLastModified { get; set; }
}
