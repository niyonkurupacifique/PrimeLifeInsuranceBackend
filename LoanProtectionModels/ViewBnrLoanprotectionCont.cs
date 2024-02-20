using System;
using System.Collections.Generic;

namespace c_.LoanProtectionModels;

public partial class ViewBnrLoanprotectionCont
{
    public string Country { get; set; } = null!;

    public int LeBook { get; set; }

    public string ContractId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public string VisionOuc { get; set; } = null!;

    public string VisionSbu { get; set; } = null!;

    public string? StartDate { get; set; }

    public string? MaturityDate { get; set; }

    public string DealType { get; set; } = null!;

    public string DealSubType { get; set; } = null!;

    public int ContractApplicationFee { get; set; }

    public double ContractAdministrativeFee { get; set; }

    public string Currency { get; set; } = null!;

    public string PrincipalGl { get; set; } = null!;

    public double PrincipalAmountFcy { get; set; }

    public double PrincipalAmountLcy { get; set; }

    public int ContractStatus { get; set; }

    public string? AccountStatusDate { get; set; }

    public string VisionGl { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public string PublicSectorCode { get; set; } = null!;

    public string InstitutionalSectorCode { get; set; } = null!;

    public string RenewalPolicyFlag { get; set; } = null!;

    public int NumOfBeneficiaries { get; set; }

    public int PolicyWrittenThru { get; set; }

    public string? DateLastModified { get; set; }
}
