using System;
using System.Collections.Generic;

namespace c_.INGENZIModels;

public partial class ViewBnrAllAcct
{
    public string Country { get; set; } = null!;

    public string LeBook { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string? AccountName { get; set; }

    public string VisionOuc { get; set; } = null!;

    public string VisionSbu { get; set; } = null!;

    public int AccountStatus { get; set; }

    public DateTime? AccountStatusDate { get; set; }

    public string? CustomerId { get; set; }

    public string Currency { get; set; } = null!;

    public string VisionGl { get; set; } = null!;

    public string AccountType { get; set; } = null!;

    public DateTime? AccountOpenDate { get; set; }

    public DateTime? AccountClosingDate { get; set; }

    public string PublicSectorCode { get; set; } = null!;

    public string InstitutionalSectorCode { get; set; } = null!;

    public string RenewalPolicyFlag { get; set; } = null!;

    public int? NumOfBeneficiaries { get; set; }

    public int PolicyWrittenThru { get; set; }

    public DateTime? DateLastModified { get; set; }
}
